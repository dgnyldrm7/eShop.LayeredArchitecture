namespace App.UI.Middlewares
{
    public class AuthenticationMiddleware(RequestDelegate _next)
    {

        // Sadece yetkilendirme gerektiren sayfalar
        private static readonly string[] ProtectedRoutes =
        {
            "/dashboard",
            "/profile",
            "/orders"
        };

        public async Task Invoke(HttpContext context)
        {
            // Eğer istek korunan bir route içinse ve kullanıcı giriş yapmamışsa yönlendir
            if (!context.User.Identity!.IsAuthenticated &&
                ProtectedRoutes.Any(route => context.Request.Path.StartsWithSegments(route)))
            {
                context.Response.Redirect("/account/login");
                return;
            }

            await _next(context);
        }
    }
}
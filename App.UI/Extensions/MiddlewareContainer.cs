using App.UI.Middlewares;

namespace App.UI.Extensions
{
    public static class MiddlewareContainer
    {
        public static void AddMiddlewares(this WebApplication app)
        {
            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            //Add Custom Middleware
            app.UseMiddleware<AuthenticationMiddleware>();

            app.UseAuthentication();

            app.UseAuthorization();

            app.MapRazorPages();
        }
    }
}
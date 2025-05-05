using App.Persistance.Extensions;
using App.Persistance.Options;
using App.Services.Extensions;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

//Persistance -> AddDbContext and Identity DbContext
//For IOptions<ConnectionStrings> - bind etme i�lemi
builder.Services.Configure<ConnectionStrings>(builder.Configuration.GetSection(ConnectionStrings.Key));

builder.AddDbContexts(builder.Configuration);

builder.AddIdentityServices();

builder.AddInfrastructureServices();

builder.AddPersistanceDIContainer();

builder.AddServiceDIContainer();

//BURDA COOKIE ��LEMLER�NE GER� D�N!!!
/*
builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Account/Login";
    options.LogoutPath = "/Account/Logout";
    options.AccessDeniedPath = "/Account/AccessDenied";
    options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
    options.SlidingExpiration = true;
});
*/


builder.Logging.ClearProviders(); // �nce t�m loggerlar� sil
builder.Logging.AddConsole(); // sonra sadece ihtiyac�n olanlar� ekle (mesela Console)


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//Persistance -> All Middleware Congigurations
app.AddMiddlewares();

app.Run();
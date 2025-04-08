using App.Persistance.Extensions;
using App.Persistance.Options;
using App.Services.Implementations;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

//Persistance -> AddDbContext and Identity DbContext
//For IOptions<ConnectionStrings> - bind etme iþlemi
builder.Services.Configure<ConnectionStrings>(builder.Configuration.GetSection(ConnectionStrings.Key));

builder.AddDbContexts(builder.Configuration);

builder.AddIdentityServices();

builder.AddInfrastructureServices();

builder.AddDIContainer();

builder.Services.AddScoped<ProductService>();

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
using Microsoft.Extensions.DependencyInjection;
using YemekTarifiApp.Context;
using Microsoft.EntityFrameworkCore;
using YemekTarifiWebApi.Interface;
using YemekTarifiWebApi.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<BackEndContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionString")));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ICommentRepository, CommentRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddSwaggerGenNewtonsoftSupport();
builder.Services.AddControllersWithViews().AddNewtonsoftJson();



var app = builder.Build();


// Configure the HTTP request pipeline.

app.UseSwagger();
//app.UseSwaggerUI(c =>
//{
//    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My Test1 Api v1");
//    c.RoutePrefix = string.Empty;
//});
app.UseSwaggerUI();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

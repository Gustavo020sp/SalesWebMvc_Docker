using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SalesWebMvc.Data;
using SalesWebMvc.Services;
using System.Net.Sockets;

namespace SalesWebMvc
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);
			builder.Services.AddDbContext<SalesWebMvcContext>(options =>
				options.UseSqlServer(builder.Configuration.GetConnectionString("SalesWebMvcContext")));

            builder.WebHost.UseUrls("http://*:80");

            // Add services to the container.
            builder.Services.AddControllersWithViews();
			builder.Services.AddScoped<SeedingService>();
			builder.Services.AddScoped<SalesRecordService>();
		    builder.Services.AddScoped<LoginService>();

			var app = builder.Build();

			// Apply migrations and seed database
			//ApplyMigrations(app);

			//void ApplyMigrations(IHost app)
			//{
			//	using (var scope = app.Services.CreateScope())
			//	{
			//		var context = scope.ServiceProvider.GetRequiredService<SalesWebMvcContext>();
			//		context.Database.Migrate();
			//	}
			//}


			//unico metodo que funcionou --sem implementar no Startup.cs
			//SeedDatabase();
			//void SeedDatabase()
			//{
			//	using (var scope = app.Services.CreateScope())
			//	{
			//		var dbInitializer = scope.ServiceProvider.GetRequiredService<SeedingService>();
			//		dbInitializer.Seed(app);
			//	}
			//}

			// Configure the HTTP request pipeline.
			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthorization();

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Login}/{action=Index}/{id?}");

			app.Run();
		}
	}
}

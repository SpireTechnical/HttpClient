using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Forcible.Client
{
	public class Program
	{
		public static async Task Main(string[] args)
		{
			var builder = WebAssemblyHostBuilder.CreateDefault(args);
			builder.RootComponents.Add<App>("#app");

			builder.Services.AddHttpClient("Forcible.ServerAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress))
				.AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();
			builder.Services.AddHttpClient("IP", client => client.BaseAddress = new Uri("https://ipinfo.io/"))
				.AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

			//builder.Services.AddHttpClient("Location", options =>
			//{
			//	options.BaseAddress = new Uri("https://api.ipstack.com");
			//});
			// Supply HttpClient instances that include access tokens when making requests to the server project
			builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("Forcible.ServerAPI"));


			ConfigureServices(builder.Services);
			await builder.Build().RunAsync();
		}

		public static void ConfigureServices(IServiceCollection services)
		{
			services.AddApiAuthorization();
			services.AddScoped<IHttpIPClient, HttpIPClient>();
			services.AddScoped<IHttpGeoLocationClient, HttpGeoLocationClient>();

			//services.AddBlazoredLocalStorage();
			//services.AddScoped<AuthenticationStateProvider, ApiAuthenticationStateProvider>();
			//services.AddScoped<IAuthService, AuthService>();
			//services.AddScoped<IProfileRepository, ProfileRepository>();
			//services.AddScoped<IApiClientService, ApiClientService>();
		}
	}
}

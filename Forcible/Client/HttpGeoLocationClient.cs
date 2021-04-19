using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Forcible.Client
{
	public class HttpGeoLocationClient : IHttpGeoLocationClient
	{
		private readonly IHttpClientFactory _factory;
		private HttpClient _client;

		public HttpGeoLocationClient(IHttpClientFactory factory)
		{
			_factory = factory;
		}

		public string GetUri()
		{
			return _client.BaseAddress.ToString();
		}

		public async Task<MemberGeoLocation> GetGeoLocationAsync(string ipAddress)
		{
			_client = _factory.CreateClient();

			_client.BaseAddress = new Uri("https://api.ipstack.com/");
			string ipstack_key = "1675e9b93605b939b9e2fec2ff13c770";
			var path = $"/{ipAddress}?access_key={ipstack_key}";
			var response = await _client.GetFromJsonAsync<MemberGeoLocation>(path);

			return response;
		}

		public void SetUri(string Uri)
		{
			string defaultUri = "https://api.ipstack.com/"; // Make as a const name
			if (!string.IsNullOrEmpty(Uri))
			{
				defaultUri = Uri;
			}
			_client.BaseAddress = new Uri(defaultUri);
		}
	}
}

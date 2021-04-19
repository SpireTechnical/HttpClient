using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Forcible.Client
{
	public class HttpIPClient : IHttpIPClient
	{
		private readonly IHttpClientFactory _factory;
		private HttpClient _client;

		public HttpIPClient(IHttpClientFactory factory )
		{
			_factory = factory;
		}

		public string GetUri()
		{
			return _client.BaseAddress.ToString();
		}

		public async Task<MemberIPAddress> GetResponseAsync()
		{
			_client = _factory.CreateClient();

			_client.BaseAddress = new Uri("https://ipinfo.io/");
			var response = await _client.GetFromJsonAsync<MemberIPAddress>("json?token=e3adccc47d53c2");

			return response;
		}

		public async Task<string> GetIPAddressAsync()
		{
			string _value = string.Empty;

			var response = await GetResponseAsync();

			if(response != null)
			{
				_value = response.Ip;
			}
			return _value;
		}

		public void SetUri(string Uri)
		{
			string defaultUri = "https://ipinfo.io/"; // Make as a const name
			if(!string.IsNullOrEmpty(Uri))
			{
				defaultUri = Uri;
			}
			_client.BaseAddress = new Uri(defaultUri);
		}
	}
}

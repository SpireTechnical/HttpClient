using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Forcible.Client
{
	public interface IHttpGeoLocationClient
	{
		string GetUri();
		Task<MemberGeoLocation> GetGeoLocationAsync(string ipAddress);
		void SetUri(string Uri);

	}
}

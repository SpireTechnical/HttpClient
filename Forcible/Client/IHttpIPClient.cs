using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forcible.Client
{
	public interface IHttpIPClient
	{
		void SetUri(string Uri);
		string GetUri();
		Task<string> GetIPAddressAsync();
		Task<MemberIPAddress> GetResponseAsync();
	}
}

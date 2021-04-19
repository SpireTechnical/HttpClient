using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Forcible.Client
{
	public class Language
	{
		[JsonPropertyName("code")]
		public string Code { get; set; }

		[JsonPropertyName("name")]
		public string Name { get; set; }

		[JsonPropertyName("native")]
		public string Native { get; set; }
	}

	public class Location
	{
		[JsonPropertyName("geoname_id")]
		public int GeonameId { get; set; }

		[JsonPropertyName("capital")]
		public string Capital { get; set; }

		[JsonPropertyName("languages")]
		public List<Language> Languages { get; set; }

		[JsonPropertyName("country_flag")]
		public string CountryFlag { get; set; }

		[JsonPropertyName("country_flag_emoji")]
		public string CountryFlagEmoji { get; set; }

		[JsonPropertyName("country_flag_emoji_unicode")]
		public string CountryFlagEmojiUnicode { get; set; }

		[JsonPropertyName("calling_code")]
		public string CallingCode { get; set; }

		[JsonPropertyName("is_eu")]
		public bool IsEu { get; set; }
	}

	public class TimeZone
	{
		[JsonPropertyName("id")]
		public string Id { get; set; }

		[JsonPropertyName("current_time")]
		public DateTime CurrentTime { get; set; }

		[JsonPropertyName("gmt_offset")]
		public int GmtOffset { get; set; }

		[JsonPropertyName("code")]
		public string Code { get; set; }

		[JsonPropertyName("is_daylight_saving")]
		public bool IsDaylightSaving { get; set; }
	}

	public class Currency
	{
		[JsonPropertyName("code")]
		public string Code { get; set; }

		[JsonPropertyName("name")]
		public string Name { get; set; }

		[JsonPropertyName("plural")]
		public string Plural { get; set; }

		[JsonPropertyName("symbol")]
		public string Symbol { get; set; }

		[JsonPropertyName("symbol_native")]
		public string SymbolNative { get; set; }
	}

	public class Connection
	{
		[JsonPropertyName("asn")]
		public int Asn { get; set; }

		[JsonPropertyName("isp")]
		public string Isp { get; set; }
	}

	public class MemberGeoLocation
	{
		[JsonPropertyName("ip")]
		public string Ip { get; set; }

		[JsonPropertyName("type")]
		public string Type { get; set; }

		[JsonPropertyName("continent_code")]
		public string ContinentCode { get; set; }

		[JsonPropertyName("continent_name")]
		public string ContinentName { get; set; }

		[JsonPropertyName("country_code")]
		public string CountryCode { get; set; }

		[JsonPropertyName("country_name")]
		public string CountryName { get; set; }

		[JsonPropertyName("region_code")]
		public string RegionCode { get; set; }

		[JsonPropertyName("region_name")]
		public string RegionName { get; set; }

		[JsonPropertyName("city")]
		public string City { get; set; }

		[JsonPropertyName("zip")]
		public string Zip { get; set; }

		[JsonPropertyName("latitude")]
		public double Latitude { get; set; }

		[JsonPropertyName("longitude")]
		public double Longitude { get; set; }

		[JsonPropertyName("location")]
		public Location Location { get; set; }

		[JsonPropertyName("time_zone")]
		public TimeZone TimeZone { get; set; }

		[JsonPropertyName("currency")]
		public Currency Currency { get; set; }

		[JsonPropertyName("connection")]
		public Connection Connection { get; set; }
	}
}

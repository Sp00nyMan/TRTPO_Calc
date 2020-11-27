using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;

namespace TRTPO_CALC
{
	public static class CurrencyParser
	{
		private class Response
		{
			public Dictionary<string, double> rates;
			public string Base;
			public DateTime Date;
		}
		private const string URL = "https://api.exchangeratesapi.io/";

		public enum Currency
		{ 
			[Description("United States dollar")]
			USD,
			[Description("Euro")]
			EUR,
			[Description("Russian ruble")]
			RUB,
			[Description("Czech koruna")]
			CZK,
			[Description("Polish zloty")]
			PLN,
			[Description("Indian rupee")]
			INR,
			[Description("Mexican peso")]
			MXN,
			[Description("Canadian dollar")]
			CAD
		}

		private static string getRequestString(string symbol1, string symbol2)
		{
			return "latest" + $"?base={symbol1}&symbols={symbol2}";
		}

		public static double getExchangeRate(string fromCurrencyCode, string toCurrencyCode)
		{
			if (fromCurrencyCode == toCurrencyCode)
				return 1;

			var client = new HttpClient(new HttpClientHandler {AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate});
			client.BaseAddress = new Uri(URL);
			
			HttpResponseMessage response = client.GetAsync(getRequestString(fromCurrencyCode, toCurrencyCode)).Result;
			response.EnsureSuccessStatusCode();
			
			string result = response.Content.ReadAsStringAsync().Result;
			Response info = JsonConvert.DeserializeObject<Response>(result);
				
			return info.rates[toCurrencyCode];
		}
	}
}
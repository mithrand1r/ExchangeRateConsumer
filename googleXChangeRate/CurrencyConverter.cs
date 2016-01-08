using System.Net;
using System.Text.RegularExpressions;

 
namespace CurrencyConverter
{
    public static class ExchangeRateCalculator
    {
        public static Converter Convert(int amount, string fromCurrency, string toCurrency)
        {
            WebClient web = new WebClient();
            string url = string.Format(@"http://currency-api.appspot.com/api/{0}/{1}.json?amount={2}", fromCurrency.ToUpper(), toCurrency.ToUpper(),amount);
            Converter response = (Converter)Newtonsoft.Json.JsonConvert.DeserializeObject(web.DownloadString(url),typeof(Converter));
            return response;
        }
    }
}
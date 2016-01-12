using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace StockHelper
{
    public class SharePrice
    {
        public SharePrice()
        {
            
        }
        public float getActualSharePrice(string token)
        {
            float result=0;
            string format = "l1";
            WebClient web = new WebClient();
            string url = string.Format(@"http://finance.yahoo.com/d/quotes.csv?s={0}&f={1}", token, format);
            byte[] sharePriceArray=web.DownloadData(url);
            string sharePriceString = Encoding.ASCII.GetString(sharePriceArray).Replace("\n","");
            result = XmlConvert.ToSingle(sharePriceString);
            return result;
        }
    }
}

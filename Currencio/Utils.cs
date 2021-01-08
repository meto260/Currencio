using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Currencio
{
    public static class Utils
    {
        const string url = "https://api.exchangeratesapi.io/";
        public static async Task<string> JsonFromWeb(this string uripath)
        {
            WebClient web = new WebClient();
            string fulluri = url + uripath;
            string result = await web.DownloadStringTaskAsync(fulluri);
            return result;
        }

        public static T FromJson<T>(this string data) => JsonConvert.DeserializeObject<T>(data);

        public static async Task<PairModel> GetPrices(string pair) {
            PairModel data = (await $"latest?base={pair}".JsonFromWeb()).FromJson<PairModel>();
            return data;
        }
    }
}

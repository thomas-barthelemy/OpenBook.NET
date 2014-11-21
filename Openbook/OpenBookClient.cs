using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace OpenBook
{
    public class OpenBookClient
    {
        public OpenBookClient()
        {
            
        }


        internal async Task<string> RequestUriAsync(Uri uri)
        {
            var request = (HttpWebRequest) WebRequest.Create(uri);

            using (var response = await request.GetResponseAsync())
            {
                using (var resStream = new StreamReader(response.GetResponseStream()))
                {
                    return await resStream.ReadToEndAsync();
                }
            }
        }
    }
}

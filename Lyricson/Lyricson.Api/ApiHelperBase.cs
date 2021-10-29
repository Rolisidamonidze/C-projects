using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Lyricson.Api
{
   public class ApiHelperBase<TModel>
   {
      public static HttpClient ApiClient { get; set; }
      public ApiHelperBase(string baseUrl)
      {
         InitializeClient();
      }

      protected async Task<TModel> GetAsync(string url)
      {
         using (HttpResponseMessage response = await ApiClient.GetAsync(url))
         {
            if (response.IsSuccessStatusCode)
            {
               TModel model = await response.Content.ReadAsAsync<TModel>();
               return model;
            } else
            {
               throw new Exception(response.ReasonPhrase);
            }
         }
      }

      public static void InitializeClient()
      {
         ApiClient = new HttpClient();
         ApiClient.DefaultRequestHeaders.Accept.Clear();
         ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
      }
   }
}

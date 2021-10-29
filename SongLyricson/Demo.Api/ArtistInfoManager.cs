using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Api {
   public class ArtistInfoManager : ApiHelperBase<string> {
      public ArtistInfoManager() : base(_baseUrl) {
      }

      public async Task<string> SearchArtist(string artist) {
         return await GetAsync($"{_baseUrl}artist.search?q_artist={artist}&apikey={_apiKey}");
      }

      private static readonly string _apiKey = "d1e438be129c0151c3e444d2e8f0e6d0";
      private static readonly string _baseUrl = "https://api.musixmatch.com/ws/1.1/";
   }
}

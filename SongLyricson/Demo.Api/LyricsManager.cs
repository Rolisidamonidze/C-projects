using Demo.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Api {
   public class LyricsManager : ApiHelperBase<LyricsModel> {

      private static readonly string _baseUrl = "https://api.lyrics.ovh/v1/";
      public LyricsManager() : base(_baseUrl) {

      }
      public async Task<LyricsModel> GetLyrics(string artist, string songTitle) {
         return await GetAsync($"{_baseUrl}{artist}/{songTitle}");
      }
   }
}

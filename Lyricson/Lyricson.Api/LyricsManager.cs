using Lyricson.Api;
using Lyricson.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Lyricson.Api
{
   public class LyricsManager : ApiHelperBase<Lyric>
   {
      private static readonly string _key = "40bf25Rye2Ib0hP0VqHRmYvro6XLaFKDW5obDC2YlaoBglfr1AQApFg1";

      private static readonly string _baseUrl = "https://api.lyrics.ovh/v1/";
      public LyricsManager() : base(_baseUrl)
      {

      }
      public async Task<Lyric> GetLyrics(string artist, string songTitle)
      {
         return await GetAsync($"{_baseUrl}{artist}/{songTitle}");
      }
   }
}

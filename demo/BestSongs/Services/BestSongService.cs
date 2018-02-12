using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

using Newtonsoft.Json;
using System.Collections.Generic;

namespace BestSongs
{
    public class BestSongService
    {
        static HttpClient client = new HttpClient();
        static readonly JsonSerializer _serializer = new JsonSerializer();

        public static async Task<List<SongInfo>> GetBestSongsEver(string authToken)
        {
            var apiUrl = B2CConstants.BestSongsUrl;
            try
            {
                using (var request = new HttpRequestMessage(HttpMethod.Get, apiUrl))
                {
                    request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", authToken);

                    using (var response = await client.SendAsync(request).ConfigureAwait(false))
                    {
                        var stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);

                        using (var reader = new StreamReader(stream))
                        using (var json = new JsonTextReader(reader))
                        {
                            if (json == null)
                                return default(List<SongInfo>);

                            return await Task.Run(() => _serializer.Deserialize<List<SongInfo>>(json)).ConfigureAwait(false);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"*** ERROR in HTTPService GET!! {ex.Message}");
                return default(List<SongInfo>);
            }
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;
//namespace Google.Apis.YouTube.v3
namespace Projeto_ES
{
    public class IndexModel : PageModel
    {
        public List<YouTubeVideo> Videos { get; private set; } = new List<YouTubeVideo>();

        private readonly YouTubeService youTubeService;

        public IndexModel(YouTubeService youTubeService)
        {
            this.youTubeService = youTubeService;
        }

        public async Task OnGet()
        {
            var searchListRequest = youTubeService.Search.List("snippet");
            searchListRequest.Q = "elmah.io";
            searchListRequest.Type = "video";
            searchListRequest.Order = SearchResource.ListRequest.OrderEnum.Relevance;

            var searchListResponse = await searchListRequest.ExecuteAsync();
            Videos.AddRange(searchListResponse.Items.Select(video => new YouTubeVideo
            {
                Thumbnail = video.Snippet.Thumbnails.High.Url,
                Title = video.Snippet.Title,
                VideoId = video.Id.VideoId,
            }));
        }
    }

    public class YouTubeVideo
    {
        public string Thumbnail { get; internal set; }
        public string Title { get; internal set; }
        public string VideoId { get; internal set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;



namespace YoutubeAPI
{
    public class Videos
    {
        public string Thumbnail { get; internal set; }
        public string Title { get; internal set; }
        public string VideoId { get; internal set; }

        public List<Videos> Video { get; private set; } = new List<Videos>();

        public async Task OnGet()
        {
            var searchListRequest = youTubeService.Search.List("snippet");

            searchListRequest.Q = "elmah.io";
            searchListRequest.Type = "video";
            searchListRequest.Order = SearchResource.ListRequest.OrderEnum.Relevance;

            var searchListResponse = await searchListRequest.ExecuteAsync();
            Video.AddRange(searchListResponse.Items.Select(video => new Videos
            {
                Thumbnail = video.Snippet.Thumbnails.High.Url,
                Title = video.Snippet.Title,
                VideoId = video.Id.VideoId,
            }));
        }
    }

    
}
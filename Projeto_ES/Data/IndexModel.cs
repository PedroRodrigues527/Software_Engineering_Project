using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using ClassLibrary;

namespace Projeto_ES.Data
{
    public class IndexModel : PageModel
    {
        private readonly YouTubeService youTubeService;

        public IndexModel(YouTubeService youTubeService)
        {
            this.youTubeService = youTubeService;
        }

        public List<Video> OnGetVideo(string videoId)
        {
            var searchListRequest = youTubeService.Videos.List("snippet");
            searchListRequest.Id = videoId;
            searchListRequest.MaxResults = 1;

            var searchListResponse = searchListRequest.Execute();
            List<Video> Videos = new List<Video>();
            Videos.AddRange(searchListResponse.Items.Select(video => new Video
            {
                Thumbnail = video.Snippet.Thumbnails.Default__.Url,
                Title = video.Snippet.Title,
                ChannelName = video.Snippet.ChannelTitle,
                VideoId = video.Id,
            }));

            return Videos;
        }

        public List<Video> OnGetVideosPlaylist(string playlistId)
        {
            var searchListRequest = youTubeService.PlaylistItems.List("snippet");
            searchListRequest.PlaylistId = playlistId;
            searchListRequest.MaxResults = 100;

            var searchListResponse = searchListRequest.Execute();
            List<Video> Videos = new List<Video>();
            Videos.AddRange(searchListResponse.Items.Select(video => new Video
            {
                Thumbnail = video.Snippet.Thumbnails.Default__.Url,
                Title = video.Snippet.Title,
                ChannelName = video.Snippet.VideoOwnerChannelTitle,
                VideoId = video.Snippet.ResourceId.VideoId,
            }));

            return Videos;
        }
    }

}

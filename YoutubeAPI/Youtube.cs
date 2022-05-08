using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Google.Apis.Services;
using Google.Apis.YouTube.v3;

namespace YoutubeAPI
{
    class Youtube
    {
        //cria Youtube Service
        YouTubeService service = new YouTubeService(new BaseClientService.Initializer() { ApiKey = "AIzaSyC1iWH5NiEltxAAftVDqCFgqhfaWYUOgcI" });



    }
}

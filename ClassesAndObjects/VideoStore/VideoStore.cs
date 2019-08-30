using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore
{
    class VideoStore
    {
        private List<Video> _allVideos;

        public VideoStore()
        {
            _allVideos = new List<Video>();
        }
        public void AddVideo(string title)
        {
            _allVideos.Add(new Video(title));
        }

        public void CheckOut(string title)
        {
            foreach (var video in _allVideos)
            {
                if (video.Title != title)
                {
                    continue;
                }
                else
                {
                    if (video.IsAviable == true)
                    {
                        video.VideoCheckOut();
                    }
                }
            }

        }

        public void ReturnVideo(string title)
        {
            foreach (var video in _allVideos)
            {
                if (video.Title == title)
                {
                    if (video.IsAviable == false)
                    {
                        video.Return();
                    }
                    else
                    {
                        Console.WriteLine("Not aviable");
                    }
                }
                
            }
        }

        public void TakeUsersRating(string title, double rating)
        {
            foreach (var video in _allVideos)
            {
                if (video.Title == title)
                {
                    video.RateVideo(rating);
                }
            }
        }
        

        public void ListOfInventory()
        {
            foreach (var video in _allVideos)
            {
                Console.WriteLine(video.ToString());
            }
        }
    }
}

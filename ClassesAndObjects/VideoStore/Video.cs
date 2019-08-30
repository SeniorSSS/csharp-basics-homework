using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore
{
    class Video
    {
        private string _title;
        private bool _isAvialable;
        private List<double> _ratingList;
        

        public Video(string title)
        {
            _title = title;
            _isAvialable = true;
            _ratingList = new List<double>();
        }

        public string Title
        {
            get { return _title; }
        }

        public bool IsAviable
        {
            get { return _isAvialable; }
        }

        public void VideoCheckOut()
        {
            _isAvialable = false;
        }

        public override string ToString()
        {
            return $"{_title} {AverageRating()} {_isAvialable}";
        }

        public void Return()
        {
            _isAvialable = true;
        }

        public void RateVideo(double rating)
        {
            _ratingList.Add(rating);
        }

        public double AverageRating()
        {
            double result = 0;
            foreach (var rating in _ratingList)
            {
                result += rating;
            }

            return result / _ratingList.Count;
        }

    }
}

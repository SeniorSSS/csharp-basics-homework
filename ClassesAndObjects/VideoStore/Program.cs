using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore
{
    class Program
    {
        private const int _countOfMovies = 3;
        private static VideoStore _videoStore = new VideoStore();

        private static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose the operation you want to perform ");
                Console.WriteLine("Choose 0 for EXIT");
                Console.WriteLine("Choose 1 to fill video store");
                Console.WriteLine("Choose 2 to rent video (as user)");
                Console.WriteLine("Choose 3 to return video (as user)");
                Console.WriteLine("Choose 4 to list Inventory");

                int n = Convert.ToByte(Console.ReadLine());

                switch (n)
                {
                    case 0:
                        return;
                    case 1:
                        FillVideoStore();
                        break;
                    case 2:
                        RentVideo();
                        break;
                    case 3:
                        ReturnVideo();
                        break;
                    case 4:
                        ListInventory();
                        break;
                    default:
                        return;
                }
            }
        }

        private static void ListInventory()
        { 
            _videoStore.ListOfInventory();
        }
        private static void FillVideoStore()
        {
            for (var i = 0; i < _countOfMovies; i++)
            {
                Console.WriteLine("Enter movie name");
                string movieName = Console.ReadLine();

                Console.WriteLine("Enter rating");
                int rating = Convert.ToInt16(Console.ReadLine());

                //todo - add video
                _videoStore.AddVideo(movieName);
                _videoStore.TakeUsersRating(movieName,(double)rating);
            }
        }

        private static void RentVideo()
        {
            //todo - rent video
            Console.WriteLine("Enter movie name");
            string movieName = Console.ReadLine();
            _videoStore.CheckOut(movieName);

        }

        private static void ReturnVideo()
        {
            //todo - return video
            Console.WriteLine("Enter movie name");
            string movieName = Console.ReadLine();
            _videoStore.ReturnVideo(movieName);
        }
    }
}

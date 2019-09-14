using System;
using System.Linq;

namespace AddAp
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Campaign();
            c.AddAdvert(new Advert(1000));
            c.AddAdvert(new Hoarding(500, 7, 200));
            c.AddAdvert(new NewspaperAd(0, 30, 20));
            c.AddAdvert(new TVAd(50000, 1000, 30, true));
            c.AddAdvert(new Poster(800, 15, 20, 10, 8));

            //Console.WriteLine(c.ToString());
            foreach (var advert in c.campaign)
            {
                Console.WriteLine(advert.ToString());
            }
           

            Console.ReadKey();
        }
    }
}

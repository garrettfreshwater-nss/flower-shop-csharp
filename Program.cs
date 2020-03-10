using System;
using System.Collections.Generic;

namespace flower_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Rose darkBlueRose = new Rose();
            Lilly sweetLilly = new Lilly();
            Orchid ollieOrchid = new Orchid();
            Snapdragon fallenDragon = new Snapdragon();
            Sunflower sillySnapdragon = new Sunflower();

            FlowerShop GarrettsFlowerShop = new FlowerShop();
            List<IBirthDay> Arrangement = GarrettsFlowerShop.MakeBirthdayDayArrangement();

            Console.WriteLine(darkBlueRose);
        }
    }
}
using System.Collections.Generic;
namespace flower_shop
{
    public class FlowerShop
    {
        public List<Rose> Roses = new List<Rose>();
        public List<Lilly> Lillys = new List<Lilly>();
        public List<Orchid> Orchids = new List<Orchid>();
        public List<Snapdragon> Snapdragons = new List<Snapdragon>();
        public List<Sunflower> Sunflowers = new List<Sunflower>();

        // Favor interfaces for grouping items together.
        // 
        public List<IMothersDay> MakeMothersDayArrangement()
        {
            List<IMothersDay> Arrangement = new List<IMothersDay>();

            Arrangement.Add(new Lilly());
            Arrangement.Add(new Lilly());
            Arrangement.Add(new Rose());
            Arrangement.Add(new Rose());
            return Arrangement;
        }
        public List<IBirthDay> MakeBirthdayDayArrangement()
        {
            List<IBirthDay> Arrangement = new List<IBirthDay>();

            Arrangement.Add(new Sunflower());
            Arrangement.Add(new Snapdragon());
            Arrangement.Add(new Snapdragon());

            return Arrangement;
        }

        public List<IGetWell> MakeGetWellArrangement()
        {
            List<IGetWell> Arrangement = new List<IGetWell>();

            Arrangement.Add(new Orchid());
            Arrangement.Add(new Orchid());
            Arrangement.Add(new Orchid());

            return Arrangement;
        }

    }
}
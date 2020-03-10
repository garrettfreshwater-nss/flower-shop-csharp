using System.Collections.Generic;
namespace flower_shop
{
    public class Orchid : IMothersDay
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public double Cost { get; set; }
        public string WaterSchedule { get; set; }

        public double StemLength { get; set; }

        public bool Thorny { get; set; }

        public bool Fragrant { get; set; }

        public override string ToString()
        {
            return $"A Fanciful {Name} Orchid with that costs ${Cost}!";
        }

        // The collection of exercises that the student is currently working on
        // public List<Exercise> Exercises = new List<Exercise>();

        // public Rose(string color, string name, string type, int cost, string waterschedule, bool thorny, bool fragrant)
        // {
        //     Color = color;
        //     Name = name;
        //     Type = type;
        //     Cost = cost;
        //     WaterSchedule = waterschedule;
        //     Thorny = thorny;
        //     Fragrant = fragrant;
        // }

    }
}
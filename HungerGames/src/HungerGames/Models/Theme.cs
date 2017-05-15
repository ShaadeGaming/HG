using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HungerGames.Models
{
    public class Theme
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public List<Activity> Activities { get; set; }
    }
}

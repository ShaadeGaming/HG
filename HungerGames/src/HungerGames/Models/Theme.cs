using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HungerGames.Models
{
    public class Theme
    {
        public int ThemeID { get; set; }

        public string Name { get; set; }

        public string Day { get; set; }
        public List<Activity> Activities { get; set; }
    }
}

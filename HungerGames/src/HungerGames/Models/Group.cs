﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HungerGames.Models
{
    public class Group
    {
        public int ID { get; set; }

        public List<ApplicationUser> Users;
    }
}

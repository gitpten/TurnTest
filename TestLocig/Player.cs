﻿using CardLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLocig
{
    public class Player
    {
        public Player() : this("Noname") { }

        public Player(string name) : this(name, new()) { }

        public Player(string name, CardSet hand)
        {
            Name = name;
            Hand = hand;
        }

        public string Name { get; set; }
        public CardSet Hand { get; set; }
    }
}

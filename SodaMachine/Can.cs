﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Can
    {
        //Member Variables (Has A)
        protected double price;
        public string Name;

        public double Price
        { 
            get 
            {
                return price;
            }
        }
        //Constructor (Spawner)

        public Can(string name)
        {
            this.Name = name;
        }
        //Member Methods (Can Do)
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeppsTest.Models
{
    internal class Laminoir
    {
        public Laminoir(int id, string nom)
        {
            Id = id;
            Nom = nom;
        }

        public int Id { get; set; }
        public string Nom { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeppsTest.Models
{
    internal class BandeLaminé
    {
        public BandeLaminé(int id, int matiere)
        {
            Id = id;
            Matiere = matiere;
        }

        public int Id { get; set; }
        public int Matiere { get; set; }

          
    }
}

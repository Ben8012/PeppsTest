using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeppsTest.Models
{
    internal class CylindreTravail : Cylindre
    {
        public CylindreTravail(int id,double maximumTork, double diametre, double longueur, int laminoirId, int fabicantId) : base(id, diametre, longueur, laminoirId, fabicantId)
        {
            MaximumTork = maximumTork;
        }

        public double MaximumTork { get; set; }
      
    }
}

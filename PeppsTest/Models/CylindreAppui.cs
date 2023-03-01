using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeppsTest.Models
{
    internal class CylindreAppui : Cylindre
    {
        public CylindreAppui(int id,string profileType, double diametre, double longueur, int laminoirId, int fabicantId) : base(id,diametre, longueur, laminoirId, fabicantId)
        {
            ProfileType = profileType;
        }

        public string ProfileType { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeppsTest.Models
{
    internal abstract class Cylindre
    {
        protected Cylindre(int id, double diametre, double longueur, int laminoirId, int fabricantid)
        {
            Id = id;
            Diametre = diametre;
            Longueur = longueur;
            LaminoirId = laminoirId;
            FabricantId= fabricantid;
        }

        public int Id { get; set; }
        public double Diametre { get; set; }
        public double Longueur { get; set; }

        public int LaminoirId { get; set; }
        public int FabricantId { get; set; }

        public virtual void PrintData(List<Fabricant> FabricantList, List<Laminoir> LaminoirList)
        {
            Fabricant? fabricant = FabricantList.FirstOrDefault(f => f.Id == this.FabricantId);
            Laminoir? laminoir = LaminoirList.FirstOrDefault(f => f.Id == this.LaminoirId);
            Console.WriteLine("Ceci est le cylindre n°"+ this.Id+ " de type "+ this.GetType().Name );
            Console.WriteLine("Son diametre est de " + this.Diametre + "mm et sa longueur de " + this.Longueur + "mm");
            Console.WriteLine("Son fabricant est " + fabricant?.Nom + " et est moté sur le laminoir " + laminoir?.Nom);
            Console.WriteLine();

        } 
    }
}

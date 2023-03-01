// See https://aka.ms/new-console-template for more information
using PeppsTest.Models;

Random rand = new Random();

List<Fabricant>FabricantList= new List<Fabricant>();
List<Laminoir>LaminoirList= new List<Laminoir>();

for (int i = 0; i < 5; i++)
{
    FabricantList.Add(new Fabricant(i + 1,"fabricant"+i+1));
    LaminoirList.Add(new Laminoir(i + 1,"laminoir"+i+1));

}

List<Cylindre> CylindreList= new List<Cylindre>();

for (int i = 0; i < 10; i+=2)
{

    int LaminoirId = (i/2)+1;
    int FabricantId = rand.Next(1,5);
    int Diametre = rand.Next(100, 1000);
    int Longueur = rand.Next(100, 1000);
    CylindreList.Add( new CylindreTravail( (i+1), rand.Next(1, 20), Diametre, Longueur, LaminoirId, FabricantId ) );
    CylindreList.Add( new CylindreAppui((i+2),rand.Next(1, 3).ToString(), Diametre, Longueur, LaminoirId, FabricantId) );

}

Console.WriteLine("Liste des cylindres");
Console.WriteLine();
foreach (Cylindre cylindre in CylindreList)
{
    cylindre.PrintData(FabricantList, LaminoirList);
}
Console.WriteLine();
Console.WriteLine("--------------------");
Console.WriteLine();
Console.WriteLine("Ceux dont le diametre est inferieur à 500mm");
Console.WriteLine();
foreach (Cylindre cylindre in CylindreList)
{
    if(cylindre.Diametre < 500) cylindre.PrintData(FabricantList, LaminoirList);
}

Console.Read();


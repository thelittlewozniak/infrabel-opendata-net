using OpenDataInfrabel.ClientsProductsTheme;
using OpenDataInfrabel.HumanRessourcesTheme;
using OpenDataInfrabel.InfrastructureTheme;
using OpenDataInfrabel.SecurityTheme;
using System;

namespace TestProgram
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            IInfrastructure humanRessources = new Infrastructure();
            var result8 = await humanRessources.GetLevelCrossingDeletions();
            Console.WriteLine(result8);
        }
    }
}

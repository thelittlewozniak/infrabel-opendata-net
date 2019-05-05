using OpenDataInfrabel.ClientsProductsTheme;
using OpenDataInfrabel.HumanRessourcesTheme;
using OpenDataInfrabel.SecurityTheme;
using System;

namespace TestProgram
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            IHumanRessources humanRessources = new HumanRessources();
            var result8 = await humanRessources.GetStaffTurnover();
            Console.WriteLine(result8);
        }
    }
}

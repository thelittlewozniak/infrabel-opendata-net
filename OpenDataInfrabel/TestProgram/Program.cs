using OpenDataInfrabel.InfrastructureTheme;
using OpenDataInfrabel.SecurityTheme;
using OpenDataInfrabel.TrafficManagementTheme;
using System;

namespace TestProgram
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            IInfrastructure humanRessources = new Infrastructure();
            var result8 = await humanRessources.GetKilometersMarkersNetwork();
            Console.WriteLine(result8);
        }
    }
}

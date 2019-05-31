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
            ISecurity humanRessources = new Security();
            var result8 = await humanRessources.GetAccidentsISI();
            Console.WriteLine(result8);
        }
    }
}

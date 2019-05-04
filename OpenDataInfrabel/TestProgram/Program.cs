using OpenDataInfrabel.Security;
using System;

namespace TestProgram
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            Security security = new Security();
            var result = await security.GetAccidentsCSI();
            var result2 = await security.GetAccidentsISI();
            var result3 = await security.GetViolationSignalRailwayPrimary();
            var result4 = await security.GetViolationSignalRailwaySecondary();
            Console.WriteLine(result + "" +result2 + "" + result3 + "" + result4);
        }
    }
}

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
            var result5 = await security.GetViolationSignalRailwayPrimaryPerTrain();
            var result6 = await security.GetViolationRailway();
            var result7 = await security.GetPrecursorsSecurity();
            Console.WriteLine(result + "" +result2 + "" + result3 + "" + result4 + "" + result5 + "" + result6 + "" + result7);
        }
    }
}

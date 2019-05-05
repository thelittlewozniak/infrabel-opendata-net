using OpenDataInfrabel.ClientsProducts;
using OpenDataInfrabel.Security;
using System;

namespace TestProgram
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            ClientsProducts clientsProducts = new ClientsProducts();
            var result8 = await clientsProducts.GetEvolutionNetTonnageYear();
            Console.WriteLine(result8);
        }
    }
}

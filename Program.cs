using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tridion.ContentManager.CoreService.Client;

namespace ExampleCoreServiceProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating the core service.
            // Using "wsHttp_2013" binding to create the client, Other bindings (like "netTcp_2013") could be used depending on the need.
            SessionAwareCoreServiceClient client = new SessionAwareCoreServiceClient("wsHttp_2013");

            // Read a Folder, for example.
            var item = client.Read("tcm:9-7-2", new ReadOptions());
            Console.WriteLine("Item Title: " + item.Title);
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}

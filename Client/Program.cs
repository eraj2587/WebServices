using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {

            //WebServiceClient client = new WebServiceClient();
            //client.CallService();

            WCFClient client = new WCFClient();

            while (true)
            {
                client.CallService();
            }
        }
    }
}

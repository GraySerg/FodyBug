using Shareddll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FodyDelete
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientData clientData = new ClientData();
            MyData data = new MyData();
            Console.WriteLine("Client Waiting...");
            Console.ReadLine();
        }
    }
}

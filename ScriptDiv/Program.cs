using ScriptDiv.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptDiv
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractService n = new ChangeDivisionByUser();
            n.executeTask();
            Console.WriteLine("-----------------------Fin du programme merci----------------------------------------");
            Console.ReadKey();
        }
    }
}

using ScriptDiv.Services;
using System;

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

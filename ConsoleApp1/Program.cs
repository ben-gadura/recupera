using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pessoa;
            float altura;
            Console.WriteLine("escreva o numero do codigo do empregado");
            pessoa = int.Parse(Console.ReadLine());
            Console.WriteLine("agora, digite a altura da pessoa");
            altura = float.Parse(Console.ReadLine());
            Console.WriteLine("a altura do empregado " +pessoa+ "é " +altura+"m");
            Console.ReadKey();
        }
    }
}

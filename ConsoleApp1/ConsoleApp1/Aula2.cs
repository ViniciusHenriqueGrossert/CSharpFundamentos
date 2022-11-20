using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Aula2
    {
        public static void Executar()
        {
            Pessoa pessoa1 = new Pessoa();

            Console.WriteLine("*********  Cadastro de Usuarios  *********");
            
            Console.Write("Digite seu nome: ");
            pessoa1.Nome = Console.ReadLine();

            Console.Write("Digite seu sobrenome: ");
            pessoa1.sobrenome = Console.ReadLine();
 
            Console.Write("Digite seu cpf: ");
            pessoa1.cpf = Console.ReadLine();

            //Console.WriteLine("Nome completo: " + nome + " " + sobrenome + " cpf: " + cpf);
            Console.WriteLine($"Nome completo: {pessoa1.Nome} {pessoa1.sobrenome} cpf: {pessoa1.cpf}");

            Console.ReadKey();
        }
    }
}
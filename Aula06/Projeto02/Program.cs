using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02.Entities;
using Projeto02.Controls;


namespace Projeto02
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente(1, "Pedro", "Pedro@gmail.com");
            ClienteControle controle = new ClienteControle();

            try
            {
                controle.ExportarParaTxt(cliente);
                controle.ExportarParaCsv(cliente);
                controle.ExportarParaXml(cliente);

                Console.WriteLine("\nGravado com sucesso!");
            }
            catch(Exception e)
            {
                Console.WriteLine("Erro" + e.Message);
            }

            Console.ReadKey();
        }
    }
}

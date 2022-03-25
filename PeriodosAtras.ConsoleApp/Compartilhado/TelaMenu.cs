using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodosAtras.ConsoleApp.Compartilhado
{
    public class TelaMenu
    {

        public string opcoesMenu;

        public void Cabecalho()
        {
            Console.WriteLine("====================== Periodos Atrás ======================");
            Console.WriteLine();
            Console.WriteLine("  Utilize esse programa para realizar a análise de tempo.");
            Console.WriteLine();
            Console.WriteLine("============================================================");
        }

        public string ChamarMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Selecione uma das opções abaixo.");
            Console.WriteLine();
            Console.WriteLine("[1] - Digitar a data desejada.");
            Console.WriteLine("[2] - Sair do programa.");
            Console.WriteLine();

            Console.Write("Opção selecionada: ");
            opcoesMenu = Console.ReadLine();

            return opcoesMenu;
        }
    }
}

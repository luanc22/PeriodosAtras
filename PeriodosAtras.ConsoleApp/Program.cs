using System;
using PeriodosAtras.ConsoleApp.ModuloData;
using PeriodosAtras.ConsoleApp.Compartilhado;

namespace PeriodosAtras.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TelaData telaData = new TelaData();
            TelaMenu menu = new TelaMenu();
            Notificador notificador = new Notificador();

            bool fecharProg = false;

            while(fecharProg == false)
            {
                Console.Clear();
                menu.Cabecalho();
                string opcoesMenu = menu.ChamarMenu();

                if (opcoesMenu == "1")
                {
                    Console.Clear();
                    menu.Cabecalho();

                    telaData.ObterData();
                    telaData.MostrarTempoPassado();
                    Console.WriteLine();
                    notificador.ApresentarMensagem("Tempo calculado com sucesso!", TipoDeAvisoEnum.Sucesso);
                    Console.ReadLine();
                }
                else if(opcoesMenu == "2")
                {
                    fecharProg = true;
                }
                else
                {
                    notificador.ApresentarMensagem("Opção inválida, tente novamente!", TipoDeAvisoEnum.Erro);
                    continue;
                }
            }
        }
    }
}

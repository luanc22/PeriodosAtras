using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodosAtras.ConsoleApp.Compartilhado
{
    public class Notificador
    {
        public TipoDeAvisoEnum tipoDeAviso;

        public void ApresentarMensagem(string mensagemAviso, TipoDeAvisoEnum tipoDeAviso)
        {
            switch (tipoDeAviso)
            {
                case TipoDeAvisoEnum.Sucesso:
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(mensagemAviso);
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.ReadLine();
                    break;
                case TipoDeAvisoEnum.Alerta:
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine(mensagemAviso);
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.ReadLine();
                    break;
                case TipoDeAvisoEnum.Erro:
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(mensagemAviso);
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.ReadLine();
                    break;
            }
        }
    }
}

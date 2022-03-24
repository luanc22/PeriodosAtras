using System;
using PeriodosAtras.ConsoleApp.ModuloData;

namespace PeriodosAtras.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Datas dataUtilizada = new Datas();

            Console.Write("Informe a data: ");
            string dataInformadaString = Console.ReadLine();
            Console.WriteLine();

            dataUtilizada.dataInformada = DateTime.Parse(dataInformadaString);

            TimeSpan tempoPassado = dataUtilizada.dataAtual.Subtract(dataUtilizada.dataInformada);

            int diasPassados = tempoPassado.Days;
            int horasPassadas = tempoPassado.Hours;
            int minutosPassadas = tempoPassado.Minutes;
            int segundosPassaos = tempoPassado.Seconds;

            int contadorDia = 0;
            int contadorSemana = 0;
            int contadorMes = 0;
            int contadorAno = 0;

            if (diasPassados == 0)
            {
                Console.Write(tempoPassado.Hours + " horas, ");
                Console.Write(tempoPassado.Minutes + " minutos e ");
                Console.Write(tempoPassado.Seconds + " segundos");
            }

            for (int i = 1; i <= diasPassados; i++)
            {
                if (i % 365 == 0)
                {
                    contadorAno++;
                    diasPassados = diasPassados - 365;
                }
            }

            for (int i = 1; i <= diasPassados; i++)
            {
                if (i % 30 == 0)
                {
                    contadorMes++;
                    diasPassados = diasPassados - 30;
                }
            }

            for (int i = 1; i <= diasPassados; i++)
            {
                if (i % 7 == 0)
                {
                    contadorSemana++;
                    diasPassados = diasPassados - 7;
                }
            }

            contadorDia = diasPassados;

            if (contadorAno > 0)
            {
                string anoExtenso = NumeroExtenso(contadorAno, TipoDeData.Ano);

                if (contadorAno == 1)
                {
                    Console.Write(anoExtenso + " ano");
                }
                else
                {
                    Console.Write(anoExtenso + " anos");
                }
            }

            if (contadorMes > 0)
            {

                string mesExtenso = NumeroExtenso(contadorMes, TipoDeData.Mes);

                if (contadorAno > 0 )
                {
                    Console.Write(", ");
                }
                else if(contadorAno > 0 && contadorSemana == 0 && contadorDia == 0)
                {
                    Console.Write(" e ");
                }

                if (contadorMes == 1)
                {
                    Console.Write(mesExtenso + " mes");
                }
                else
                {
                    Console.Write(mesExtenso + " meses");
                }
            }

            if (contadorSemana > 0)
            {
                if (contadorAno > 0 || contadorMes > 0)
                {
                    Console.Write(", ");
                }
                else if (contadorAno > 0 && contadorMes > 0 && contadorDia == 0)
                {
                    Console.Write(" e ");
                }

                string semanaExtenso = NumeroExtenso(contadorSemana, TipoDeData.Semana);

                if (contadorMes == 1)
                {
                    Console.Write(semanaExtenso + " semana");
                }
                else
                {
                    Console.Write(semanaExtenso + " semanas");
                }
            }

            if (contadorDia > 0)
            {
                if (contadorAno > 0 || contadorMes > 0 || contadorSemana > 0)
                {
                    Console.Write(" e ");
                }

                string diaExtenso = NumeroExtenso(contadorDia, TipoDeData.Dia);

                if (contadorDia == 1)
                {
                    Console.Write(diaExtenso + " dia");
                }
                else
                {
                    Console.Write(diaExtenso + " dias");
                }
            }


            Console.Write(" atrás.");


            Console.ReadLine();
        }

        static string NumeroExtenso(int numeroPassado, TipoDeData tipoDeData)
        {
            string numeroExtenso = "";

            switch (numeroPassado)
            {
                case 1:
                    if (tipoDeData == TipoDeData.Semana)
                    {
                        numeroExtenso = "uma";
                    }
                    else
                    {
                        numeroExtenso = "um";
                    }
                    break;
                case 2:
                    if (tipoDeData == TipoDeData.Semana)
                    {
                        numeroExtenso = "duas";
                    }
                    else
                    {
                        numeroExtenso = "dois";
                    }
                    break;
                case 3:
                    numeroExtenso = "tres";
                    break;
                case 4:
                    numeroExtenso = "quatro";
                    break;
                case 5:
                    numeroExtenso = "cinco";
                    break;
                case 6:
                    numeroExtenso = "seis";
                    break;
                case 7:
                    numeroExtenso = "sete";
                    break;
                case 8:
                    numeroExtenso = "oito";
                    break;
                case 9:
                    numeroExtenso = "nove";
                    break;
                case 10:
                    numeroExtenso = "dez";
                    break;
            }
            
            return numeroExtenso;
        }
    }
}

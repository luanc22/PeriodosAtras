using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeriodosAtras.ConsoleApp.Compartilhado;

namespace PeriodosAtras.ConsoleApp.ModuloData
{
    public class TelaData
    {
        Datas dataUtilizada = new Datas();

        static TimeSpan tempoPassado;

        public int diasPassados = 0;
        public int horasPassadas = 0;
        public int minutosPassadas = 0;
        public int segundosPassaos = 0;

        public int contadorDia = 0;
        public int contadorSemana = 0;
        public int contadorMes = 0;
        public int contadorAno = 0;

        public void ObterData()
        {
            Console.WriteLine();
            Console.Write("Informe a data: ");
            string dataInformadaString = Console.ReadLine();
            Console.WriteLine();

            dataUtilizada.dataInformada = DateTime.Parse(dataInformadaString);
            tempoPassado = dataUtilizada.dataAtual.Subtract(dataUtilizada.dataInformada);

            diasPassados = tempoPassado.Days;
            horasPassadas = tempoPassado.Hours;
            minutosPassadas = tempoPassado.Minutes;
            segundosPassaos = tempoPassado.Seconds;
      
        }

        public void MostrarTempoPassado()
        {
            if (diasPassados == 0)
            {
                Console.Write(tempoPassado.Hours + " horas, ");
                Console.Write(tempoPassado.Minutes + " minutos e ");
                Console.Write(tempoPassado.Seconds + " segundos");
                return;
            }

            if (diasPassados > 365)
            {
                contadorAno = diasPassados / 365;
                diasPassados = diasPassados % 365;

                string anoExtenso = NumeroExtenso(contadorAno, TipoDeDataEnum.Ano);

                if (contadorAno == 1)
                {
                    Console.Write(anoExtenso + " ANO");
                }
                else
                {
                    Console.Write(anoExtenso + " ANOS");
                }
            }

            if (diasPassados > 30)
            {
                contadorMes = diasPassados / 30;
                diasPassados = diasPassados % 30;

                string mesExtenso = NumeroExtenso(contadorMes, TipoDeDataEnum.Mes);

                if (contadorAno > 0)
                {
                    Console.Write(", ");
                }
                else if (contadorAno > 0 && contadorSemana == 0 && contadorDia == 0)
                {
                    Console.Write(" E ");
                }

                if (contadorMes == 1)
                {
                    Console.Write(mesExtenso + " MÊS");
                }
                else
                {
                    Console.Write(mesExtenso + " MESES");
                }

            }

            if (diasPassados > 7)
            {
                contadorSemana = diasPassados / 7;
                diasPassados = diasPassados % 7;

                if (contadorAno > 0 || contadorMes > 0)
                {
                    Console.Write(", ");
                }
                else if (contadorAno > 0 && contadorMes > 0 && contadorDia == 0)
                {
                    Console.Write(" E ");
                }

                string semanaExtenso = NumeroExtenso(contadorSemana, TipoDeDataEnum.Semana);

                if (contadorMes == 1)
                {
                    Console.Write(semanaExtenso + " SEMANA");
                }
                else
                {
                    Console.Write(semanaExtenso + " SEMANAS");
                }
            }

            if (diasPassados < 7)
            {
                contadorDia = diasPassados;

                if (contadorAno > 0 || contadorMes > 0 || contadorSemana > 0)
                {
                    Console.Write(" E ");
                }

                string diaExtenso = NumeroExtenso(contadorDia, TipoDeDataEnum.Dia);

                if (contadorDia == 1)
                {
                    Console.Write(diaExtenso + " DIA");
                }
                else
                {
                    Console.Write(diaExtenso + " DIAS");
                }
            }

            Console.Write(" ATRÁS.");

           
        }

        static string NumeroExtenso(int numeroPassado, TipoDeDataEnum tipoDeData)
        {
            string numeroExtenso = "";

            switch (numeroPassado)
            {
                case 1:
                    if (tipoDeData == TipoDeDataEnum.Semana)
                    {
                        numeroExtenso = "uma";
                    }
                    else
                    {
                        numeroExtenso = "um";
                    }
                    break;
                case 2:
                    if (tipoDeData == TipoDeDataEnum.Semana)
                    {
                        numeroExtenso = "duas";
                    }
                    else
                    {
                        numeroExtenso = "dois";
                    }
                    break;
                case 3:
                    numeroExtenso = "três";
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
                case 11:
                    numeroExtenso = "onze";
                    break;
            }

            numeroExtenso = numeroExtenso.ToUpper();
            return numeroExtenso;
        }
    }


}

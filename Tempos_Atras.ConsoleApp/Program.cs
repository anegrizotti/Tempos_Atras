using System;

namespace Tempos_Atras.ConsoleApp
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            int contAnos = 0, contMeses = 0, contSemanas = 0, contDias = 0;
            int anos = 365, meses = 30, semenas = 7, dias = 0;

            Data data = new Data();

            Console.Write("Infome a data: ");
            data.dataInformada = DateTime.Parse(Console.ReadLine());

            TimeSpan timeSpanNumeroDias = DateTime.Now.Subtract(data.dataInformada);
            int intNumeroDias = timeSpanNumeroDias.Days;

            if (intNumeroDias < 1)
            {
                Console.WriteLine("Segundos: " + timeSpanNumeroDias.Seconds);
                Console.WriteLine("Minutos: " + timeSpanNumeroDias.Minutes);
                Console.WriteLine("Horas: " + timeSpanNumeroDias.Hours);
            }
            else
            {

                for (int i = 1; i <= intNumeroDias; i++)
                {
                    if (i == anos)
                    {
                        contAnos++;
                        anos = anos + 356;
                    }
                }

                int restoAnos = intNumeroDias - (contAnos * 365);

                for (int i = 1; i <= restoAnos; i++)
                {
                    if (i == meses)
                    {
                        contMeses++;
                        meses = meses + 30;
                    }
                }

                int restoMeses = restoAnos - (contMeses * 30);

                for (int i = 1; i <= restoMeses; i++)
                {
                    if (i == semenas)
                    {
                        contSemanas++;
                        semenas = semenas + 7;
                    }
                }

                int restoSemanas = restoMeses - (contSemanas * 7);

                for (int i = 1; i <= restoSemanas; i++)
                {
                    contDias++;
                }

                Console.Write("Isso foi há ");

                if (contAnos > 0)
                {
                    Console.Write(VerificaNumero(contAnos) + " ano(s)");
                    Console.Write(" , ");
                }

                if (contMeses > 0)
                {
                    Console.Write(VerificaNumero(contMeses) + " mes(es)");
                    Console.Write(" , ");
                }

                if (contSemanas > 0)
                {
                    Console.Write(VerificaNumero(contSemanas) + " semana(s)");
                    Console.Write(" , ");
                }

                if (contDias > 0)
                {
                    Console.Write("e " + VerificaNumero(contDias) + " dia(s) ");
                }

                Console.Write("atrás.");
            }
        }
        public static string VerificaNumero(int cont)
        {
            string numero = null;

            switch (cont) 
            {
                case 1:
                    numero = "um";
                break;

                case 2:
                    numero = "dois";
                    break;

                case 3:
                    numero = "três";
                    break;

                case 4:
                    numero = "quatro";
                    break;

                case 5:
                    numero = "cinco";
                    break;

                case 6:
                    numero = "seis";
                    break;

                case 7:
                    numero = "sete";
                    break;

                case 8:
                    numero = "oito";
                    break;

                case 9:
                    numero = "nove";
                    break;

                case 10:
                    numero = "dez";
                    break;
            }

            return numero;

        }
    }
}

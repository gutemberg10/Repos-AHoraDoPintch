using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace AHoraDoPitch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Alarme alarme = new Alarme();
            String resposta = "S";

            while (resposta != "N")
            {
                Console.Clear();
                Console.WriteLine("A hora do Pitch");
                Console.Write("Informe a duração do Pitch: ");
                int tempo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe o efeito sonoro(1 a 500): ");
                int efeitoSonoro = Convert.ToInt32(Console.ReadLine());
                alarme = new Alarme(tempo, efeitoSonoro);

                //alarme.Tempo = tempo;
                alarme.Iniciar();
                Console.WriteLine("Que pena!!! O seu tempo acabou!!!");
                Console.Write("Executar o programa novamente: S/N ");
                resposta = Console.ReadLine().ToUpper();
            }

        }

    }

}








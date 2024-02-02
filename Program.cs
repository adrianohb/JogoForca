using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoForca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // JOGO DA FORCA

            string[] palavras = {
            "ALFABETO",
            "TESTE",
            "JOGO",
            "ELEFANTE",
            };

            // Parte do programa que vai sortear o número aleatório e transformar em palavra
            int numAleatorio;
            numAleatorio = new Random().Next(1, 4);

            string palavraSorteada = palavras[numAleatorio];
            int comprimentoPalavra = palavraSorteada.Length;
            int chance = comprimentoPalavra + 0;

            string underline = new string('_', comprimentoPalavra);

            string[] letras = new string[comprimentoPalavra];

        
            Console.WriteLine("Bem vindo ao jogo da forca!");
            Console.WriteLine(" ");

            while (chance > 0)
            {
                Console.WriteLine($"Você tem {chance} chances para acertar a palavra. ");
                Console.WriteLine(" ");
                Console.WriteLine(underline);

                Console.Write("Digite a letra escolhida: ");
                

                Console.ReadKey();
            }
            
           

            

        }
    }
}

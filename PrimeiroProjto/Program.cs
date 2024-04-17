using System;
using static System.Net.Mime.MediaTypeNames;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int idade = 23;
            Console.WriteLine("a minha idade é "+idade);*/

            /*int numero1 = 9;
            int numero2 = 3;

            int soma = numero1 + numero2;
            int subtracao = numero1 - numero2;
            int multiplicacao = numero1 * numero2;
            int divisao = numero1 / numero2;

            Console.WriteLine(soma);
            Console.WriteLine(subtracao);
            Console.WriteLine(multiplicacao);
            Console.WriteLine(divisao);*/

            int salario = 35;
            int expediente = 8;
            int expDiario = salario * expediente;
            Console.WriteLine("1- Joaquim recebe R$"+ expDiario+",00 por dia");

            int bombons = 27;
            int caixas = 16;
            int bombomTotal = bombons * caixas;
            Console.WriteLine("2- Pamela tem " + bombomTotal + " bombons");

            int valor1 = 7;
            int valor2 = 6;
            int soma = valor1 + valor2;
            Console.WriteLine("3- " + valor1 + "+" + valor2 + "=" + soma);

            int garrafas = 300;
            int porCaixa = 20;
            int gCaixas = garrafas / porCaixa;
            Console.WriteLine("4- " + gCaixas + " caixas");

            int instal = 300;
            int limpar = 150;
            double manut = 499.99;
            double total = instal + limpar + manut;
            double desc = total - 50;
            Console.WriteLine("5- Ele deverá pagar R$" + desc);

        }
    }
}

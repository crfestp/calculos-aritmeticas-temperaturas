﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aplicação Cálculos");

            Console.WriteLine($"4 + 2 = {Aritmetica.Soma(4, 2)}");

            Console.WriteLine($"4 - 2 = {Aritmetica.Subtrair(4, 2)}");

            double t1 = Conversoes.ConverterTemperatura(Conversoes.ConversaoTemperatura.CelsiusFahrenheit, 36);

            double t2 = Conversoes.ConverterTemperatura(Conversoes.ConversaoTemperatura.FahrenheitCelsius, 100);

            //Apresentação dos resultados

            Console.WriteLine($"36º Celsius = {t1}º Fahrenheit");

            Console.WriteLine($"100º Fahrenheit = {t1}º Celsius");

            Console.WriteLine("Obrigado por utilizar este programa. Até à próxima!");

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    /// <summary>
    /// Implementa operações aritméticas
    /// </summary>
    internal static class Aritmetica
    {
        

        /// <summary>
        /// Operação Soma
        /// </summary>
        /// <returns>Retorna a soma de dois números</returns>
        public static int Soma(int x, int y)
        {
            return x + y;
        }
        /// <summary>
        /// Operação Subtrair
        /// </summary>
        /// <returns>Retorna o resultado da subtração de dois números</returns>
        public static int Subtrair(int x, int y)
        {
            return x - y;
        }

        /// <summary>
        /// Operação Multiplicar
        /// </summary>
        /// <returns>Retorna o resultado da multiplicação de dois números</returns>
        public static int Multiplicar(int x, int y)
        {
            return x * y;
        }


    }
}

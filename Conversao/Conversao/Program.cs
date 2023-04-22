using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Conversão implícita
            byte valor1 = 100;// 8 bits, intervalo de 0 a 255
            ushort valor2 = valor1;// 16 bits, de 0 a 65.535

            float valor3 = 1250.45f;
            double valor4 = valor3;

            valor3 = valor1; // Float recebe o type byte porque faz parte do número real.
            valor2 = valor1;

            int numero = 'c';// traz o cod type char 

            Console.WriteLine();
            Console.ReadKey();
            #endregion

            #region Conversão explícita
            //Ao forçar pode ter o risco de perder dados, então usar com muito cuidado
            ushort valor1 = 500;
            byte valor2 = (byte)valor1;

            float valor3 = 2500.786f;
            int valor4 = (int)valor3;// () força a variável x receber o valor y memso sendo de type diferente

            char letra = (char)97;// cod hexadecimal quando start traz o valor a minúsculo 

            Console.WriteLine(letra);
            Console.ReadKey();
            #endregion

            #region Método Parse


            // Todos os números têm esse método Parse. E temos que passar como parametro o valor da string e represente um valor númerico
            // e essa string pode está no seu formato de variável ou na sua forma literal 

            string txtNumero = "1985";

            int numero = int.Parse(txtNumero);// Ao fazer a conversão o valor atribuido te que está de acordo com o type do valor a se receber.


            byte num2 = byte.Parse("160");


            double num3 = double.Parse("1860,76");// Na forma literal colocamos ponto, e  na representação colocamos, vígula.


            float num4 = float.Parse("457,48");// não precisa colocar f no final e ponto para separar os decimais.



            Console.WriteLine();
            Console.ReadKey();


            #endregion


            #region Método Convert
            //// Método Convert converte qualquer valor passado por parâmetro para uma string.

            string texto = Convert.ToString(false);

            double num1 = Convert.ToDouble(false);

            int num2 = Convert.ToInt32('C');


            Console.WriteLine(num1);
            Console.ReadKey();


            #endregion
        }
    }
}

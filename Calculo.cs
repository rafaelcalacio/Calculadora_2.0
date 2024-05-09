using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Calculo
    {
        int operacao;
        double num1, num2;
        double resultado;
        public void IniciarCalculo()
        {
            Console.WriteLine("Calculadora 1.0");
            Console.WriteLine("Escolha a função desejada: ");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("0 - Sair \n");
            operacao = int.Parse(Console.ReadLine());

            if (operacao != 1 && operacao != 2 && operacao != 3 && operacao != 4 && operacao != 0)
            {
                Console.WriteLine("Digite a opção correta");
                operacao = int.Parse(Console.ReadLine());
            }
            else if (operacao == 0)
            {
                Console.WriteLine("\n Você selecionou sair...");                
            }
            else
            {
                Console.WriteLine("Digite o primeiro número...");
                num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número...");
                num2 = double.Parse(Console.ReadLine());
            }

            
        }

        public void Calcular()
        {
            while(operacao != 0) 
            {
                switch (operacao)
                {
                    case 1:
                        resultado = num1 + num2;
                        Console.WriteLine($"Soma de {num1} + {num2}");
                        Console.WriteLine($"Resultado = {resultado}");
                        break;
                    case 2:
                        resultado = num1 - num2;
                        Console.WriteLine($"Subtração de {num1} - {num2}");
                        Console.WriteLine($"Resultado = {resultado}");
                        break;
                    case 3:
                        Console.WriteLine($"Multiplicação de {num1} x {num2}");
                        resultado = num1 * num2;
                        Console.WriteLine($"Resultado = {resultado}");
                        break;
                    case 4:
                        if (num2 == 0)
                        {
                            Console.WriteLine("Não é possível dividir por zero!!!");
                        }
                        else
                        {
                            resultado = num1 / num2;
                            Console.WriteLine($"Divisão de {num1} / {num2}");
                            Console.WriteLine($"Resultado = {resultado}");
                        }
                        break;
                    
                }
                Console.WriteLine("");
                IniciarCalculo();
                Console.WriteLine();

            }

            Console.ReadKey();

        }
    }
}

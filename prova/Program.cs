using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace prova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int prova;
            Console.WriteLine("                             Aluno:Ronaldo da Silva mendonça Junior");
            Console.WriteLine("                                     Serie:2 Ano Informatica");
            Console.WriteLine("                                      Prova de Programaçao");

            Console.WriteLine("                             Digite o numero do exercicio que deseja");
            Console.WriteLine("                                           Exercicio 1");
            Console.WriteLine("                                           Exercicio 2");
            Console.WriteLine("                                           Exercicio 3");
            Console.WriteLine("                                           Exercicio 4");
            Console.WriteLine("                                           Exercicio 5");
            Console.WriteLine("                                           Exercicio 6");
            Console.WriteLine("                                           Exercicio 7");
            prova = int.Parse(Console.ReadLine());

            switch (prova)
            {
                case 1:
                    {

                        int num;
                        Console.WriteLine("digite o numero");
                        num = int.Parse(Console.ReadLine());
                        if (num < 0)
                            num = -num;
                        Console.WriteLine("O valor absoluto e " + num);
                    }
                    break;


                case 2:
                    {
                        int num;
                        Console.WriteLine("Digite o numero");
                        num = int.Parse(Console.ReadLine());
                        if (num % 4 == 0 && num % 7 == 0)
                        { Console.WriteLine("este numero é divisivel por 4 e 7 "); }
                        else if (num % 3 == 0 && num % 5 == 0)
                        { Console.WriteLine("Este numero e divisivel por 3 e 5"); }
                        else if (num % 3 == 0)
                        { Console.WriteLine("Este numero e divisivel por 3"); }
                        else if (num % 5 == 0)
                        { Console.WriteLine("este numero e divisivel por 5"); }
                        else if (num % 7 == 0)
                        { Console.WriteLine("este numero e divisivel por 5"); }
                        else if (num % 4 == 0)
                        { Console.WriteLine("este numero e divisivel por 5"); }
                    }
                    break;

                case 3:
                    {
                        int num1, num2, num3;
                        Console.WriteLine("Digite o primeiro numero");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo numero");
                        num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o terceiro numero");
                        num3 = int.Parse(Console.ReadLine());
                        if (num1 >= num2 && num1 >= num3)
                        { Console.WriteLine("O maior numero e" + num1); }
                        if (num2 >= num1 && num2 >= num3)
                        { Console.WriteLine("O maior numero e" + num2); }
                        if (num3 >= num1 && num3 >= num2)
                        { Console.WriteLine("O maior numero e" + num3); }
                    }
                    break;

                case 4:
                    {
                        int dias;
                        Console.WriteLine("Digite o numero do dia da semana");
                        Console.WriteLine("1-Domingo");
                        Console.WriteLine("2-Segunda");
                        Console.WriteLine("3-Terça");
                        Console.WriteLine("4-Quarta");
                        Console.WriteLine("5-Quinta");
                        Console.WriteLine("6-Sexta");
                        Console.WriteLine("7-sabado");
                        dias = int.Parse(Console.ReadLine());
                        switch (dias)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Domingo");
                                    Console.WriteLine("Trabalho");
                                    Console.WriteLine("jogar");
                                }
                                break;
                            case 2:
                                {
                                    Console.WriteLine("Historia");
                                    Console.WriteLine("Historia");
                                    Console.WriteLine("Portugues");
                                    Console.WriteLine("Portugues");
                                    Console.WriteLine("Matematica");
                                    Console.WriteLine("Matematica");
                                }
                                break;
                            case 3:
                                {
                                    Console.WriteLine("Quimica");
                                    Console.WriteLine("Quimica");
                                    Console.WriteLine("Historia");
                                    Console.WriteLine("Historia");
                                    Console.WriteLine("IMI");
                                    Console.WriteLine("IMI");
                                }
                                break;
                            case 4:
                                {
                                    Console.WriteLine("Biologia");
                                    Console.WriteLine("Biologia");
                                    Console.WriteLine("Portugues");
                                    Console.WriteLine("Programaçao");
                                    Console.WriteLine("programaçao");
                                    Console.WriteLine("programaçao");
                                }
                                break;
                            case 5:
                                {
                                    Console.WriteLine("Fisica");
                                    Console.WriteLine("Fisica");
                                    Console.WriteLine("redes");
                                    Console.WriteLine("redes");
                                    Console.WriteLine("sociologia");
                                    Console.WriteLine("sociologia");
                                }
                                break;
                            case 6:
                                {
                                    Console.WriteLine("geografia");
                                    Console.WriteLine("geografia");
                                    Console.WriteLine("Matematica");
                                    Console.WriteLine("BDS");
                                    Console.WriteLine("BDS");
                                    Console.WriteLine("BDS");
                                }
                                break;
                            case 7:
                                {
                                    Console.WriteLine("jogar");
                                    Console.WriteLine("academia");
                                    Console.WriteLine("trabalhar");
                                    Console.WriteLine("jogar");

                                }
                                break;

                            default:
                                Console.WriteLine("essa opçao nao e valida");
                                break;
                        }


                    }
                    break;


                case 6:
                    {
                        int num, sd = 0;
                        Console.Write("Digite um número inteiro: ");
                        num = int.Parse(Console.ReadLine());

                        // Verifica a soma dos divisores próprios do número
                        for (int i = 1; i < num; i++)
                        {
                            if (num % i == 0)
                            {
                                sd += i;
                            }
                        }

                        // Verifica se o número é perfeito
                        if (sd == num)
                        {
                            Console.WriteLine("O número é um número perfeito" + num);
                        }
                        else
                        {
                            Console.WriteLine("O número não é um número perfeito" + num);
                        }
                        break;
                    }
            }
        }
               
                   

            }
}





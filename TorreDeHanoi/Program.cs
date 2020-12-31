using System;
using System.Collections.Generic;

namespace TorreDeHanoi
{
    class Program
    {
        static Stack<int> TorreA = new Stack<int>();
        static Stack<int> TorreB = new Stack<int>();
        static Stack<int> TorreC = new Stack<int>();
        static Stack<int> TorreDeComparacao = new Stack<int>();
        static int movimento = 0;
        static int limiteDeMovimento = 0;
        static int quantidade;

        static void AdicionarQuantidade(int tamanho)
        {
            for (int i = tamanho; i != 0; i--)
            {
                TorreA.Push(i);
                TorreDeComparacao.Push(i);
            }

            MovimentarHanoi();
        }


        static void ImprimirTorre()
        {
            Console.Clear();

            Console.WriteLine("\n::::Torre de Hanoi::::");

            Console.Write("Torre A: ");

            foreach (var item in TorreA)
                Console.Write(item + " ");


            Console.Write("\nTorre B: ");

            foreach (var item in TorreB)
                Console.Write(item + " ");


            Console.Write("\nTorre C: ");

            foreach (var item in TorreC)
                Console.Write(item + " ");




            Console.WriteLine($"\n ------> Quantidades de movimentos permitidos na torre: {limiteDeMovimento}");
            Console.WriteLine($"\n ------> Movimentos realizados: {movimento}");


        }

        static void FimDejogo()
        {
            int cont = 0;

            foreach (var item in TorreDeComparacao) //???
            {
                if (TorreC.Contains(item))
                    cont++;
            }

            if (cont == quantidade)
                Console.Write("\n:::::::::Parabéns você terminou a Torre de Hanói:::::::::\n");

            else
                Console.Write("\n:::::::::Você não completou a Torre de Hanoi no limite certo, tente novamente:::::::::\n");

        }

        static void MovimentarHanoi()
        {
            ImprimirTorre();

            if (movimento != limiteDeMovimento)
            {
                Console.Write("\nMovimentar peça de qual torre (A), (B), (C): ");
                char escolha = char.Parse(Console.ReadLine().ToUpper());
                char escolha2;

                if (escolha == 'A' || escolha == 'B' || escolha == 'C')
                {

                    if (escolha == 'A' && TorreA.Count > 0)
                    {
                        Console.Write($"Movimentar peça [{TorreA.Peek()}] da Torre(A) para Torre(B) ou Torre(C): ");
                        escolha2 = char.Parse(Console.ReadLine().ToUpper());

                        //TorreA -> B

                        if (escolha2 == 'B')
                        {
                            if (TorreB.Count == 0)
                            {
                                TorreB.Push(TorreA.Pop());
                                movimento++;
                            }

                            else
                            {
                                if (TorreB.Peek() < TorreA.Peek())
                                {
                                    Console.Write("Erro!!\nNão é possivel movimentar essa peça");
                                    Console.WriteLine("\n:::::Enter para continuar:::::");
                                    Console.ReadKey();
                                }

                                else
                                {
                                    TorreB.Push(TorreA.Pop());
                                    movimento++;
                                }
                            }
                        }


                        //TorreA -> C

                        if (escolha2 == 'C')
                        {
                            if (TorreC.Count == 0)
                            {
                                TorreC.Push(TorreA.Pop());
                                movimento++;
                            }

                            else
                            {
                                if (TorreC.Peek() < TorreA.Peek())
                                {
                                    Console.Write("Erro!!\nNão é possivel movimentar essa peça");
                                    Console.WriteLine("\n:::::Enter para continuar:::::");
                                    Console.ReadKey();
                                }

                                else
                                {
                                    TorreC.Push(TorreA.Pop());
                                    movimento++;
                                }

                            }
                        }




                    }



                    //::::::Torre B::::::


                    if (escolha == 'B' && TorreB.Count != 0)
                    {
                        Console.Write($"Movimentar peça [{TorreB.Peek()}] da Torre(B) para Torre(A) ou Torre(C): ");
                        escolha2 = char.Parse(Console.ReadLine().ToUpper());

                        //TorreB -> A

                        if (escolha2 == 'A')
                        {
                            if (TorreA.Count == 0)
                            {
                                TorreA.Push(TorreB.Pop());
                                movimento++;
                            }

                            else
                            {
                                if (TorreA.Peek() < TorreB.Peek())
                                {
                                    Console.Write("Erro!!\nNão é possivel movimentar essa peça");
                                    Console.WriteLine("\n:::::Enter para continuar:::::");
                                    Console.ReadKey();
                                }

                                else
                                {
                                    TorreA.Push(TorreB.Pop());
                                    movimento++;
                                }

                            }
                        }


                        //TorreB -> C

                        if (escolha2 == 'C')
                        {
                            if (TorreC.Count == 0)
                            {
                                TorreC.Push(TorreB.Pop());
                                movimento++;
                            }

                            else
                            {
                                if (TorreC.Peek() < TorreB.Peek())
                                {
                                    Console.Write("Erro!!\nNão é possivel movimentar essa peça");
                                    Console.WriteLine("\n:::::Enter para continuar:::::");
                                    Console.ReadKey();
                                }

                                else
                                {
                                    TorreC.Push(TorreB.Pop());
                                    movimento++;
                                }

                            }
                        }
                    }

                    //::::::Torre C::::::


                    if (escolha == 'C' && TorreC.Count != 0)
                    {
                        Console.Write($"Movimentar peça [{TorreC.Peek()}] da Torre(C) para Torre(A) ou Torre(B): ");
                        escolha2 = char.Parse(Console.ReadLine().ToUpper());

                        //TorreC -> A

                        if (escolha2 == 'A')
                        {
                            if (TorreA.Count == 0)
                            {
                                TorreA.Push(TorreC.Pop());
                                movimento++;
                            }

                            else
                            {
                                if (TorreA.Peek() < TorreC.Peek())
                                {
                                    Console.Write("Erro!!\nNão é possivel movimentar essa peça");
                                    Console.WriteLine("\n:::::Enter para continuar:::::");
                                    Console.ReadKey();
                                }

                                else
                                {
                                    TorreA.Push(TorreC.Pop());
                                    movimento++;
                                }

                            }
                        }


                        //TorreC -> B

                        if (escolha2 == 'B')
                        {
                            if (TorreB.Count == 0)
                            {
                                TorreB.Push(TorreC.Pop());
                                movimento++;
                            }

                            else
                            {
                                if (TorreB.Peek() < TorreC.Peek())
                                {
                                    Console.Write("Erro!!\nNão é possivel movimentar essa peça");
                                    Console.WriteLine("\n:::::Enter para continuar:::::");
                                    Console.ReadKey();
                                }

                                else
                                {
                                    TorreB.Push(TorreC.Pop());
                                    movimento++;
                                }

                            }
                        }


                    }
                }

                else
                {
                    Console.Write("Erro!\nEscolher as opções:  (A), (B), (C) ");
                }

                MovimentarHanoi();
            }


            else
                FimDejogo();
        }
        static void Main(string[] args)
        {
            Console.Write("Informe o tamanho da Torre De Hanoi: ");
            quantidade = int.Parse(Console.ReadLine());

            if (quantidade >= 4 && quantidade < 60)
            {
                limiteDeMovimento = (int)Math.Pow(2, quantidade) - 1;

                AdicionarQuantidade(quantidade);
            }
            else if (quantidade >= 60) 
                Console.WriteLine("\n::::::::::::::::::::::::::::::::: A uma lenda se todos os 64 discos fossem transferidos de uma estaca para a outra, o mundo acaba :::::::::::::::::::::::::::::::::");
            else
                Console.WriteLine("\nErro!\nLimite não permitido");
        }
    }
}

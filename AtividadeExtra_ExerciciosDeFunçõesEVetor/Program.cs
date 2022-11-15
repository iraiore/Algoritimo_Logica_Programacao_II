using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio.Lista_Vetor;
using Exercicio.Lista_Funcao;
using System.Reflection.Emit;

namespace Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;//teste

            Exercicios Exerc = new Exercicios();
            ExerciciosFunc Exerc_F = new ExerciciosFunc();
            int opc = 0;
            do
            {
                Menu();
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 0:
                        break;
                    default:
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Exercicio 1 - VETOR:");
                        Exerc.VetExerc2();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Exercicio 2 - VETOR:");
                        Exerc.VetExerc3();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Exercicio 3 - VETOR:");
                        Exerc.VetExerc7();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Exercicio 4 - VETOR:");
                        Exerc.VetExerc7a();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Exercicio 5 - VETOR:");
                        Exerc.VetExerc8();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Exercicio 6 - VETOR:");
                        Exerc.VetExerc9();
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("Exercicio 7 - VETOR:");
                        Exerc.VetExerc10();
                        break;
                    case 8:
                        Console.Clear();
                        Console.WriteLine("Exercicio 8 - FUNÇÃO:");
                        int[] vet = new int[3];
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine("digite o " + (i + 1) + "º valor");
                            vet[i] = int.Parse(Console.ReadLine());
                        }
                        Exerc_F.FuncExer1(vet);
                        break;
                    case 9:
                        Console.Clear();
                        Console.WriteLine("Exercicio 9 - FUNÇÃO:");
                        int opc2 = 0;
                        int linha = 0, coluna = 0;
                        int[,] matriz = new int[0, 0];
                        do
                        {

                            Console.WriteLine("Escolha um número de 1 a 5!");
                            Console.WriteLine("1 - Preencher uma matriz A;" +
                                              "\n2 - Ordenar os elementos da matriz A;" +
                                              "\n3 - Gerar uma matriz somente com os números pares da matriz A;" +
                                              "\n4 - Gerar um matriz somente com os números múltiplos de 5 da matriz A;"+
                                              "\n0 - Para sair!");
                            opc2 = Convert.ToInt32(Console.ReadLine());

                            switch (opc2)
                            {
                                case 0:
                                    break;
                              case 1:
                                    Console.WriteLine("Entre com o numero de linhas e colunas da matriz respectivamente");
                                    linha = int.Parse(Console.ReadLine());
                                    coluna = int.Parse(Console.ReadLine());
                                    // armazenando a matriz gerada por meio da chamada da função
                                    matriz = Exerc_F.FuncExer2a(linha, coluna);
                                    //imprimindo a matriz
                                    Exerc_F.imprimeMat(linha, coluna, matriz);
                                    break;
                                case 2:
                                    int[,] matrizb = Exerc_F.FuncExer2b(linha, coluna, matriz);
                                    Exerc_F.imprimeMat(linha, coluna, matrizb);
                                    break;
                                case 3:
                                    int[,] matrizc = Exerc_F.FuncExer2c(linha, coluna, matriz);
                                    Exerc_F.imprimeMat(linha, coluna, matrizc);
                                    break;
                                case 4:
                                    int[,] matrizd = Exerc_F.FuncExer2d(linha, coluna, matriz);
                                    Exerc_F.imprimeMat(linha, coluna, matrizd);
                                    break;
                            }                                          

                        } while (opc2 != 0);
                        break;
                    case 10:
                        string[] monetary = new string[5] {"Real - R$","Dólar - $", "Libra - £", "Franco - Fr", "Iene -  ¥" };
                        Console.WriteLine("Digite o numero para escolher a moeda que será convertida\n");
                        for (int i=0; i<5; i++)
                        {
                            Console.WriteLine((i+1)+"-"+ monetary[i]);
                        }
                        int opc3 = Convert.ToInt32(Console.ReadLine());
                        switch (opc3)
                        {
                            case 1:
                                Console.WriteLine("Entre com valor em Real a ser convertido:");
                                double real = double.Parse(Console.ReadLine());
                                double real_convertido = Exerc_F.FuncExer3(opc3,real);
                                Console.WriteLine("Valor convertido = " + real_convertido);
                                Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("Entre com valor em Dólar a ser convertido:");
                                double dolar = double.Parse(Console.ReadLine());
                                double dolar_convertido = Exerc_F.FuncExer3(opc3, dolar);
                                Console.WriteLine("Valor convertido = " + dolar_convertido);
                                Console.ReadLine();
                                break;
                            case 3:
                                Console.WriteLine("Entre com valor em Libra a ser convertido:");
                                double libra = double.Parse(Console.ReadLine());
                                double libra_convertido = Exerc_F.FuncExer3(opc3, libra);
                                Console.WriteLine("Valor convertido = " + libra_convertido);
                                Console.ReadLine();
                                break;
                            case 4:
                                Console.WriteLine("Entre com valor em Franco a ser convertido:");
                                double franco = double.Parse(Console.ReadLine());
                                double franco_convertido = Exerc_F.FuncExer3(opc3, franco);
                                Console.WriteLine("Valor convertido = " + franco_convertido);
                                Console.ReadLine();
                                break;
                            case 5:
                                Console.WriteLine("Entre com valor em Iene a ser convertido:");
                                double iene = double.Parse(Console.ReadLine());
                                double iene_convertido = Exerc_F.FuncExer3(opc3, iene);
                                Console.WriteLine("Valor convertido = " + iene_convertido);
                                Console.ReadLine();
                                break;
                        }
                        break;
                    case 11:
                        Console.WriteLine("Entre com o dividendo e o divisor respectivamente: ");
                        double dividendo = Convert.ToInt32(Console.ReadLine());
                        double divisor = Convert.ToInt32(Console.ReadLine());
                        Exerc_F.FuncExer4(dividendo, divisor);
                        Console.ReadLine();
                        break;
                    case 12:
                        Console.WriteLine("Entre com o numero a ser arredondado: ");
                        double num = double.Parse(Console.ReadLine());
                        Exerc_F.FuncExer5(ref num);
                        Console.WriteLine("o valor arredondado é: "+num);
                        Console.ReadLine();
                        break;
                    case 13:
                        Exerc_F.FuncExer6();
                        Console.ReadLine();
                        break;
                    case 14:
                        Console.WriteLine("Entre com o dividendo e o divisor respectivamente: ");
                        dividendo = Convert.ToInt32(Console.ReadLine());
                        divisor = Convert.ToInt32(Console.ReadLine());
                        Exerc_F.FuncExer7(dividendo, divisor);
                        Console.ReadLine();
                        break;
                    case 15:
                        int[] vetor_aleatorio = new int[30];
                        vetor_aleatorio = Exerc_F.FuncExer9();
                        Console.Write("VETOR ALEATORIO: ");
                        for (int i=0; i<30; i++)
                        {
                            Console.Write("["+vetor_aleatorio[i]+"]");
                        }
                        Console.Write("\nVETOR ORDENADO: ");
                        Exerc_F.FuncExer9a(vetor_aleatorio);
                        Console.Write("\nQTD DE NUMEROS MULTIPLOS DE 7 NO VETOR: "+ Exerc_F.FuncExer9b(vetor_aleatorio));
                        Console.ReadLine();
                        break;
                    case 16:
                        Console.WriteLine("Digite um numero: ");
                        double pos_neg = double.Parse(Console.ReadLine());
                        Console.WriteLine("Resposta por: ");
                        Console.Write("\nPROCEDIMENTO: ");
                        Exerc_F.FuncExer10a(pos_neg);
                        Console.Write("FUNÇÃO: ");
                        bool P_N = Exerc_F.FuncExer10b(pos_neg);
                        if (P_N == true)
                        {
                            Console.WriteLine("o valor digitado é positivo!");
                        }
                        else
                        {
                            Console.WriteLine("o valor digitado é negativo!");
                        }
                        Console.ReadLine();
                        break;
                }
            } while (opc != 0);
        }
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Digite o número de 1 a 7, para escolher o exercico da lista de vetores,\ne de 8 a n para escolher os exerccios de função! ");
            Console.WriteLine("1 - Exercicio 2");
            Console.WriteLine("2 - Exercicio 3");
            Console.WriteLine("3 - Exercicio 7");
            Console.WriteLine("4 - Exercicio 7a");
            Console.WriteLine("5 - Exercicio 8");
            Console.WriteLine("6 - Exercicio 9");
            Console.WriteLine("7 - Exercicio 10");
            Console.WriteLine("8 - Exercicio 1");
            Console.WriteLine("9 - Exercicio 2");
            Console.WriteLine("10 - Exercicio 3");
            Console.WriteLine("11 - Exercicio 4");
            Console.WriteLine("12 - Exercicio 5");
            Console.WriteLine("13 - Exercicio 6");
            Console.WriteLine("14 - Exercicio 7");
            Console.WriteLine("15 - Exercicio 9");
            Console.WriteLine("16 - Exercicio 10");
            Console.WriteLine("0 - Digite 0 para sair");

        }
    }
}

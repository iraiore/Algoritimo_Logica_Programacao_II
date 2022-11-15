using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio.Lista_Funcao
{
    internal class ExerciciosFunc
    {
        //função generica para imprimir uma matriz
        public void imprimeMat(int lin, int col, int[,] matriz_print)
        {
            Console.WriteLine("A MATRIZ: ");
            for (int i = 0; i < lin; i++)
            {
                Console.Write("|\t");
                for (int j = 0; j < col; j++)
                {
                    Console.Write(matriz_print[i, j] + "\t");
                }
                Console.WriteLine("|");
            }
            Console.ReadLine();
        }
        public int[] FuncExer1(int[] crescente)
        {
            int aux = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (crescente[i] < crescente[j])
                    {
                        aux = crescente[i];
                        crescente[i] = crescente[j];
                        crescente[j] = aux;
                    }
                }
            }
            Console.Write("Vetor Ordenado: ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(crescente[i] + " ");
            }
            Console.WriteLine("\nDigite qualquer tecla para voltar ao Menu");
            Console.ReadLine();
            return crescente;
        }

        //gerando uma matriz
        public int[,] FuncExer2a(int lin, int col)
        {
            int[,] matriz_gerada = new int[lin, col];
            for (int i = 0; i < lin; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.WriteLine("Entre com o valor [" + i + "," + j + "]");
                    matriz_gerada[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return matriz_gerada;
        }
        //ordenando a matriz
        public int[,] FuncExer2b(int lin, int col, int[,] matriz_ordenada)
        {
            for (int i = 0; i < lin; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    for (int linha = 0; linha < lin; linha++)
                    {
                        for (int coluna = 0; coluna < col; coluna++)
                        {
                            if(matriz_ordenada[i, j] < matriz_ordenada[linha, coluna])
                            {
                                int aux = matriz_ordenada[i, j];
                                matriz_ordenada[i, j] = matriz_ordenada[linha, coluna];
                                matriz_ordenada[linha,coluna] = aux;

                            }

                        }
                    }

                }
            }
            return matriz_ordenada;
        }

        //gerando uma matriz de numeros pares
        public int[,] FuncExer2c(int lin, int col, int[,]matriz_par)
        {
            for (int i = 0; i < lin; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (matriz_par[i,j]%2 != 0)
                    {
                        matriz_par[i, j] = 0;
                    }
                }
            }
            return matriz_par;
        }
        //gerando uma matriz de numeros multiplos de 5
        public int[,] FuncExer2d(int lin, int col, int[,] matriz_mult5)
        {
            for (int i = 0; i < lin; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (matriz_mult5[i, j]% 5 != 0)
                    {
                        matriz_mult5[i, j] = 0;
                    }

                }
            }
            return matriz_mult5;
        }

        public double FuncExer3(int opc_valConversao, double valor_monetario)
        {
            int escolha_conversao;
            switch (opc_valConversao)
            {
                case 1:
                    Console.WriteLine("Deseja converter R$ "+valor_monetario+" para qual moeda: " );
                    Console.WriteLine("1 - Dólar - $\n2 - Libra - £\n3 - Franco - Fr\n4 - Iene -  ¥");
                    escolha_conversao = Convert.ToInt32(Console.ReadLine());
                    switch (escolha_conversao)
                    {
                        case 1:
                            valor_monetario = valor_monetario*0.2;
                            break;
                        case 2:
                            valor_monetario = valor_monetario * 0.17;
                            break;
                        case 3:
                            valor_monetario = valor_monetario * 0.2;
                            break;
                        case 4:
                            valor_monetario = valor_monetario * 29.08;
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("Deseja converter $ " + valor_monetario + " para qual moeda: ");
                    Console.WriteLine("1 - Real - R$\n2 - Libra - £\n3 - Franco - Fr\n4 - Iene -  ¥");
                    escolha_conversao = Convert.ToInt32(Console.ReadLine());
                    switch (escolha_conversao)
                    {
                        case 1:
                            valor_monetario = valor_monetario * 5.08;
                            break;
                        case 2:
                            valor_monetario = valor_monetario * 0.88;
                            break;
                        case 3:
                            valor_monetario = valor_monetario * 1;
                            break;
                        case 4:
                            valor_monetario = valor_monetario * 147.04;
                            break;
                    }
                    break;
                case 3:
                    Console.WriteLine("Deseja converter £ " + valor_monetario + " para qual moeda: ");
                    Console.WriteLine("1 - Real - R$\n2 - Dolar - $\n3 - Franco - Fr\n4 - Iene -  ¥");
                    escolha_conversao = Convert.ToInt32(Console.ReadLine());
                    switch (escolha_conversao)
                    {
                        case 1:
                            valor_monetario = valor_monetario * 5.75;
                            break;
                        case 2:
                            valor_monetario = valor_monetario * 1.13;
                            break;
                        case 3:
                            valor_monetario = valor_monetario * 1.13;
                            break;
                        case 4:
                            valor_monetario = valor_monetario * 166.34;
                            break;
                    }
                    break;
                case 4:
                    Console.WriteLine("Deseja converter Fr " + valor_monetario + " para qual moeda: ");
                    Console.WriteLine("1 - Real - R$\n2 - Dolar - $\n3 - Libra - £\n4 - Iene -  ¥");
                    escolha_conversao = Convert.ToInt32(Console.ReadLine());
                    switch (escolha_conversao)
                    {
                        case 1:
                            valor_monetario = valor_monetario * 5.09;
                            break;
                        case 2:
                            valor_monetario = valor_monetario * 1;
                            break;
                        case 3:
                            valor_monetario = valor_monetario * 0.89;
                            break;
                        case 4:
                            valor_monetario = valor_monetario * 147.13;
                            break;
                    }
                    break;
                case 5:
                    Console.WriteLine("Deseja converter ¥ " + valor_monetario + " para qual moeda: ");
                    Console.WriteLine("1 - Real - R$\n2 - Dolar - $\n3 - Libra - £\n4 - Franco -  Fr");
                    escolha_conversao = Convert.ToInt32(Console.ReadLine());
                    switch (escolha_conversao)
                    {
                        case 1:
                            valor_monetario = valor_monetario * 0.035;
                            break;
                        case 2:
                            valor_monetario = valor_monetario * 0.0068;
                            break;
                        case 3:
                            valor_monetario = valor_monetario * 0.006;
                            break;
                        case 4:
                            valor_monetario = valor_monetario * 0.0068;
                            break;
                    }
                    break;
            }

        return valor_monetario;
        }

        public void FuncExer4(double dividendo, double divisor)
        {
            if(dividendo%divisor != 0)
            {
                Console.WriteLine("O numero "+dividendo+" não é divísivel por "+divisor);
            }
            else
            {
                Console.WriteLine("O numero " + dividendo + " é divísivel por " + divisor);
            }
        }
        public void FuncExer5(ref double valor_arredondado)
        {
            Math.Round(valor_arredondado,MidpointRounding.AwayFromZero);
        }
        public void FuncExer6()
        {
            Console.WriteLine("Digite um numero na sua mente... Agora imagine ele escrito por extenso! É isso que esse programa devia fazer e não faz!;)");
                            
        }
        public void FuncExer7(double dividendo, double divisor)
        {
            double divisao = dividendo / divisor;
            double resto = divisao - Math.Truncate(divisao);
            if (resto == 0)
            {
                Console.WriteLine("O numero  " + dividendo + " é divisivel por " + divisor);
            }
            else
            { 
                Console.WriteLine("O numero  " + dividendo + " não é divisivel por " + divisor); 
            }
        }
        public int[] FuncExer9()
        {
            Random rand = new Random();
            int[] vetor_aleatorio = new int[30];
            for(int i=0; i<30; i++)
            {
                vetor_aleatorio[i] = rand.Next(0,99);
            }
            return vetor_aleatorio;
        }
        public void FuncExer9a(int[] vet)
        {
            int aux = 0;
            for (int i=0; i<30; i++)
            {
                for (int j=0; j<30; j++)
                {
                    if (vet[i] < vet[j])
                    {
                        aux = vet[i];
                        vet[i] = vet[j];
                        vet[j] = aux;
                    }
                }
            }
            for (int i = 0; i < 30; i++)
            {
                Console.Write("[" + vet[i] + "]");
            }

        }
        public int FuncExer9b(int[] vetorb )
        {
            int multiplos_7 = 0;
            for (int i=0; i<30; i++)
            {
                if (vetorb[i]%7==0)
                {
                    multiplos_7 = multiplos_7 + 1;
                }
            }

            return multiplos_7;
        }
        public void FuncExer10a(double postivo_ou_negativo)
        {
            if (postivo_ou_negativo > 0)
            {
                Console.WriteLine("o valor digitado é positivo!");
            }
            else
            {
                Console.WriteLine("O valor digitado é negativo!");
            }

        }
        public Boolean FuncExer10b(double posive_negative)
        {
            if (posive_negative > 0)
            {
                return true;

            }
            else
            {
                return false;
            }
        }

    }
}

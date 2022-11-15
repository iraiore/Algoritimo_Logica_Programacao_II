using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio.Lista_Vetor
{
    internal class Exercicios
    {
        public void VetExerc2(){
            string[] semana = new string[7] { "segunda", "terça", "quarta", "quinta", "sexta", "sabado", "domingo" };
            double[] temperatura = new double[7];
            double soma = 0, media = 0;
            //preenchendo o vetor
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Entre com a temperatura de "+ semana[i]+": ");
                temperatura[i] = double.Parse(Console.ReadLine());
                soma = soma + temperatura[i];
            }
            media = soma/7;
            Console.WriteLine("As temperaturas que possuem valor maior que média " + media + " são: ");
            for (int i = 0; i < 7; i++)
            {
                if (temperatura[i] > media)
                {
                    Console.WriteLine(semana[i]+" "+temperatura[i]);
                }
            }
            Console.WriteLine("\nDigite qualquer tecla para voltar ao Menu");
            Console.ReadLine();
        }
        public void VetExerc3()
        {
            string[] vogais = new string[5];
            double[] altura = new double[10];
            string[] meses = new string[12];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Entre com a "+(i+1)+"º vogal: ");
                vogais[i] = Console.ReadLine();
            }
            for (int i = 0;i < 10; i++)
            {
                Console.WriteLine("Entre com a altura da " + (i + 1) + "º pessoa: ");
                altura[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine("Entre com o " + (i + 1) + "º mês: ");
                meses[i] = Console.ReadLine();
            }
            Console.WriteLine("OS dados entrados são: \n");
            Console.Write("As vogais são: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(vogais[i]+" ");
            }
            Console.WriteLine("\nAs alturas são:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Altura "+(i+1)+": "+altura[i]+"\n");
            }
            Console.Write("\nOs meses são: ");
            for (int i = 0; i < 12; i++)
            {
                Console.Write(meses[i]+" ");
            }
            Console.ReadLine();
        }
        public void VetExerc7()
        {
            string[] dia = new string[7] {"D","S","T","Q","Q","S","S" };
            double[] temperatura = new double[7];
            double temp = -1;
            //preechendo o vetor
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Entre com o valor da " + (i + 1) + "º temperatura: ");
                temp = double.Parse(Console.ReadLine());
                while (temp < 0 || temp > 80)
                {
                    Console.WriteLine("Entrada não permitida. Entre com o valor maior que 0 e menor que 80");
                    temp = double.Parse(Console.ReadLine());
                }
                temperatura[i] = temp;
            }
            Console.WriteLine("Dados da temperatura: ");
            for (int i = 0; i < 7; i++)
            {
                Console.Write("\n");
                Console.Write(dia[i]+": ");
                for (int j = 0; j<temperatura[i]; j++)
                {
                    Console.Write("■ ");
                }
               // Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
        public void VetExerc7a()
        {
            //declaração de vetores e variáveis
            string[] semana = new string[7] {"D","S","T","Q","Q","S","S"};
            double[] temperatura = new double[7];
            double ent_temperatuda = 0;
           
            //preencendo o vetor
            for (int i=0; i<7; i++) {
                //estrutura do... while para validar as entradas do usuário
                do
                {
                    Console.WriteLine("Entre com a " + (i + 1) + "º temperatura: ");
                    ent_temperatuda = double.Parse(Console.ReadLine());
                    if (ent_temperatuda>0 && ent_temperatuda<80)
                    {
                        temperatura[i] = ent_temperatuda;
                    }
                    else
                    {
                        Console.WriteLine("Entrada de temperatura inválida. Digite um valor maior que 0 e menor que 80\n");
                    }

                } while (ent_temperatuda<0 || ent_temperatuda>80);

                //imprimindo o vetor
            }
            for (int i = 0; i < 7; i++)
            {
                Console.Write("\n");
                Console.Write(semana[i]+": ");
                for (int j=0; j < temperatura[i]; j++)
                {
                    Console.Write("■ ");
                }
            }
            Console.ReadLine();
        }
        public void VetExerc8()
        {
            //declarando vetores
            double[] A = new double[10];
            double[] B = new double[10];
            double[] C = new double[10];
            int j = 9;// variavável para percorrer o vetor B da última posição até a primeira
            //preenchendo os vetores A e B
            for (int i=0; i<10; i++)
            {
                Console.WriteLine("Entre com o "+(i+1)+"º valor do vetor A");
                A[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Entre com o " + (i + 1) + "º valor do vetor B");
                B[i] = double.Parse(Console.ReadLine());
            }
            //preenchendo o vetor C de acorodo com a logica do enunciado do exercicio
            for (int i=0; i<10; i++)
            {
                C[i] = A[i] + B[j];
                j--;
            }

            //imprimindo os vetores
            Console.Write("VETOR A: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("[" + A[i] + "]");
            }
            Console.Write("\nVETOR B: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("[" + B[i] + "]");
            }
            Console.Write("\nVETOR C: ");
            for (int i=0;i<10;i++)
            {
                Console.Write("["+C[i]+"]");
            }
            Console.ReadLine();
        }
        public void VetExerc9()
        {
            //declaração de vetores e variaveis
            double[] A = new double[10];
            double[] B = new double[10];
            double[] C = new double[0];
            int repetido = 0, cont = 0, ind = 0, aux= 0, dimC=0;

            //preenchendo os vetores
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Entre com o " + (i + 1) + "º valor do vetor A");
                A[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Entre com o " + (i + 1) + "º valor do vetor B");
                B[i] = double.Parse(Console.ReadLine());
            }
            //verificando quantos elementos são comuns aos dois vetores (conjuntos)
            for (int i=0; i<10;  i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    if (A[i] == B[j])
                    {
                        repetido++;
                    }
                }
            }

            //definindo o tamanho do vetor (ou conjunto) C casonos conjuntos A e B não possuam todos os elementos em comum
            if (repetido!=20) {
                dimC = 20 - repetido;
                C = new double[dimC];

                //preenchendo o vetor C
                do
                {
                    if (A[ind] != B[ind])
                    {
                        C[cont] = A[ind];
                        C[cont+1] = B[ind];
                        cont = cont + 2;
                        ind++;
                    }
                    else
                    {
                        C[cont] = A[ind];
                        cont++;
                        ind++;
                    }
                } while (ind < 10);
            }
            //else definindo o vetor A ou B como sendo C, pois os dois são iguais
            else
            {
                C = new double[10];
                for (int i=0; i<10; i++)
                {
                    C[i] = A[i];// poderia ser o vetor B, pois A e B são iguais
                }
            }

            //ordenando o vetor C
            if (repetido != 20) {
                for (int i = 0; i <(dimC); i++)
                {
                    for (int j = 0; j<(dimC); j++)
                    {
                        if (C[i] < C[j])
                        {
                            aux = (int) C[i];
                            C[i]=C[j];
                            C[j]=aux;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < (10); i++)
                {
                    for (int j = 1; j <= (10); j++)
                    {
                        if (C[i] > C[j])
                        {
                            C[i] = C[j];
                        }
                    }
                }
            }

            //impressão dos vetores
            Console.Write("VETOR A: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("[" + A[i] + "]");
            }
            Console.Write("\nVETOR B: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("[" + B[i] + "]");
            }
            Console.Write("\nA U B = VETOR C: ");
            for (int i = 0; i < (dimC); i++)
            {
                Console.Write("[" + C[i] + "]");
            }
            Console.WriteLine("\n"+repetido);
            Console.WriteLine("\nDigite qualquer tecla para voltar ao Menu");
            Console.ReadLine();
        }
        public void VetExerc10()
        {
            //declaração de vetores
            int[] vet1 = new int[5];
            int[] vet2 = new int[5];
            int[] vet3 = new int[5];
            int[] vet4 = new int[5];
            int[] vet5 = new int[5];
            int[,] matriz = new int[5,5];
            //preecnhendo os vetores
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Entre com "+(i+1)+"° valor de Vetor 1: ");
                vet1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Entre com " + (i + 1) + "° valor de Vetor 2: ");
                vet2[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Entre com " + (i + 1) + "° valor de Vetor 3: ");
                vet3[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Entre com " + (i + 1) + "° valor de Vetor 4: ");
                vet4[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Entre com " + (i + 1) + "° valor de Vetor 5: ");
                vet5[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n");// pulando uma linha
            //preenchendo a matriz
            for (int i=0; i<5; i++)
            {
                matriz[0, i] = vet1[i];
            }
            for (int i = 0; i < 5; i++)
            {
                matriz[1, i] = vet2[i];
            }
            for (int i = 0; i < 5; i++)
            {
                matriz[2, i] = vet3[i];
            }
            for (int i = 0; i < 5; i++)
            {
                matriz[3, i] = vet4[i];
            }
            for (int i = 0; i < 5; i++)
            {
                matriz[4, i] = vet5[i];
            }
            //imprimindo a matriz
            for (int i=0; i<5; i++)
            {
                Console.WriteLine("\n");
                for (int j=0; j<5; j++) {
                    Console.Write(" \t "+matriz[i,j]+"  ");
                }

            }
            Console.ReadLine();
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ListaAlunos;

namespace ListaAlunos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declarando os objetos que irão preencher as listas
            Aluno inicio = null, cadastro = null, lista = null, auxiliar = null;
            Disciplina disciplina;
            Curso curso;
            //declaração das variáveis que irão definir o tamanho do vetor da disciplina
            int qtdDisciplinas = 0, /*qtdNotas = 0,*/ opcao = 0, cont=0; double soma = 0, media = 0;

            //Estrutura do...while para preencher a lista quantas vezes o usuário desejar e encadeá-la
            do
            {
                //estanciando os objetos
                cadastro = new Aluno();
                disciplina = new Disciplina();
                curso = new Curso();

                //populando a lista solicitando dados para o usuário
                //classe aluno
                Console.Write("Entre com o nome do aluno: ");
                cadastro.NomeAluno = Console.ReadLine();
                Console.Write("Digite a matricula do aluno "+cadastro.NomeAluno+": ");
                cadastro.Matricula = Console.ReadLine();
                //classe curso
                Console.Write("Entre com nome do curso que "+cadastro.NomeAluno+" esta cursando: ");
                curso.NomeCurso = Console.ReadLine();
                Console.Write("Digite o período/semestre do curso que "+cadastro.NomeAluno+" esta cursando: ");
                curso.NumeroSemestre = Console.ReadLine();
                //classe disciplina
                //definindo quantas o tamanho do vetro dado pelo usuário
                Console.Write("Em quantas disciplinas "+cadastro.NomeAluno+" está matriculado(a): ");
                qtdDisciplinas = Convert.ToInt32(Console.ReadLine());
                disciplina.Nome = new string[qtdDisciplinas];
                Console.Write("Entre com o numero de notas que será lançada nas disciplinas: ");
                //qtdNotas = Convert.ToInt32(Console.ReadLine());
                disciplina.qtdNotas = Convert.ToInt32(Console.ReadLine());
                disciplina.Nota = new double[qtdDisciplinas,disciplina.qtdNotas];
                //NOTA: o vetor nota da disciplina esta sendo estanciado e preenchido antes de salvar o cadastro em inicio
                /*for (int i=0; i<disciplina.Nome.Length; i++)
                {
                    Console.Write("Digite o nome da "+(i+1)+"º disciplina:");
                    disciplina.Nome[i] = Console.ReadLine();
                    Console.Write("Entre com a quantidade de notas a ser lancada na disciplina " + disciplina.Nome[i]+": ");
                    qtdNotas = Convert.ToInt32(Console.ReadLine());
                    disciplina.Nota = new double[qtdDisciplinas,qtdNotas];
                    Console.WriteLine("Entre com as notas da disciplina " + disciplina.Nome[i] + ": ");
                    for (int j=0; j<qtdNotas; j++)
                    {
                        Console.Write((j + 1) + "º NOTA: ");
                        disciplina.Nota[i,j] = Convert.ToDouble(Console.ReadLine());
                    }
                }*/
                for (int i=0; i<disciplina.Nome.Length; i++)
                {
                    Console.Write("\nDigite o nome da " + (i + 1) + "º disciplina: ");
                    disciplina.Nome[i] = Console.ReadLine();
                    Console.WriteLine("Entre com as notas da disciplina " + disciplina.Nome[i] + ": ");
                    for (int j = 0; j < disciplina.qtdNotas; j++)
                    {
                        Console.Write((j + 1) + "º NOTA: ");
                        disciplina.Nota[i, j] = Convert.ToDouble(Console.ReadLine());
                    }

                }
                //Armazenando os dados entrados na classe Disciplina e Curso
                cadastro.cur = curso;
                cadastro.dis = disciplina;
                if (inicio == null)
                {
                    inicio = cadastro;
                    inicio.Proximo = null;
                }
                else
                {
                    if(inicio.Proximo == null)
                    {
                        lista = cadastro;
                        inicio.Proximo = lista;
                        lista.Proximo = null;
                    }
                    lista.Proximo = cadastro;
                    lista = cadastro;
                    lista.Proximo = null;
                }
                Console.WriteLine("Para cadastrar mais, digite 1");
                Console.WriteLine("Para sair, digite 0");
                opcao = Convert.ToInt32(Console.ReadLine());    
            } while (opcao != 0);

            auxiliar = inicio;
            while (auxiliar != null)
            {
                Console.Write("\nNome do Aluno(a): "+auxiliar.NomeAluno+"\n");
                Console.Write("Matrilcula do Aluno(a): "+auxiliar.Matricula + "\n");
                Console.Write("Curso: " + auxiliar.cur.NomeCurso+"\n");
                Console.Write("Semestre: "+auxiliar.cur.NumeroSemestre + "\n");
                for (int i=0; i<auxiliar.dis.Nome.Length; i++)
                {
                    Console.WriteLine("DISCIPLINA: " + auxiliar.dis.Nome[i]);
                    for (int j=0; j<auxiliar.dis.qtdNotas; j++) 
                    {
                        //Console.Write("\ni = " + i + "j = " + j);//verificando os contadores
                        Console.WriteLine("NOTA "+(j+1)+":" + auxiliar.dis.Nota[i,j]);
                        cont++;
                        soma = soma + auxiliar.dis.Nota[i, j];
                    }
                    media = soma / cont;
                    Console.WriteLine("MEDIA = "+media);
                }
                Console.WriteLine("*************************************************************");
                auxiliar = auxiliar.Proximo;
            }
            Console.ReadKey();
        }
    }
}

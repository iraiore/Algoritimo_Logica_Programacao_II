using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListaMercado;

namespace ListaMercado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //criando os objetos da classe cliente
            Cliente Cadastro, inicio=null, lista=null, aux = null;
            Endereco Endereco;
            //criando as variaveis de quantidade de produtos e opcção de escolha para inserir mais cadadastros
            int qtdProduto = 0, opcao = 0, cont=0; double soma=0, media = 0;
            
            //Estrutura do ... while para o usuario preencher quantas listas ele escolher (escolha de opcao != 0)
            do
            {
                //criando o bjeto para cadastras os itens na classe Cliente
                Cadastro = new Cliente();
                Endereco = new Endereco();

                //Populando a classe Cliente e Endereco
                Console.WriteLine("Entre com nome do cliente:");
                Cadastro.Nome = Console.ReadLine();
                Console.WriteLine("Entre com CPF de "+Cadastro.Nome);
                Cadastro.CPF = Console.ReadLine();
                Console.WriteLine("Entre com o logradouro da casa do cliente:");
                Endereco.logradouro = Console.ReadLine();
                Console.WriteLine("Entre com numero da residencia do cliente");
                Endereco.numero = Console.ReadLine();
                Console.WriteLine("Entre com o CEP que reside o cliente");
                Endereco.cep = Console.ReadLine();
                Console.WriteLine("Entre com nome do bairro do cliente");
                Endereco.bairro = Console.ReadLine();
                Console.WriteLine("Entre com a cidade que reside o cliente");
                Endereco.cidade = Console.ReadLine();
                Console.WriteLine("Entre com o uf que reside o cliente");
                Endereco.uf = Console.ReadLine();

                //Populando e defindo os nomes e a quantidade de produtos que o cliente ira levar
                Console.WriteLine("Entre com a quantidade de produtos que o(a) cliente " + Cadastro.Nome + ", está comprando");
                qtdProduto = Convert.ToInt32(Console.ReadLine());
                Cadastro.valorProduto = new double[qtdProduto];
                Cadastro.nomeProduto = new string[qtdProduto];

                //Preenchendo o vetor com o nome e os precos do produto
                for (int i = 0; i < qtdProduto; i++)
                {
                    Console.WriteLine("Entre com o nome do produto: ");
                    Cadastro.nomeProduto[i] = Console.ReadLine();
                    Console.WriteLine("Digite o preço do produto " + Cadastro.nomeProduto[i]);
                    Cadastro.valorProduto[i] = double.Parse(Console.ReadLine());
                }
                //colocando os valores da classe endereco dentro da classe cliente
                Cadastro.End = Endereco;

                //alocando e encadeando a lista criada pelo usuario
                if (inicio == null)
                {
                    inicio = Cadastro; //objeto inicio da classe cliente é preenchido com primeiro cadasrto realizado
                    inicio.prox = null;
                }
                else
                {
                    if(inicio.prox == null)
                    {
                        lista = Cadastro;
                        inicio.prox = lista;
                        lista.prox = null;
                    }
                    lista.prox = Cadastro;
                    lista = Cadastro; 
                    lista.prox = null;
                }
                Console.WriteLine("Para cadastrar mais, digite 1");
                Console.WriteLine("Para sair, digite 0");
                opcao = Convert.ToInt32(Console.ReadLine());

            } while (opcao != 0);

            //imprimindo a lista populada
            aux = inicio;
            while (aux != null)
            {
                Console.Write("\nNome do cliente: "+aux.Nome);
                Console.Write("\nCPF do cliente: " + aux.CPF);
                Console.Write("\n\nEndereco: ");
                Console.Write("\nRua: "+aux.End.logradouro);
                Console.Write("\nNumero: "+aux.End.numero);
                Console.Write("\nCEP: "+aux.End.cep);
                Console.Write("\nBairro: "+aux.End.bairro);
                Console.Write("\nCidade: "+aux.End.cidade);
                Console.Write("\nEstado: "+aux.End.uf);
                Console.Write("\n\nProduto:\t\t\t Valor: R$ \n");
                for (int i=0; i < aux.nomeProduto.Length; i++)
                {
                    Console.WriteLine(aux.nomeProduto[i] + "\t\t\t\t" + aux.valorProduto[i]);
                    soma = soma + aux.valorProduto[i];
                    cont++;
                }
                media = soma / cont;
                Console.WriteLine("A média da compra é de : "+ media);
                Console.WriteLine("***************************************************************");
                //aux recebendo o promixo cadastro até receber list.prox == null
                media = 0; soma = 0; cont = 0;
                aux = aux.prox;
            }
            Console.ReadKey();
        }
    }
}

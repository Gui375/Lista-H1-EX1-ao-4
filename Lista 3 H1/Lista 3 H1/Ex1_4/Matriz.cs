using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    public class Matriz
    {
        public int[,] Matris;
        

        public void Menu()
        {
            ConsoleMenu();
            char menu;
            Console.WriteLine("em qual atvidade vc deseja entrar ?");
            menu = char.Parse(Console.ReadLine());
            switch (menu)
            {
                case '1':
                    Maior();
                    break;
               
                case '2':
                    Somar();
                    break;
               
                case '3':
                    Ex2();
                    break;
               
                case '4':
                    Ex3();  
                    break;
                
                case '5':
                    Ex4();
                    break;

                case '6':
                    Sair();
                    break;
            }
        }

        //Funções basicas do codigo do ex1

        public void ImprimirMatriz()
        {
            PreencherMatriz();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"|{ Matris[i, j]}|");                
                }
                Console.WriteLine();
            }
        }

        private void PreencherMatriz()
        {
            Matris = new int[3, 3];
            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Digite valores para esta matriz:Linha{i} Coluna{j}");
                    Matris[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void Maior()
        {
            PreencherMatriz();
            int maior = int.MinValue;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (Matris[i,j]>maior)
                    {
                        maior = Matris[i, j];
                    }
                }
            }
            Console.WriteLine("Maior numero dentro desta matriz: "+maior);
        }

        public void Somar()
        {
            PreencherMatriz();
            int somar = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    somar = Matris[i, j]+somar;
                }
            }
            Console.WriteLine("Valor da soma dos elementos: "+somar);
        }
        //exercicios adicionados como metodos
        public void Ex2()
        {
            PreencherMatriz();
            int[] media = new int[3];
            

            int somarM = 0;

            for (int i = 0;i < 3; i++)
            {
                somarM = somarM + Matris[i, 0];
                
            }
            media[0] = somarM;
            Console.WriteLine("Valor da minha média da 1ª coluna: " + somarM/3);
            somarM = 0;

            for (int i = 0; i < 3; i++)
            {
                somarM = somarM + Matris[i, 1];

            }
            media[1] = somarM;
            Console.WriteLine("Valor da minha média da 2ª coluna: " + somarM / 3);
            somarM=0;

            for (int i = 0; i < 3; i++)
            {
                somarM = somarM + Matris[i, 2];

            }
            media[2] = somarM;
            Console.WriteLine("Valor da minha média da 3ª coluna: " + somarM / 3);

            foreach (var item in media)
            {
                Console.WriteLine("Novo vetor criado: " + item);
            }



        }

        
        public void Ex3()
        {
            Console.WriteLine();
            ImprimirMatriz();
            {

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write($"|{Matris[j, i]}|");
                    }
                    Console.WriteLine();
                }

            }

    } 

        public void Ex4()
        {
            PreencherMatriz();
            int[,] MatriB= new int[3,3];
            int[,] Resoma = new int[3, 3];
            Console.WriteLine("Nova matriz sendo preenchida: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Digite valores para esta matriz:Linha{i+1} Coluna{j+1}");
                    MatriB[i, j] = int.Parse(Console.ReadLine());
                    Resoma[i, j] = MatriB[i, j] + Matris[i, j];
                }
            }

            Console.WriteLine("Matriz somada com outra matriz");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"|{Resoma[i,j]}|");
                }
                Console.WriteLine();
            }
        }


        //Layout do menu
        private void ConsoleMenu()
        {
            Console.WriteLine("Menu de seleção de caso:" +
                "\n\nAs ativades 2 a 4 foram adicionadas como métodos a parte, para maior economia de linhas e arquivos " +
                "\n\nEx1 Encontre o maior elemento da Matriz (1): " +
                "\n\nEx1 Escreva a soma dos elementos da Matriz (2): " +
                "\n\nEx2 Calculo dos elementos retornado em um vetor (3): " +
                "\n\nEx3 Matriz transposta (4): " +
                "\n\nEx4 Calculo de duas Matrizes (5): " +
                "\n\nSair do Código (6):  ");
        }

        private void Sair()
        {
            Console.Write("Fim do Codigo! ");
        }

        

        
    }
}

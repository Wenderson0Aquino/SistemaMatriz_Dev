using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMatriz
{
    internal class MatrizDeInteiros
    {
        int[,] matrizInteiros;

        public MatrizDeInteiros(int linhas, int colunas)
        {
            this.matrizInteiros = new int[linhas, colunas];

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    matrizInteiros[i, j] = 0;
                }
            }
        }

        public string Inserir(int linha, int coluna, int valor)
        {
            if (linha > matrizInteiros.GetLength(0) || coluna > matrizInteiros.GetLength(1))
            {
                return "A linha ou a coluna está fora da ordem da Matriz!";
            }
            else
            {
                matrizInteiros[linha, coluna] = valor;
                return "O valor foi inserido na Matriz!";
            }
        }

        public bool eQuadrada()
        {
            if (matrizInteiros.GetLength(0) == matrizInteiros.GetLength(1))
            {
                return true;
            }
            else
            {
                return false;
            }  
        }

        public int Total()
        {
            int resultado = 0;

            for (int i = 0; i < matrizInteiros.GetLength(0); i++)
            {
                for (int j = 0; j < matrizInteiros.GetLength(1); j++)
                {
                    resultado += matrizInteiros[i, j];
                }
            }
            return resultado;
        }

        public int MostrarNumero(int valor)
        {
            int resultado = 0;

            for (int i = 0; i < matrizInteiros.GetLength(0); i++)
            {
                for (int j = 0; j < matrizInteiros.GetLength(1); j++)
                {
                    if (valor == matrizInteiros[i,j])
                    {
                        resultado = i;
                        break;
                    }
                    else
                    {
                        resultado = -1;
                    }
                }
                if (resultado == i)
                {
                    break;
                }
            }
            return resultado;
        }

        ~MatrizDeInteiros() { }
    }
}

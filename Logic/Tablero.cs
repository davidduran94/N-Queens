using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backtracking_n_reinas.Logic
{
    class Tablero
    {
        private string[][] tablero;

        /*Constructor 1*/
        public Tablero(int tam) {
            tablero = new string[tam][];
            for (int i = 0; i < tam; i++) { 
                for(int j=0; j<tam; j++){
                    tablero[i][j] = "-";
                }    
            }
        }

        /*Constructor 2
         * transforma el arreglo de una dimension con las posiciones de las reinas a un arreglo 2d
        */
        public Tablero (int[] array){
            int tam = array.Length;
            int etapa = 0;
            tablero = new string[tam][];
            for (int i = 0; i < tam; i++)
            {
                tablero[i] = new string[tam];
                for (int j = 0; j < tam; j++)
                {
                    if (array[etapa] == j && etapa == i)
                        tablero[i][j] = "R";
                    else
                        tablero[i][j] = "-";
                }
                etapa++;
            }

        }

        /*Getters y setters*/
        public string[][] getTablero()
        {
            return tablero;
        }

        public void setTablero (string[][] tablero){
            this.tablero = tablero;
        }

        public string toString() {
            string resultado = "";
            for (int i = 0; i < tablero.Length; i++)
            {
                for (int j = 0; j < tablero.Length; j++)
                {
                    resultado += tablero[i][j] + " ";
                }
                resultado += "\n";
            }
            return resultado;
        }

    }
}

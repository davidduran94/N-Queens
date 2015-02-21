using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backtracking_n_reinas.Logic
{
    /*
     * Esta clase es la encargada de la ejecución del algoritmo de backtracking para resolver el problema de las n reinas 
     * por medio de esta clase se establecerá el tamaño del tablero donde se colocarán las reinas asi como la cantidad de estas definida por la misma 
     * variable
     */
    class Backtracking
    {
        private int reinas = 4; //el algoritmo funciona con un minimo de 4 reinas
        private int[] movimientoActual = null;
        private int etapa = 0;
        List<Tablero> tableros = null;
        

        /*Constructor*/
        public Backtracking(int reinas) {
            this.reinas = reinas;
            this.movimientoActual = new int[reinas];
            for (int i = 0; i < reinas; i++) movimientoActual[i] = -1; /*Llena el arreglo con -1*/
            this.tableros = new List<Tablero>();
            tableros.Add(new Tablero(movimientoActual));
        }

        public static void main(string[] arg) { 
                
        }

        /*
         * etapa indica que me estoy moviendo sobre que posición de array que representa el tablero
         * el tablero que recibe es sobre el cual intentará hacer la operacion
         */
        public bool funcionReinas(int[] movimiento, int etapa){
            if (etapa > reinas)
                return false;
            bool exito = false;
            while(etapa<=reinas || exito ){
                movimiento[etapa] = movimiento[etapa] + 1;
                if (validarMovimiento(movimiento, etapa)){
                    if (etapa <= reinas)
                        exito = funcionReinas(movimiento, etapa + 1);
                    else
                        exito = true;
                }
            }
            return exito;
        }
        /*
         *Para la validacion del tablero simplemente se usaron 2 reglas
         * 1- si la fila donde se encuentra la reina es la misma que alguna de las anteriores 
         * 2- si la distancia 
         */
        public bool validarMovimiento(int[] tablero, int k ) {
            for (int i = 0; i < k - 1; i++) {
                if (tablero[i] == tablero[k] || Math.Abs(tablero[i] - tablero[k]) == Math.Abs(i - k))
                {
                    return false;
                }
            }
            return true;   
        }
    }
}

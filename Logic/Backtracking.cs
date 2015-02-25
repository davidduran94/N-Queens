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

        /*public static void main(string[] arg) {
            Backtracking back = new Backtracking(4);
            Tablero tab = new Tablero(4);

        }*/

        /*
         * etapa indica que me estoy moviendo sobre que posición de array que representa el tablero
         * el tablero que recibe es sobre el cual intentará hacer la operacion
         */
        public bool funcionReinas(int[] movimiento, int etapa, ref List<Tablero> tab, ref int cr){
            bool exito=false;
            if (etapa+1 > reinas)
                return false;
            movimiento[etapa] = -1;
            while( /*(((movimiento[etapa]<reinas-1)&&(!(movimiento[etapa]>reinas-1))) || (cr+1<reinas-1) ) &&*/ (!exito && !(movimiento[etapa]==reinas-1)) ){ //se realiza hasta que se exploran todas las soluciones posibles
                movimiento[etapa] = movimiento[etapa] + 1;
                tab.Add(new Tablero(movimiento)); // se almacena la etapa antes de pasar a otra
                Console.Write("cr: " + cr + "\n");
                Console.Write("entro nueva etapa " + etapa + " : " + movimiento[0] + movimiento[1] + movimiento[2] + movimiento[3] + movimiento[4] + movimiento[5] + movimiento[6] + movimiento[7]);      
                if (validarMovimiento(movimiento, etapa)){
                    cr += 1;
                    if (cr == reinas)
                    {
                        exito = true;
                        Console.Write("encontrado!!! "+ exito.ToString());
                        return true;
                    }
                    Console.Write(" valido\n");
                    if (etapa != reinas)
                    {
                        Console.Write("-->\n");
                        exito = funcionReinas(movimiento, etapa+1, ref tab, ref cr);
                        if (exito == true)
                            return true;
                    }
                    else
                        exito = true;
                }
                Console.Write("\n");
            }
            if (!exito)
            {
                movimiento[etapa] = -1;
                cr -= 1;
            }
            return exito;
        }
        /*
         *Para la validacion del tablero simplemente se usaron 2 reglas
         * 1- si la fila donde se encuentra la reina es la misma que alguna de las anteriores 
         * 2- si la distancia 
         */
        public bool validarMovimiento(int[] tablero, int k ) {
            for (int i = 0; i<k; i++) {
                if (Math.Abs(tablero[i] - tablero[k]) == Math.Abs(i - k))
                {
                    return false;
                }
                if (tablero[k] == tablero[i])
                    return false;
            }
            for (int i = k; i>k; i--)
            {
                if (Math.Abs(tablero[i] - tablero[k]) == Math.Abs(i - k))
                {
                    return false;
                }
                if (tablero[k] == tablero[i])
                    return false;
            }
                return true;   
    }
}

}

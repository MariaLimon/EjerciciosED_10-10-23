using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_10_10_23.Clases
{
    internal class Ejercicios
    {
        //ejercicios de matrices
        public void Ejercicio1()
        {
            int[,] matriz = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine(string.Join(", ", matriz.Cast<int>()));
        }
        public void Ejercicio2()
        {
            string[,] matriz = { { "Rojo","Azul"},{ "Verde","Amarillo"} };
            Console.WriteLine(String.Join(", ",matriz.Cast<string>()));
        }
        //Declara y crea una matriz bidimensional de números reales (doubles) de
        //tamaño 4x3. Llena la matriz con valores decimales
        //y luego calcula y muestra la suma de todos los elementos de la matriz.
        public void Ejercicio3()
        {
            double[,] matriz = new double[4, 3];
            double sumaMatriz = 0;
            for (int fila = 0; fila<matriz.GetLength(0); fila++)
            {
                for(int columna = 0; columna<matriz.GetLength(1); columna++)
                {
                    Console.WriteLine($"Dame el valor de la posiscion {fila},{columna}");
                    matriz[fila, columna] = Convert.ToDouble(Console.ReadLine());
                    sumaMatriz =sumaMatriz + matriz[fila, columna]; 
                }
            }
            Console.WriteLine($"la suma de la matriz es: {sumaMatriz}");

        }
        //Declara y crea una matriz bidimensional de caracteres de tamaño 2x4.
        //Llena la matriz con caracteres alfabéticos
        //y luego imprime la matriz en forma de tabla.
        public void Ejercicio4()
        {
            char[,] matriz = new char[2, 4];
            for (int fila = 0; fila < matriz.GetLength(0); fila++)
            {
                for (int columna = 0; columna < matriz.GetLength(1); columna++)
                {
                    Console.WriteLine($"Dame el valor de la posiscion {fila},{columna}");
                    matriz[fila, columna] = Convert.ToChar(Console.ReadLine());
                }
            }
            for (int fila = 0; fila < matriz.GetLength(0); fila++)
            {
                for (int columna = 0; columna < matriz.GetLength(1); columna++)
                {
                    Console.Write(matriz[fila, columna] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

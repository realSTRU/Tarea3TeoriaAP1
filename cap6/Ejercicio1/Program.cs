using System;

namespace Program
{


    class Program
    {
        


        static void Main()
        {


            int[][] numeros = new int[2][];

            numeros [0] = new int[4];

            numeros [0][0]= 6;
            numeros [0][1]= 5;
            numeros [0][2]= 4;
            numeros [0][3]= 5;

            numeros [1] = new int[2];

            numeros[1][0]=5;
            numeros[1][1]=4;

            double promedio;
            int acumulador = 0;
            int cantidad=0;

            for(int i = 0; i<2;i++){


                for(int j = 0; j <numeros[i].GetLength(0);j++){

                    acumulador+=numeros[i][j];
                    cantidad++;

                }
            }

            promedio = acumulador/cantidad;
            Console.WriteLine($"La cantidad e numeros que hay en el jaggedArray es de {cantidad}\nPromedio={promedio}");







        }
    }
}

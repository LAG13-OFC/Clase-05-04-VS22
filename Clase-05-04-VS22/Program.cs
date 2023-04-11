using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_05_04_VS22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const Int32 Longitud = 3;
            
            Int32[] V1 = new Int32[] { 1, 2, 3,4,23,54,76,88,98,55 };
            Int32[] V2 = new Int32[] {4,5,6,55,98,5,43,78,98,99};
            Int32[] V3 = new Int32[10]; 
           

            Int32 x, Pos;

            Console.WriteLine("Ingrese un valor x");
            x = Convert.ToInt32(Console.ReadLine());

            while (x != 0)
            {
                Pos = Buscar(V1, x);

                if (Pos == -1)
                {
                    Console.WriteLine("El dato Ingresado no EXISTE");
                }
                else
                {
                    Console.WriteLine("Ingrese un nuevo valor para el V2");
                    V2[Pos] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Ingrese un valor x");
                x = Convert.ToInt32(Console.ReadLine());
            }
            ;

            Ordenar(V1, V2);

            Console.WriteLine($"\nLa cantidad es: {Generar(V1, V2, V3)}\n");
            Console.WriteLine($"\nLas posiciones son:\n");

            for (int i = 0; i < Generar(V1, V2, V3); i++)
            {
                Console.WriteLine(V3[i]);
            }


            Console.WriteLine("\nV1     V2\n");

            for(int i = 0; i < V1.Length; i++)
            {
                Console.WriteLine(V1[i] + "   "+ V2[i]);
            }


            Console.ReadKey();
        }

        private static Int32 Generar(int[] v1, int[] v2, int[] v3)
        {
            Int32 i=0, j=0;
            for(i = 0; i < v1.Length; i++)
            {
                if(v2[i]< 30)
                {
                    v3[j] = v1[i];
                    j++;
                }
            }
            return j;

        }

        private static void Ordenar(Int32[] V1, Int32[] V2)
        {
            Int32 i, x=V1.Length, k=0, aux;

            while (k == 0)
            {
                k=1;
                x--;
                for (i = 0; i < x; i++)
                {
                    if (V1[i] > V1[i + 1])
                    {
                        k = 0;
                        aux=V1[i];
                        V1 [i] = V1 [i + 1];
                        V1[i+1] = aux;

                        aux = V2[i];
                        V2[i] = V2[i + 1];
                        V2[i + 1] = aux;
                    }
                }
            }
            
        }

        static Int32 Buscar(Int32[] V1, Int32 x)
        {
            Int32 k = 0, i=0;
            Int32 Longitud = V1.Length;


            while (k == 0 && i < Longitud)
            {
                if (V1[i] == x)
                {
                    k = 1;
                }
                else
                {
                    i++;
                }
            }
                if (k == 0)
                {
                    i= -1;
                }
                return i;
                
            }
        }
    }


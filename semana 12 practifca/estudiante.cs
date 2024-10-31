using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana_12_practifca
{
    internal class estudiante
    {
        byte[] edades = new byte[0];
        int posicion = 0;

        public void insertar()
        {

            byte ed;
            string seguir;
            do
            {
                Console.Write("\nIngrese edad: ");

                while (!byte.TryParse(Console.ReadLine(), out ed) || ed < 14 || ed > 120)
                {
                    Console.Write("Error: Ingrese edad: ");
                }
                Array.Resize(ref edades, edades.Length + 1);
                edades[posicion] = ed;
                posicion++;

                Console.WriteLine("\nEdad registrada correctamente");

                Console.Write("\nDesea seguir registrando? [si]: ");
                seguir = Console.ReadLine().ToLower();



            } while (seguir == "si");
        }

        public void mostrar()
        {
            Console.SetCursorPosition(10, 12);
            Console.Write("POSICION");
            Console.SetCursorPosition(30, 12);
            Console.Write("EDADES");
            for (int c = 0; c < edades.Length; c++)
            {
                Console.SetCursorPosition(10, 13+c);
                Console.WriteLine(c);
                Console.SetCursorPosition(30, 13 + c);
                Console.Write(edades[c]);
            }
        }

        public void eliminar(byte ed)
        {
            int indice =Array.IndexOf(edades, ed);
            if(indice != -1)
            {

                for (int i = indice; i < edades.Length-1; i++)
                {
                    edades[i] = edades[i + 1];
                }
                Array.Resize(ref edades, edades.Length-1);
                posicion--;
                Console.WriteLine("\nEdad eliminada correctamente");

            }else
            {
                Console.WriteLine("\nNo se puede eliminar porque no existe");
            }
        }


    }
}
using System;

namespace ListaAbril
{
    public class Program
    {
        static void Main(String [] args)
        {
            String[] Estudiantes = new string[2];
            Estudiantes[] ListaEstudiantes = new Estudiantes[2];
            
            int cont =0;
            

            while (cont<2)
            {
                Console.WriteLine("Ingrese nombre");
                String nombre = Console.ReadLine();

                Console.WriteLine("Ingrese edad");
                int edad = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Ingrese el carnet");
                String carnet =Console.ReadLine();

                Console.WriteLine("Indique si está solvente");
                Boolean solvente = Boolean.Parse(Console.ReadLine());

                Estudiantes estudiante = new Estudiantes(nombre, edad, carnet, solvente);

                ListaEstudiantes[cont] = estudiante;
                cont++;

            }
            
            Console.WriteLine("LISTA");

            for(int i=0; i<2; i++)
            {
                Estudiantes estudiante = ListaEstudiantes[i];
                Console.WriteLine(" nombre de estudiante " + estudiante.nombre + " Carnet " + estudiante.carnet);
                
            }


        }

    }
}
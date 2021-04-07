using System;

namespace ListaAbril
{
    public class Program
    {
        static void Main(String [] args)
        {
            String[] Estudiantes = new string[2];
            String[] Cursos = new string[2];
            Estudiantes[] ListaEstudiantes = new Estudiantes[2];
            Cursos[] cursos1 = new Cursos[2];
            
            int cont =0;
            int cont2=0;
            

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

                while (cont2<2)
                {
                    Console.WriteLine("Ingrese curso");
                    String curso1 = Console.ReadLine();

                    Console.WriteLine("Ingrese nota del parcial 1");
                    int nota1 = Convert.ToInt16(Console.ReadLine());

                    Console.WriteLine("Ingrese nota del parcial 2");
                    int nota2 = Convert.ToInt16(Console.ReadLine());

                    Console.WriteLine("Ingrese nota del examen final");
                    int final = Convert.ToInt16(Console.ReadLine());
                    cont2++;
                }

            }
            
            Console.WriteLine("LISTA");

            for(int i=0; i<2; i++)
            {
                Estudiantes estudiante = ListaEstudiantes[i];
                Console.WriteLine(" nombre de estudiante " + estudiante.nombre + " Carnet " + estudiante.carnet);
                
            }
            for(int j=0; j<2; j++)
                {
                    Cursos cursos = cursos1[j];
                    Console.WriteLine("Nombre del curso" + cursos.curso);
                }
                


        }

    }
}
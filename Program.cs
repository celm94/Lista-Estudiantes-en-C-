﻿using System;

namespace ListaAbril
{
    public class Program
    {
        static void Main(String [] args)
        {
            String[] Estudiantes = new string[2];
            Estudiantes[] ListaEstudiantes = new Estudiantes[2];
            
            String[] Cursos = new string[2];
            Cursos[] ListaCursos = new Cursos[2];
            
            
            int cont =0;
            

            while(cont<2)
            {
                Console.WriteLine("INGRESE NOMBRE DE ESTUDIANTE");
                String nombre = Console.ReadLine();

                Console.WriteLine("INGRESE EDAD DE ESTUDIANTE");
                int edad = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("INGRESE CARNET DE ESTUDIANTE");
                String carnet =Console.ReadLine();

                Console.WriteLine("INDIQUE SI ESTÁ SOLVENTE");
                Boolean solvente = Boolean.Parse(Console.ReadLine());

                Estudiantes estudiante = new Estudiantes(nombre, edad, carnet, solvente);

                for(int x=0; x<2; x++){
                    Console.WriteLine("INGRESE NOMBRE DE CURSO");
                    String nombrecurso = Console.ReadLine();

                    Console.WriteLine("INGRESE NOTA DE PARCIAL 1");
                    int nota1 = Convert.ToInt16(Console.ReadLine());

                    Console.WriteLine("INGRESE NOTA DE PARCIAL 2");
                    int nota2 = Convert.ToInt16(Console.ReadLine());

                    Console.WriteLine("INGRESE NOTA DE EXAMEN FINAL");
                    int final = Convert.ToInt16(Console.ReadLine());

                    Cursos cursos1 = new Cursos(nombrecurso, nota1, nota2, final);
                    
                    ListaCursos[x] = cursos1;  

                }


                ListaEstudiantes[cont] = estudiante;
                cont++; 

            }
            Console.WriteLine("");
            Console.WriteLine("__0____oOo____0__--- LISTA ---__0____oOo____0__");

            for(int i=0; i<2; i++)
            {
                Estudiantes estudiante = ListaEstudiantes[i];
                Console.WriteLine("NOMBRE: " + estudiante.nombre + "  CARNET: " + estudiante.carnet + "  EDAD: " +estudiante.edad);
                Console.WriteLine("¿Solvente?: " +estudiante.solvente);

                for(int j=0; j<2; j++)
                {
                    Cursos cursos1 = ListaCursos[j];
                    Console.WriteLine("CURSO: " + cursos1.nombrecurso);
                    Console.WriteLine("  NOTA DE PARCIAL 1: " +cursos1.nota1+ "  NOTA DE PARCIAL 2: "+cursos1.nota2);
                    Console.WriteLine("NOTA DE EXAMEN FINAL: "+cursos1.final);
                    Console.WriteLine("");
                    Console.WriteLine("");
                } 
            }     
        }
    }
}
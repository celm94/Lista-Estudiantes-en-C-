using System;

namespace ListaAbril
{
    public class Estudiantes
    {
        public String nombre;
        public int edad;
        public String carnet;
        public Boolean solvente;

        public Estudiantes(String nombre, int edad, String carnet, Boolean solvente)
        {
            this.nombre= nombre;
            this.edad= edad;
            this.carnet= carnet;
            this.solvente= solvente;
             
        }
        
        
    }
}
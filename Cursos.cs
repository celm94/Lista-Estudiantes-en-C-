using System;

namespace ListaAbril
{
    public class Cursos
    {
        public String nombrecurso;
        public int nota1;
        public int nota2;
        public int final;

        public Cursos(String nombrecurso, int nota1, int nota2, int final)
        {
            this.nombrecurso = nombrecurso;
            this.nota1= nota1;
            this.nota2 = nota2;
            this.final= final;

        }
    }
}

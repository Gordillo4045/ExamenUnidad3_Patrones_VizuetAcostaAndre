using System;
using Entrenamiento.Bridge;

namespace Entrenamiento.Main
{
    public class SesionEntrenamiento : ISesionEntrenamiento
    {
        private readonly string nombreBase;
        private readonly int minutosBase;
        private readonly int ejerciciosBase;
        private readonly IDificultad dificultad;

        public SesionEntrenamiento(string nombre, int minutosBase, int ejerciciosBase, IDificultad dificultad)
        {
            this.nombreBase = nombre;
            this.minutosBase = minutosBase;
            this.ejerciciosBase = ejerciciosBase;
            this.dificultad = dificultad;
        }

        public virtual string Nombre => nombreBase;
        public virtual int Minutos => dificultad.AjustarMinutos(minutosBase);
        public virtual int Ejercicios => dificultad.AjustarEjercicios(ejerciciosBase);

        public virtual void Ejecutar()
        {
            Console.WriteLine($"Terminaste la sesion.");

        }
    }
}

using System;
using Entrenamiento.Main;

namespace Entrenamiento.Decorators
{
    public class ExtraEjerciciosDecorator : DecoratorBase
    {
        private readonly int extra;
        public ExtraEjerciciosDecorator(ISesionEntrenamiento inner, int extra) : base(inner)
        {
            this.extra = extra;
        }

        public override string Nombre => $"{inner.Nombre} + Ejercicios";
        public override int Ejercicios => inner.Ejercicios + extra;

        public override void Ejecutar()
        {
            Console.WriteLine($"+ {extra} ejercicios extra\n");
            base.Ejecutar();
        }
    }
}

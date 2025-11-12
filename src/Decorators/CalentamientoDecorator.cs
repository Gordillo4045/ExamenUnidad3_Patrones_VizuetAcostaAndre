using System;
using Entrenamiento.Main;

namespace Entrenamiento.Decorators
{
    public class CalentamientoDecorator : DecoratorBase
    {
        private readonly int minutos;

        public CalentamientoDecorator(ISesionEntrenamiento inner, int minutos)
            : base(inner) => this.minutos = minutos;

        public override string Nombre => $"{inner.Nombre} + Calentamiento";
        public override int Minutos => inner.Minutos + minutos;

        public override void Ejecutar()
        {
            Console.WriteLine($"Calentamiento: {minutos} minutos para de comenzar.\n");
            base.Ejecutar();
        }
    }
}

using System;
using Entrenamiento.Main;

namespace Entrenamiento.Decorators
{
    public class EnfriamientoDecorator : DecoratorBase
    {
        private readonly int minutos;

        public EnfriamientoDecorator(ISesionEntrenamiento inner, int minutos)
            : base(inner) => this.minutos = minutos;

        public override string Nombre => $"{inner.Nombre} + Enfriamiento";
        public override int Minutos => inner.Minutos + minutos;

        public override void Ejecutar()
        {
            base.Ejecutar();
            Console.WriteLine($"Enfriamiento: {minutos} minutos de estiramiento y respiración.\n");
        }
    }
}

using System;
using Entrenamiento.Main;

namespace Entrenamiento.Decorators
{
    public class ExtraTiempoDecorator : DecoratorBase
    {
        private readonly int extra;
        public ExtraTiempoDecorator(ISesionEntrenamiento inner, int extra) : base(inner)
        {
            this.extra = extra;
        }

        public override string Nombre => $"{inner.Nombre} + Tiempo";
        public override int Minutos => inner.Minutos + extra;

        public override void Ejecutar()
        {
            Console.WriteLine($"+ {extra} min extra\n");
            base.Ejecutar();
        }
    }
}

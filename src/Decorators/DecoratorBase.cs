using Entrenamiento.Main;

namespace Entrenamiento.Decorators
{
    public abstract class DecoratorBase : ISesionEntrenamiento
    {
        protected readonly ISesionEntrenamiento inner;
        protected DecoratorBase(ISesionEntrenamiento inner) => this.inner = inner;

        public virtual string Nombre => inner.Nombre;
        public virtual int Minutos => inner.Minutos;
        public virtual int Ejercicios => inner.Ejercicios;

        public virtual void Ejecutar() => inner.Ejecutar();
    }
}

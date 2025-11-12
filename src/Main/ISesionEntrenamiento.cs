namespace Entrenamiento.Main
{
    public interface ISesionEntrenamiento
    {
        string Nombre { get; }
        int Minutos { get; }
        int Ejercicios { get; }
        void Ejecutar();
    }
}

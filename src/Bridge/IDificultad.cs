namespace Entrenamiento.Bridge
{
    public interface IDificultad
    {
        string Nombre { get; }
        int AjustarMinutos(int baseMin);
        int AjustarEjercicios(int baseEj);
    }
}

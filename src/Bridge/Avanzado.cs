namespace Entrenamiento.Bridge
{
    public class Avanzado : IDificultad
    {
        public string Nombre => "Avanzado";
        public int AjustarMinutos(int baseMin) => (int)Math.Floor(baseMin * 1.3);
        public int AjustarEjercicios(int baseEj) => (int)Math.Floor(baseEj * 1.3);
    }
}

namespace Entrenamiento.Bridge
{
    public class Principiante : IDificultad
    {
        public string Nombre => "Principiante";
        public int AjustarMinutos(int baseMin) => (int)Math.Floor(baseMin * 0.8);
        public int AjustarEjercicios(int baseEj) => baseEj * 0.8 > 0 ? (int)Math.Floor(baseEj * 0.8) : 1;
    }
}

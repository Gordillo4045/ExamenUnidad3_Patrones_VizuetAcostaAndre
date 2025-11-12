namespace Entrenamiento.Bridge
{
    public class Intermedio : IDificultad
    {
        public string Nombre => "Intermedio";
        public int AjustarMinutos(int baseMin) => baseMin;
        public int AjustarEjercicios(int baseEj) => baseEj;
    }
}

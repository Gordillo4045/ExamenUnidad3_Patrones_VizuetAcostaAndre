using System;
using Entrenamiento.Bridge;
using Entrenamiento.Main;
using Entrenamiento.Decorators;

namespace Entrenamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== App de Entrenamiento ===");

            IDificultad dificultad;
            while (true)
            {
                Console.WriteLine("\nElige dificultad:");
                Console.WriteLine("1) Principiante");
                Console.WriteLine("2) Intermedio");
                Console.WriteLine("3) Avanzado");
                Console.Write("Opción: ");
                string op = Console.ReadLine() ?? "";
                if (op == "1") { dificultad = new Principiante(); break; }
                if (op == "2") { dificultad = new Intermedio(); break; }
                if (op == "3") { dificultad = new Avanzado(); break; }
            }

            ISesionEntrenamiento sesion;
            const int baseMinCardio = 30, baseEjCardio = 8, baseMinFuerza = 45, baseEjFuerza = 10, baseMinYoga = 60, baseEjYoga = 6;
            while (true)
            {
                Console.WriteLine("\nElige tipo de sesión:");
                Console.WriteLine($"1) Cardio  {dificultad.AjustarMinutos(baseMinCardio)} min, {dificultad.AjustarEjercicios(baseEjCardio)} ejercicios");
                Console.WriteLine($"2) Fuerza  {dificultad.AjustarMinutos(baseMinFuerza)} min, {dificultad.AjustarEjercicios(baseEjFuerza)} ejercicios");
                Console.WriteLine($"3) Yoga    {dificultad.AjustarMinutos(baseMinYoga)} min, {dificultad.AjustarEjercicios(baseEjYoga)} ejercicios");
                Console.Write("Opción: ");
                string op = Console.ReadLine() ?? "";
                if (op == "1") { sesion = new SesionEntrenamiento("Cardio", baseMinCardio, baseEjCardio, dificultad); break; }
                if (op == "2") { sesion = new SesionEntrenamiento("Fuerza", baseMinFuerza, baseEjFuerza, dificultad); break; }
                if (op == "3") { sesion = new SesionEntrenamiento("Yoga", baseMinYoga, baseEjYoga, dificultad); break; }
            }

            Console.Write("\nAgregar mas tiempo? (s/n): ");
            if (Console.ReadLine()?.Trim().ToLower() == "s")
            {
                Console.Write("Minutos extra: ");
                if (int.TryParse(Console.ReadLine(), out int extraMins) && extraMins > 0)
                    sesion = new ExtraTiempoDecorator(sesion, extraMins);
            }

            Console.Write("\nAgregar mas ejercicios? (s/n): ");
            if (Console.ReadLine()?.Trim().ToLower() == "s")
            {
                Console.Write("Cantidad extra de ejercicios: ");
                if (int.TryParse(Console.ReadLine(), out int extraEj) && extraEj > 0)
                    sesion = new ExtraEjerciciosDecorator(sesion, extraEj);
            }

            Console.Write("\nAgregar calentamiento? (s/n): ");
            if (Console.ReadLine()?.Trim().ToLower() == "s")
            {
                Console.Write("Duración del calentamiento (min): ");
                if (int.TryParse(Console.ReadLine(), out int mins) && mins > 0)
                    sesion = new CalentamientoDecorator(sesion, mins);
            }

            Console.Write("\nAgregar enfriamiento? (s/n): ");
            if (Console.ReadLine()?.Trim().ToLower() == "s")
            {
                Console.Write("Duracion del enfriamiento (min): ");
                if (int.TryParse(Console.ReadLine(), out int mins) && mins > 0)
                    sesion = new EnfriamientoDecorator(sesion, mins);
            }
            Console.WriteLine($"\nIniciando {sesion.Nombre}, nivel {dificultad.Nombre}, duracion de {sesion.Minutos} min, con {sesion.Ejercicios} ejercicios\n");
            sesion.Ejecutar();
        }
    }
}

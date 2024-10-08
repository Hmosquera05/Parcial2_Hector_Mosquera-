public class Program
{
    static void Main(string[] args)
    {
        do
        {
            // Lista para almacenar las notas de los estudiantes
            List<double> notasEstudiantes = new List<double>();
            int estudiantesGanaron = 0;
            int estudiantesPerdieron = 0;
            string continuar;

            // Ingresar notas de los estudiantes
            Console.WriteLine("Ingrese la cantidad de estudiantes:");
            int cantidadEstudiantes = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidadEstudiantes; i++)
            {
                Console.WriteLine($"Ingrese la nota del estudiante {i + 1}:");
                double nota = double.Parse(Console.ReadLine());
                notasEstudiantes.Add(nota);
public class Program
{
    private static string continuar;

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
            }

            // Evaluar y clasificar cada estudiante de acuerdo su nota
            foreach (var nota in notasEstudiantes)
            {
                double promedio = nota; // Como solo hay una nota por estudiante, el promedio es la nota misma.
                string categoria = ClasificarDesempeno(promedio);

                Console.WriteLine($"Estudiante con nota {nota} está en la categoría: {categoria}");

                if (promedio >= 3.5)
                {
                    estudiantesGanaron++;
                }
                else
                {
                    estudiantesPerdieron++;
                }
            }

            // Mostrar resultados
            Console.WriteLine($"\nTotal de estudiantes que aprobaron: {estudiantesGanaron}");
            Console.WriteLine($"Total de estudiantes que no aprobaron: {estudiantesPerdieron}");

            // Preguntar si desea continuar
            Console.WriteLine("¿Desea ingresar otro grupo de estudiantes? (s/n):");
            continuar = Console.ReadLine().ToLower();
        } while (continuar == "s");
    }

    static string ClasificarDesempeno(double promedio)
    {
        if (promedio >= 4.5)
            return "Excelente";
        else if (promedio >= 4.0)
            return "Sobresaliente";
        else if (promedio >= 3.5)
            return "Bueno";
        else
            return "Insuficiente";
    }
}

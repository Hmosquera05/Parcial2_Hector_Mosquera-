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

            // Evaluar y clasificar cada estudiante
            foreach (var nota in notasEstudiantes)
            {
                double promedio = nota; // Aquí se asume que la nota ingresada es el promedio por simplicidad
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

            
    

public class Program
{
    static void Main()
    {
        bool jugarOtraVez;

        do
        {
            jugarOtraVez = false;
            Console.Clear();
            Console.WriteLine("Hola! Vas a jugar al juego 'Adivina el número'. El juego es muy sencillo, consiste en que los participantes comenzarán en orden a jugar y se turnarán para ingresar por pantalla un número ℕ hasta acertar el número oculto y salir ganador.!");

            int numJugadores;
            do
            {
                Console.Write("Ingrese el número de jugadores (2-4): ");
            } while (!int.TryParse(Console.ReadLine(), out numJugadores) || numJugadores < 2 || numJugadores > 4);

            int rangoSuperior = numJugadores switch
            {
                2 => 50,
                3 => 100,
                4 => 200,
                _ => throw new ArgumentOutOfRangeException()
            };

            Random random = new Random();
            int numeroSecreto = random.Next(0, rangoSuperior + 1);
            int jugadorActual = 0;
            bool numeroAdivinado = false;

            
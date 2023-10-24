// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int num = 0;
int coins = 0;
string message = "";
string controlOtraCarta = "";
string switchControl = "menu";
System.Random random = new System.Random();
//BlackJack, Juntar 21 pidiendo cartas o en caso de tener menos de 21 igual tener mayor puntuación que el dealer


while (true)
{
    Console.WriteLine("Welcome To CASINO");
    Console.WriteLine("Cuantos créditos deseas \n Ingresa un número entero \n Recuerda que necesitas una x ronda de juego");
    coins = int.Parse(Console.ReadLine());

    for (int i = 0; i < coins; i++)
    {

        int totalJugador = 0;
        int totalDealer = 0;
        switch (switchControl)
        {
            case "menu":
                Console.WriteLine("Escriba '21' para jugar al 21");
                switchControl = Console.ReadLine();
                i = i - 1;
                break;

            case "21":
                do
                {
                    num = random.Next(1, 12);
                    totalJugador = totalJugador + num;
                    Console.WriteLine("Toma tu Carta");
                    Console.WriteLine($"Te salió el número: {num}");
                    Console.WriteLine("¿ Deseas otra carta ?");
                    controlOtraCarta = Console.ReadLine();
                }
                while (controlOtraCarta == "Si" ||
                       controlOtraCarta == "si" ||
                       controlOtraCarta == "yes");

                totalDealer = random.Next(12, 21);
                Console.WriteLine($"El dealer tiene {totalDealer}");

                if (totalJugador > totalDealer && totalJugador < 22)
                {
                    message = "Venciste al Dealer, felicidades";
                }
                else if (totalJugador >= 22)
                {
                    message = "Perdiste vs el Dealer te pasaste de 21";
                    switchControl = "menu";
                }
                else if (totalJugador <= totalDealer)
                {
                    message = "El Dealer te venció, Sigue intentando";
                    switchControl = "menu";
                }
                else
                {
                    message = "Condición no válida";
                }

                Console.WriteLine(message);
                break;

            default:
                Console.WriteLine("Valor ingresado no es valido en el CASINO");
                break;
        }
    }
}
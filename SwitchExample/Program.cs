// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int totalJugador = 0;
int totalDealer = 0;
int num = 0;
string controlOtraCarta = "";
int platziCoins = 0;
string message = "";
System.Random random = new System.Random();
string switchControl = "menu";

//Blackjack, si tienes mas puntos que el lider ganas, pero si tienes menos o te pasas de 21 entonces pierdes
//Se usa " string message = "" " porque se trata de una cadena de texto
// Usar el simbolo $ antes de las comillas me permite insertar variables al texto
while (true)
{

    Console.WriteLine("Bienvenito al CASINO");
    Console.WriteLine("¿Cuántos PlatziCoins quieres? \n" +
        "Ingresa un numero entero \n" +
        "Necesitaras una por cada ronda");
    platziCoins = int.Parse(Console.ReadLine());

    for (int i = 0; i < platziCoins; i++)
    {

        totalJugador = 0;
        totalDealer = 0;
        switch (switchControl)
        {
            case "menu":
                Console.WriteLine("Escriba 21 para jugar al Blackjack");
                switchControl = Console.ReadLine();
                i = i - 1;
                break;

            case "21":

                do
                {
                    /*Tengo que poner System.Random random = new System.Random();
                    para que C# sepa que estoy usando esa función*/
                    num = random.Next(1, 10);
                    totalJugador = totalJugador + num;

                    Console.WriteLine("Toma tu carta");
                    Console.WriteLine($"Te salió el: {num}");
                    Console.WriteLine("¿Quieres otra carta?");
                    controlOtraCarta = Console.ReadLine();

                } while (controlOtraCarta == "Si" || controlOtraCarta == "ok" || controlOtraCarta == "si");

                totalDealer = random.Next(13, 21);

                Console.WriteLine($"El jugador tiene {totalJugador}");
                Console.WriteLine($"El dealer tiene {totalDealer}");
                if ((totalJugador > totalDealer) && totalJugador <= 21)
                {
                    message = "Venciste al Dealer";
                    switchControl = "menu";
                }

                else if ((totalJugador < totalDealer) || totalJugador >= 22)
                {
                    message = "La casa gana, mejor suerte para la proxima";
                    switchControl = "menu";
                }

                else if (totalJugador == totalDealer)
                {
                    message = "Empataron, por poco y no la cuentas";
                }

                Console.WriteLine(message);
                break;
            default:
                Console.WriteLine("Valor ingresado no es valido para el CASINO");
                break;
        }
    }
}
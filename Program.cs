using System;

class Program
{
    static void Main()
    {
        string dniadulto = "";
        int menorAcompañado = 0;
        int precioEquipajeDeMas = 0;
        int precioAdicional = 0;
        Console.WriteLine("¡Bienvenido al sistema check -in  del aereopuerto! ingrese los datos solicitados");
        Console.Write("Ingrese nombre del pasajero: ");
        string nombre = Console.ReadLine();
        Console.WriteLine("Ingrese el dni del pasajero: ");
        string dni = Console.ReadLine();
        Console.Write("Ingrese la edad del pasajero: ");
        int edad = int.Parse(Console.ReadLine());


        //codigo de embarque
        Random rnd = new Random();
        char letra1 = (char)rnd.Next('A', 'Z' + 1);
        char letra2 = (char)rnd.Next('A', 'Z' + 1);
        string num1 = rnd.Next(0, 10).ToString();
        string num2 = rnd.Next(0, 10).ToString();
        string num3 = rnd.Next(0, 10).ToString();
        string num4 = rnd.Next(0, 10).ToString();
        string num5 = rnd.Next(0, 10).ToString();

        string codigoEmbarque = letra1.ToString() + letra2.ToString() + num1 + num2 + num3 + num4 + num5;

        if ((edad >= 2) && (edad < 5))
        {
            Console.WriteLine("Ingrese dni del adulto acompañante: ");
            dniadulto = Console.ReadLine();
        }
        else if ((edad >= 5) && (edad <= 11))
        {
            Console.WriteLine("¿Desea utilizar el servicio de menor no acompañado? (si:0, no: 1): ");
            menorAcompañado = int.Parse(Console.ReadLine());
            if (menorAcompañado == 1)
            {
                Console.WriteLine("Ingrese dni del adulto acompañante: ");
                dniadulto = Console.ReadLine();
            }
        }

        Console.WriteLine("Ingrese el destino de vuelo: ");
        string destino = Console.ReadLine();
        Console.Write("Ingrese la clase del vuelo (economia, ejecutiva, primera clase) ");
        string clase = Console.ReadLine();

        Console.Write("¿Posee equipaje en mano? (si: 1, no: 0): ");
        int equipajeMano = int.Parse(Console.ReadLine());
        if (equipajeMano == 1)
        {
            Console.Write("¿Cual es la cantidad?: ");
            int cantidadEquipaje = int.Parse(Console.ReadLine());
            if (cantidadEquipaje > 3)
                Console.WriteLine("Usted excede la cantidad de equipaje permitido por persona (3)");
        }
        {
            Console.WriteLine("¿Posee equipaje facturado? (si: 1, no: 2): ");
            int equipajefacturado = int.Parse(Console.ReadLine());
            if (equipajefacturado == 0)
            {
                Console.WriteLine("ingrese el peso de su equipaje en kilos: ");
                int pesoequipaje = int.Parse(Console.ReadLine());
                if ((clase == "economica") && (pesoequipaje > 5)) ;
                {
                    precioAdicional = (pesoequipaje - 5) * 10;
                    Console.WriteLine("Debera pagar $" + precioAdicional + " por  el peso adcional de su clase");
                }
            }
        }

        Console.Write("¿Viaja con un perro de servicio? (si: 1, no: 0): ");
        int perro = int.Parse(Console.ReadLine());
        if (perro == 1) ;
        {
            Console.Write("¿El perro esta debidamente identificado y posee correa para asegurarlo con el cinturon de seguridad?");
            int perroSeguridad = int.Parse(Console.ReadLine());
            if (perroSeguridad == 0)
            {
                Console.WriteLine("El perro debe disponer de todos los elementos de seguridad requeridos para abordar el avión");
            }
        }
        if (((edad > 4) && (edad < 11)) && (menorAcompañado == 1))
        {
            Console.WriteLine("Nombre: " + nombre + " DNI del pasajero: " + dni + " Edad: " + edad + " DNI adulto acompañante: " + dniadulto + " Destino: " + destino + " Clase: " + clase + "Código de Embarque" + codigoEmbarque );
        }
        else
        {
            if (precioEquipajeDeMas > 0)
            {
                Console.WriteLine(nombre + "Edad: " + edad + "Servicio: Menor no acompañado" + "DNI del pasajero:" + dni + "Destino:" + destino + "Clase:" + clase + "Monto por equipaje excedente: $" + precioEquipajeDeMas + "Código de Embarque" + codigoEmbarque);
            }
            else
            {
                Console.WriteLine(nombre + " Edad: " + edad + "Servicio: Menor no acompañado" + "DNI del pasajero:" + dni + "Destino:" + destino + "Clase:" + clase + "Código de Embarque" + codigoEmbarque);
            }
        }
    }
}
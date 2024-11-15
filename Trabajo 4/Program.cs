int[] numbers = new int[10];
int eleccion;
string[] options = ["Bubble", "Shell", "Seleccion", "Interseccion"];

Organizer organizer = new Organizer();

do
{


    eleccion = organizer.opciones();







    Console.WriteLine("Inserte los 10 digitos del arreglo: ");


    for (int i = 0; i <= 9; i++)
    {
        Console.WriteLine("Inserte el digito: " + (i + 1));

        int digit = int.Parse(Console.ReadLine());


        numbers[i] = digit;
    }


    //////////////////////////////////////////////////////////////////


    switch (eleccion)
    {

        case 1:

            organizer.bubbleOrder(numbers);

            break;

        case 2:

            organizer.ShellSort(numbers);

            break;
        case 3:

            organizer.seleccion(numbers);


            break;
        case 4:

            organizer.Insercion(numbers);


            break;

        case 5:



            Console.WriteLine("Elija el primer algoritmo");
            eleccion = organizer.opciones_1();
            double valor_1 = organizer.swith(eleccion, numbers);
            Console.WriteLine("Elija el segundo algoritmo");
            int eleccion_2 = organizer.opciones_1();
            double valor_2 = organizer.swith(eleccion_2, numbers);

            Console.WriteLine($"El tiempo del algoritmo {options[(eleccion - 1)]} es {valor_1} y el del algoritmo {options[(eleccion_2 - 1)]} es {valor_2}");

            if (valor_1 < valor_2)
            {


                double porcentaje = (valor_1 * 100) / valor_2;

                Console.WriteLine(porcentaje);

                Console.WriteLine($"De acuerdo con la info recolectada, podemos ver que el algoritmo {options[(eleccion - 1)]} es un {100-porcentaje}% mas rapido que el algoritmo {options[(eleccion_2 - 1)]} en este caso especifico");


            }
            else
            {


                double porcentaje = (valor_2 * 100) / valor_1;
                Console.WriteLine(porcentaje);

                Console.WriteLine($"De acuerdo con la info recolectada, podemos ver que el algoritmo {options[(eleccion_2 - 1)]} es un {100-porcentaje}% mas rapido que el algoritmo {options[(eleccion - 1)]} en este caso especifico");


            }


            break;





    }





}
while (eleccion>0);

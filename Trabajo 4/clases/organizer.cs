using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

public class Organizer
{


    public double swith(int eleccion, int[] numbers) {


        switch (eleccion)
        {

            case 1:

                return bubbleOrder(numbers);

                break;

            case 2:

                return ShellSort(numbers);

                break;
            case 3:

                return seleccion(numbers);


                break;
            case 4:

                return Insercion(numbers);


                break;

        }


        return 1.2;
    }
    public int opciones() {

        int eleccion = 0;
        string msg = "";


        Console.WriteLine("1. Ordenamiento de Burbuja");
        Console.WriteLine("2. Ordenamiento de Shell");
        Console.WriteLine("3. Ordenamiento de Seleccion");
        Console.WriteLine("4. Ordenamiento de Insercion");
        Console.WriteLine("5. Benchmark entre algoritmos");
        Console.WriteLine("0. Salir");


        do
        {
            Console.WriteLine("Elija el metodo de ordenamientoa utilizar: ");



            try
            {


                eleccion = int.Parse(Console.ReadLine());



            }
            catch (Exception e)
            {

                msg = e.Message;

                Console.WriteLine("Opcion no valida");


            }


        }
        while (msg.Length > 0);


        return eleccion;

    }

    public int opciones_1()
    {

        int eleccion = 0;
        string msg = "";


        Console.WriteLine("1. Ordenamiento de Burbuja");
        Console.WriteLine("2. Ordenamiento de Shell");
        Console.WriteLine("3. Ordenamiento de Seleccion");
        Console.WriteLine("4. Ordenamiento de Insercion");

        do
        {



            try
            {


                eleccion = int.Parse(Console.ReadLine());



            }
            catch (Exception e)
            {

                msg = e.Message;

                Console.WriteLine("Opcion no valida");


            }


        }
        while (msg.Length > 0);


        return eleccion;

    }


    int[] numbers;
    DateTime date=DateTime.Now;


    private double tiempo(DateTime date) {

        double time;


        return  time=DateTime.Now.Subtract(date).Milliseconds;



    }



    public double bubbleOrder(int[] numbers ) {

        int counter = 0;

        DateTime date = DateTime.Now;

        do
        {

            for (global::System.Int32 i = 0; i <= 9; i++)
            {
                if (i<9)
                {

                    int x = numbers[i];
                    int y = numbers[i + 1];


                    if (x > y)
                    {


                        numbers[i] = y;
                        numbers[i + 1] = x;




                    }



                }

            }
            counter++;

        }
        while (counter<=8);

        Console.WriteLine("El arreglo ordenado seria");

        foreach (var item in numbers)
        {
            Console.WriteLine(item);
            
        }



        double info_time=tiempo(date);

        Console.WriteLine($"El tiempo que tomo el algoritmo en organizar la info fue: {info_time} milisegundos");

        return info_time;   
        


    }


    public double ShellSort(int[] array)
    {

        DateTime date = DateTime.Now;

        int n = array.Length;
        int gap = n / 2;

        while (gap > 0)
        {
            for (int i = gap; i < n; i++)
            {
                int temp = array[i];
                int j = i;

                while (j >= gap && array[j - gap] > temp)
                {
                    array[j] = array[j - gap];
                    j -= gap;
                }

                array[j] = temp;
            }   

            gap /= 2;
        }

        Console.WriteLine("El arreglo ordenado seria");


        foreach (var item in array)
        {


            Console.WriteLine($"{item}");
        }

        double info_time = tiempo(date);

        Console.WriteLine($"El tiempo que tomo el algoritmo en organizar la info fue: {info_time}  milisegundos");

        return info_time;

    }




    public double seleccion(int[] numbers) {

        DateTime date = DateTime.Now;


        int x =0;
        int y=0;

        int[] ordenados = new int[numbers.Length];

        for (int j = 0; j < numbers.Length; j++)
        {

            for (int i = (j+1); i < numbers.Length; i++)
            {

                if (numbers[i] < numbers[j])
                {
                    x = i;

                    y = numbers[j];

                    numbers[j] = numbers[x];
                    numbers[x] = y;

                }
                else { 
                
                    x= j;
     

                }




            }


        }


        Console.WriteLine("El arreglo ordenado seria");


        foreach (var item in numbers)
        {

            Console.WriteLine(item);
            
        }


        double info_time = tiempo(date);

        Console.WriteLine($"El tiempo que tomo el algoritmo en organizar la info fue: {info_time} milisegundos");

        return info_time;


    }



    public double Insercion(int[] numbers) {

        DateTime date = DateTime.Now;


        int x = 0;
        int y = 0;

        for (int i = 1; i < numbers.Length; i++)
        {


            for (int j = (i-1); j >= 0; j--)
            {

                //Console.WriteLine($"j es igual a: {j}");

                //Console.WriteLine($"Es {numbers[i]} menor que {numbers[j]}");


                if (numbers[i] < numbers[j])
                {

                    //Console.WriteLine($"SI, {numbers[i]} menor que {numbers[j]}");

                    x = j;

                    y = numbers[i];

                    numbers[i] = numbers[x];
                    numbers[x] = y;


                    i--;


                }
                else
                {


                    x = i;

                    //Console.WriteLine($"NO, {numbers[i]} no es menor que {numbers[j]}");

                }

                //Console.WriteLine($"Arreglo parcial");
                //foreach (var item in numbers) { 
                
                //    Console.WriteLine(item);
                
                //}


            }

        }

        Console.WriteLine("El arreglo ordenado seria");


        foreach (var item in numbers)
        {

            Console.WriteLine(item);

        }


        double info_time = tiempo(date);

        Console.WriteLine($"El tiempo que tomo el algoritmo en organizar la info fue: {info_time} milisegundos");

        return info_time;


    }



}

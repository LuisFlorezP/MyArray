using Arrays.Logic;
using System.ComponentModel.Design;

try
{
	Console.WriteLine("Hello, Arrays!");
    int option;
    MyArray myArray = new(10);
    myArray.Fill();
    do
    {
        option = Menu();
        switch (option)
        {
            case 1:
                Console.Write("Ingrese númer de elementos: ");
                var nString = Console.ReadLine();
                int n = 10;
                int.TryParse(nString, out n);
                myArray = new(n);
                myArray.Fill();
                break;
            case 2:
                Console.WriteLine(myArray);
                break;
            case 3:
                Console.WriteLine(myArray.GetOdds());
                break;
            case 4:
                Console.WriteLine(myArray.GetPrimes());
                break;
            case 5:
                Console.WriteLine(myArray.GetNonRepeated());
                break;
            case 6:
                Console.WriteLine(myArray.GetMostRepeated());
                break;
            case 7:
                Console.WriteLine(myArray.Invest());
                break;
            case 8:
                Console.WriteLine("\nTotal amount of the array: " + myArray.TotalAmount());
                break;
            case 9:
                Console.WriteLine("\nAverage of the array: " + myArray.Average());
                break;
            case 10:
                
                break;
            case 11:
                
                break;
            case 0:
                Console.WriteLine("\nComing out...");
                break;
            default:
                Console.WriteLine("\nFuck you. Opción no existe!!!!");
                break;
        }
    } while (option != 0);
}
catch (Exception ex)
{
	Console.WriteLine(ex.Message);
}

int Menu()
{
    Console.WriteLine(
        "\nOPTIONS:\n" +
            "   - Option 1. Definir tamaño de arreglo.\n" +
                "   - Option 2. Mostrar arreglo.\n" +
                    "   - Option 3. Mostrar múmeros pares.\n" +
                        "   - Option 4. Mostrar múmeros primos.\n" +
                            "   - Option 5. Mostrar múmeros que no se repiten.\n" +
                                "   - Option 6. Mostrar múmeros que más se repiten.\n" +
                                    "   - Option 7. Invertir arreglo.\n" +
                                        "   - Option 8. Sumar arreglo.\n" +
                                            "   - Option 9. Promedio arreglo.\n" +
                                                "   - Option 10. Arreglo fibonnaci.\n" +
                                                    "   - Option 11. Ordenar arreglo.\n" +
                                                        "   - Option 0. Salir.");
    bool isValid = false;
    int option = 0;
    do
    {
        Console.Write("Digite su opción: ");
        var optionString = Console.ReadLine();
        if (!int.TryParse(optionString, out option))
        {
            Console.WriteLine("\nOpción inválida, solo use números.");
            isValid = false;
        }
        else
        {
            isValid = true;
        }
    } while (!isValid);
    return option;
}
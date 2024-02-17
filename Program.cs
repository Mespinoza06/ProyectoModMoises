// See https://aka.ms/new-console-template for more information
class Program
{
    static string[] estudiantes = new string[10];
    static string[] cedula = new string[2];
    static string[] nombre = new string[2];
    static int[] promedio = new int[2];
    static string[] condicion = new string[2];
    static string buscar = "";
    static bool encontrada = false;
    static int modificar = 0;
    static string newNom = "";
    static string newCed = "";
    static int newProm = 0;
    static string continuar = "";
    static  int contador = 0;
    static string nombres = "";
    static string repCondi = "";
    static int indice = 0;
    static int mayor = 0;
    static int menor = 0;
    static int[] alto=new int[2];
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nMenú Principal:");
            Console.WriteLine("1. Inicializar Vectores");
            Console.WriteLine("2. Incluir Estudiantes");
            Console.WriteLine("3. Consultar Estudiantes");
            Console.WriteLine("4. Modificar Estudiantes");
            Console.WriteLine("5. Eliminar Estudiantes");
            Console.WriteLine("6. Submenú Reportes");
            Console.WriteLine("7. Salir");

            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    InicializarVectores();
                    break;
                case "2":
                    IncluirEstudiante();
                    break;
                case "3":
                    ConsultarEstudiantes();
                    break;
                case "4":
                    ModificarEstudiantes();
                    break;
                case "5":
                    EliminarEstudiantes();
                    break;
                case "6":
                    SubmenuReportes();
                    break;
                case "7":
                    Console.WriteLine("Saliendo del programa. ¡Hasta luego!");
                    return;
                default:
                    Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                    break;
            }
        }
    }

    static void InicializarVectores()
    {
        estudiantes = new string[10];
        Console.WriteLine("Vectores inicializados con éxito.");
    }

    static void SubmenuReportes()
    {
        while (true)
        {
            Console.WriteLine("\nSubmenú Reportes:");
            Console.WriteLine("1. Reporte Estudiantes por Condición");
            Console.WriteLine("2. Reporte Todos los datos");
            Console.WriteLine("3. Regresar al Menú Principal");

            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Generando reporte de estudiantes por condición...");

                    Console.WriteLine("Digite la Condicion de los estudiantes que desea buscar");
                    repCondi = Console.ReadLine();

                    foreach (var item in condicion)
                    {
                        
                        Console.WriteLine($"Cedula :{cedula[indice]} Nombre :{nombre[indice]} Promedio :{promedio[indice]} Condicion :{item}");
                        indice++;
                    }
                    


                    break;
                case "2":
                    Console.WriteLine("Generando reporte con todos los datos de los estudiantes...");



                    
                    for (int i = 0; i <cedula.Length; i++)
                    {
                        if (promedio[i] >= mayor)
                        {
                            mayor = promedio[i];
                            alto[i] = mayor;

                            
                        }
                        else if (promedio[i] < mayor)
                        {
                            menor = promedio[i];
                        }
                        
                    }
                    Console.WriteLine("*******Los estudiantes con las notas mas altas son:********");
                    for (int j = 0; j < cedula.Length; j++)
                    {
                        if (promedio[j] == mayor)
                        {


                            Console.WriteLine("=============================================================================================");
                            Console.WriteLine($"Cédula: {cedula[j]} Nombre: {nombre[j]} Promedio: {promedio[j]} Condición: {condicion[j]}  ");
                            Console.WriteLine("=============================================================================================");

                           
                        }
                    }
                    Console.WriteLine("********Los estudiantes con las notas mas Bajas son:********");
                    for (int j = 0; j < cedula.Length; j++)
                    {
                        if (promedio[j] == menor)
                        {


                            Console.WriteLine("=============================================================================================");
                            Console.WriteLine($"Cédula: {cedula[j]} Nombre: {nombre[j]} Promedio: {promedio[j]} Condición: {condicion[j]}  ");
                            Console.WriteLine("=============================================================================================");


                        }
                    }
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida."+promedio);
                    break;
            }
        }
    }

    static void IncluirEstudiante()
    {
        bool validar = false;
        try
        {
            for (int i = 0; i < cedula.Length; i++)
            {
                Console.WriteLine("Digite la Cedula del Estudiante " + (i + 1));
                cedula[i] = Console.ReadLine();

                Console.WriteLine("Digite el Nombre del Estudiante " + (i + 1));
                nombres = Console.ReadLine();
                nombre[i] = nombres.ToLower();

                Console.WriteLine("Digite promedio del estudiante " + (i + 1));
                promedio[i] = int.Parse(Console.ReadLine());

                if (promedio[i] >= 70)
                {
                    condicion[i] = "Aprobado";
                }
                else if (promedio[i] < 70 && promedio[i] >= 60)
                {
                    condicion[i] = "Aplazado";
                }
                else if (promedio[i] < 60)
                {
                    condicion[i] = "Reprobado";
                }

            }

        }
        catch (Exception error1)
        {

            Console.WriteLine("error");
            validar = true;
        }
    }
    static void ConsultarEstudiantes()
    {
        bool validar = false;
        try
        {
            Console.WriteLine("Digite el número de cédula del estudiante que desea consultar");
            string buscar = Console.ReadLine();
            bool encontrada = false;

            for (int i = 0; i < cedula.Length; i++)
            {
                if (cedula[i] == buscar)
                {


                    Console.WriteLine("=============================================================================================");
                    Console.WriteLine($"Cédula: {cedula[i]} Nombre: {nombre[i]} Promedio: {promedio[i]} Condición: {condicion[i]}  ");
                    Console.WriteLine("=============================================================================================");

                    encontrada = true;
                    break; // Salir del bucle una vez que se encuentra la cédula
                }
            }

            if (!encontrada)
            {
                Console.WriteLine("No se encontró ningún estudiante con esa cédula.");
            }
        }
        catch (Exception error2)
        {
            Console.WriteLine("Error de formato, intente de nuevo");
            validar = true;
        }

    }
    static void ModificarEstudiantes()
    {
        //modificar estudiantes
        bool validar = false;
        do
        {
            try
            {
                Console.WriteLine("Digite el número de cédula del estudiante que desea modificar");
                buscar = Console.ReadLine();




                for (int i = 0; i < cedula.Length; i++)
                {
                    if (cedula[i] == buscar)
                    {
                        do
                        {
                            Console.WriteLine("Modificar 1-nombre");
                            Console.WriteLine("Modificar 2-cedula");
                            Console.WriteLine("Modificar 3-Promedio");
                            modificar = int.Parse(Console.ReadLine());

                            switch (modificar)
                            {
                                case 1:
                                    Console.WriteLine("Digite el nuevo Nombre");
                                    newNom = Console.ReadLine();
                                    nombre[i] = newNom;
                                    break;

                                case 2:
                                    Console.WriteLine("Digite la nueva Cedula");
                                    newCed = Console.ReadLine();
                                    cedula[i] = newCed;
                                    break;

                                case 3:
                                    Console.WriteLine("Digite el nuevo Promedio");
                                    newProm = int.Parse(Console.ReadLine());
                                    promedio[i] = newProm;

                                    if (newProm >= 70)
                                    {
                                        condicion[i] = "Aprobado";
                                    }
                                    else if (newProm < 70 && newProm >= 60)
                                    {
                                        condicion[i] = "Aplazado";
                                    }
                                    else if (newProm < 60)
                                    {
                                        condicion[i] = "Reprobado";
                                    }

                                    break;

                                default:
                                    Console.WriteLine("Opcion incorrecta");
                                    break;
                            }
                            // Preguntar al usuario si desea seguir modificando o salir
                            Console.WriteLine("¿Desea realizar más modificaciones? (S/N)");
                            continuar = Console.ReadLine();
                            if (continuar.ToUpper() != "S")
                            {
                                break; // Salir del bucle si la respuesta no es "S"
                            }

                        } while (true); // Bucle de modificación
                         // Salir del bucle principal una vez que se modifica el estudiante
                    }
                }

                if (!encontrada)
                {
                    Console.WriteLine("No se encontró ningún estudiante con esa cédula.");
                }

            }
            catch (Exception error1)
            {

                Console.WriteLine("Error de formato, intente de nuevo");
                validar= true;
            }

        } while (true);
        
        
    }
    static void EliminarEstudiantes()
    {
        //eliminar estudiantes
        bool validar = false;
        do
        {
            try
            {
                Console.WriteLine("Digite el número de cédula del estudiante que desea consultar");
                buscar = Console.ReadLine();


                for (int i = 0; i < cedula.Length; i++)
                {
                    if (cedula[i] == buscar)
                    {

                        nombre[i] = "0";
                        promedio[i] = 0;
                        condicion[i] = "0";
                        encontrada = true;
                        break; // Salir del bucle una vez que se encuentra la cédula
                    }
                }

                if (!encontrada)
                {
                    Console.WriteLine("No se encontró ningún estudiante con esa cédula.");
                }
            }
            catch (Exception error2)
            {

                Console.WriteLine("Error de formato, intente de nuevo");
                validar = true;
            }

        } while (true);        
        

    }
    
}

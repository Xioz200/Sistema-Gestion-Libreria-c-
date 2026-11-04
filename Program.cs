
using System;

class Program
{
    // ==========================================
    // PUNTO DE ENTRADA
    // ==========================================

    static void Main()
    {
        MostrarMenuPrincipal();
    }

   // MENU PRINCIPAL    

    static void MostrarMenuPrincipal()
    {
        bool continuar = true;

        while (continuar)
        {
            MostrarOpciones();

            int opcion = LeerOpcion();

            switch (opcion)
            {
                case 1:
                    MenuLibros();
                    break;

                case 2:
                    MenuUsuarios();
                    break;

                case 3:
                    MenuPrestamos();
                    break;

                case 4:
                    MenuBusquedasReportes();
                    break;

                case 5:
                    MenuGuardarCargar();
                    break;

                case 6:
                    Salir();
                    continuar = false;
                    break;

                default:
                    MostrarOpcionInvalida();
                    break;
            }
        }
    }

    // ==========================================
    // MOSTRAR OPCIONES
    // ==========================================

    static void MostrarOpciones()
    {
        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine("       SISTEMA DE GESTION DE BIBLIOTECA");
        Console.WriteLine("========================================");
        Console.WriteLine("1. Libros");
        Console.WriteLine("2. Usuarios");
        Console.WriteLine("3. Prestamos");
        Console.WriteLine("4. Busquedas y reportes");
        Console.WriteLine("5. Guardar / Cargar datos");
        Console.WriteLine("6. Salir");
        Console.WriteLine("========================================");
    }

    // ==========================================
    // LEER OPCION
    // ==========================================

    static int LeerOpcion()
    {
        Console.Write("Seleccione una opcion: ");

        string entrada = Console.ReadLine() ?? string.Empty;

        return int.TryParse(entrada, out int opcion)
            ? opcion
            : -1;
    }

    // ==========================================
    // ACCESO A LOS MODULOS
    // ==========================================

    static void MenuLibros()
    {
        Console.WriteLine(
            "Se ha seleccionado el modulo de libros."
        );
    }

    static void MenuUsuarios()
    {
        Console.WriteLine(
            "Se ha seleccionado el modulo de usuarios."
        );
    }

    static void MenuPrestamos()
    {
        Console.WriteLine(
            "Se ha seleccionado el modulo de prestamos."
        );
    }

    static void MenuBusquedasReportes()
    {
        Console.WriteLine(
            "Se ha seleccionado el modulo de busquedas y reportes."
        );
    }

    static void MenuGuardarCargar()
    {
        Console.WriteLine(
            "Se ha seleccionado el modulo de guardar y cargar datos."
        );
    }

    // ==========================================
    // SALIR DEL PROGRAMA
    // ==========================================

    static void Salir()
    {
        while (true)
        {
            Console.Write("¿Desea guardar antes de salir? (S/N): ");

            string respuesta = (
                Console.ReadLine() ?? string.Empty
            ).Trim();

            if (respuesta.Equals(
                "S", StringComparison.OrdinalIgnoreCase))
            {
                GuardarDatos();
                break;
            }

            if (respuesta.Equals(
                "N", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }

            Console.WriteLine(
                "Respuesta no valida. Escriba S o N."
            );
        }

        Console.WriteLine();
        Console.WriteLine("Gracias por utilizar el sistema de biblioteca.");
        Console.WriteLine("Programa finalizado.");
    }

    // ==========================================
    // GUARDAR DATOS
    // ==========================================

    static void GuardarDatos()
    {
        Console.WriteLine(
            "La funcionalidad de guardar datos se desarrollara posteriormente."
        );
    }

    // ==========================================
    // VALIDACIONES
    // ==========================================

    static void MostrarOpcionInvalida()
    {
        Console.WriteLine(
            "Opcion no valida. Intente nuevamente."
        );
    }
}

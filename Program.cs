
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

    // ==========================================
    // FEATURE 1: MENU PRINCIPAL
    // ==========================================

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
    // MOSTRAR MENU PRINCIPAL
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
    // FEATURE 2: MENU DE LIBROS
    // ==========================================

    static void MenuLibros()
    {
        int opcion;

        do
        {
            MostrarMenuLibros();

            opcion = LeerOpcion();

            switch (opcion)
            {
                case 1:
                    RegistrarLibro();
                    break;

                case 2:
                    MenuListarLibros();
                    break;

                case 3:
                    VerDetalleLibro();
                    break;

                case 4:
                    MenuActualizarLibro();
                    break;

                case 5:
                    EliminarLibro();
                    break;

                case 0:
                    Console.WriteLine(
                        "Regresando al menu principal..."
                    );
                    break;

                default:
                    MostrarOpcionInvalida();
                    break;
            }

        } while (opcion != 0);
    }

    // ==========================================
    // MOSTRAR MENU DE LIBROS
    // ==========================================

    static void MostrarMenuLibros()
    {
        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine("             GESTION DE LIBROS");
        Console.WriteLine("========================================");
        Console.WriteLine("1. Registrar libro");
        Console.WriteLine("2. Listar libros");
        Console.WriteLine("3. Ver detalle de libro");
        Console.WriteLine("4. Actualizar libro");
        Console.WriteLine("5. Eliminar libro");
        Console.WriteLine("0. Volver al menu principal");
        Console.WriteLine("========================================");
    }

    // ==========================================
    // ACCIONES GENERALES DE LIBROS
    // ==========================================

    static void RegistrarLibro()
    {
        Console.WriteLine(
            "Se ha seleccionado registrar un libro."
        );
    }

    static void VerDetalleLibro()
    {
        Console.WriteLine(
            "Se ha seleccionado consultar el detalle de un libro."
        );
    }

    
    // ==========================================
    // FEATURE 4: ACTUALIZAR LIBROS
    // ==========================================

    static void MenuActualizarLibro()
    {
        int opcion;

        do
        {
            MostrarMenuActualizarLibro();

            opcion = LeerOpcion();

            switch (opcion)
            {
                case 1:
                    EditarTituloLibro();
                    break;

                case 2:
                    EditarAutorLibro();
                    break;

                case 3:
                    EditarAnioCategoriaLibro();
                    break;

                case 0:
                    Console.WriteLine(
                        "Regresando al menu de libros..."
                    );
                    break;

                default:
                    MostrarOpcionInvalida();
                    break;
            }

        } while (opcion != 0);
    }

    // ==========================================
    // MOSTRAR SUBMENU DE ACTUALIZACION
    // ==========================================

    static void MostrarMenuActualizarLibro()
    {
        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine("           ACTUALIZAR LIBRO");
        Console.WriteLine("========================================");
        Console.WriteLine("1. Editar titulo");
        Console.WriteLine("2. Editar autor");
        Console.WriteLine("3. Editar anio / categoria");
        Console.WriteLine("0. Volver al menu de libros");
        Console.WriteLine("========================================");
    }

    // ==========================================
    // ACCIONES DE ACTUALIZACION
    // ==========================================

    static void EditarTituloLibro()
    {
        Console.WriteLine(
            "Se ha seleccionado editar el titulo de un libro."
        );
    }

    static void EditarAutorLibro()
    {
        Console.WriteLine(
            "Se ha seleccionado editar el autor de un libro."
        );
    }

    static void EditarAnioCategoriaLibro()
    {
        Console.WriteLine(
            "Se ha seleccionado editar el anio o categoria de un libro."
        );
    }

    static void EliminarLibro()
    {
        Console.WriteLine(
            "Se ha seleccionado eliminar un libro."
        );
    }

    // ==========================================
    // FEATURE 3: SUBMENU LISTAR LIBROS
    // ==========================================

    static void MenuListarLibros()
    {
        int opcion;

        do
        {
            MostrarMenuListarLibros();

            opcion = LeerOpcion();

            switch (opcion)
            {
                case 1:
                    ListarTodosLosLibros();
                    break;

                case 2:
                    ListarLibrosDisponibles();
                    break;

                case 3:
                    ListarLibrosPrestados();
                    break;

                case 0:
                    Console.WriteLine(
                        "Regresando al menu de libros..."
                    );
                    break;

                default:
                    MostrarOpcionInvalida();
                    break;
            }

        } while (opcion != 0);
    }

    // ==========================================
    // MOSTRAR SUBMENU DE LISTADOS
    // ==========================================

    static void MostrarMenuListarLibros()
    {
        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine("              LISTAR LIBROS");
        Console.WriteLine("========================================");
        Console.WriteLine("1. Listar todos los libros");
        Console.WriteLine("2. Listar libros disponibles");
        Console.WriteLine("3. Listar libros prestados");
        Console.WriteLine("0. Volver al menu de libros");
        Console.WriteLine("========================================");
    }

    // ==========================================
    // ACCIONES DE LISTADO
    // ==========================================

    static void ListarTodosLosLibros()
    {
        Console.WriteLine(
            "Se ha seleccionado listar todos los libros."
        );
    }

    static void ListarLibrosDisponibles()
    {
        Console.WriteLine(
            "Se ha seleccionado listar los libros disponibles."
        );
    }

    static void ListarLibrosPrestados()
    {
        Console.WriteLine(
            "Se ha seleccionado listar los libros prestados."
        );
    }

    // ==========================================
    // MODULO DE USUARIOS
    // ==========================================

    
    // ==========================================
    // FEATURE 5: MENU DE USUARIOS
    // ==========================================

    static void MenuUsuarios()
    {
        int opcion;

        do
        {
            MostrarMenuUsuarios();

            opcion = LeerOpcion();

            switch (opcion)
            {
                case 1:
                    RegistrarUsuario();
                    break;

                case 2:
                    ListarUsuarios();
                    break;

                case 3:
                    VerDetalleUsuario();
                    break;

                case 4:
                    MenuActualizarUsuario();
                    break;

                case 5:
                    EliminarUsuario();
                    break;

                case 0:
                    Console.WriteLine(
                        "Regresando al menu principal..."
                    );
                    break;

                default:
                    MostrarOpcionInvalida();
                    break;
            }

        } while (opcion != 0);
    }

    // ==========================================
    // MOSTRAR MENU DE USUARIOS
    // ==========================================

    static void MostrarMenuUsuarios()
    {
        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine("            GESTION DE USUARIOS");
        Console.WriteLine("========================================");
        Console.WriteLine("1. Registrar usuario");
        Console.WriteLine("2. Listar usuarios");
        Console.WriteLine("3. Ver detalle de usuario");
        Console.WriteLine("4. Actualizar usuario");
        Console.WriteLine("5. Eliminar usuario");
        Console.WriteLine("0. Volver al menu principal");
        Console.WriteLine("========================================");
    }

    // ==========================================
    // ACCIONES DE USUARIOS
    // ==========================================

    static void RegistrarUsuario()
    {
        Console.WriteLine(
            "Se ha seleccionado registrar un usuario."
        );
    }

    static void ListarUsuarios()
    {
        Console.WriteLine(
            "Se ha seleccionado listar los usuarios."
        );
    }

    static void VerDetalleUsuario()
    {
        Console.WriteLine(
            "Se ha seleccionado consultar el detalle de un usuario."
        );
    }

    
    // ==========================================
    // FEATURE: ACTUALIZAR USUARIOS
    // ==========================================

    static void MenuActualizarUsuario()
    {
        int opcion;

        do
        {
            MostrarMenuActualizarUsuario();

            opcion = LeerOpcion();

            switch (opcion)
            {
                case 1:
                    EditarNombreUsuario();
                    break;

                case 2:
                    EditarContactoUsuario();
                    break;

                case 3:
                    CambiarEstadoUsuario();
                    break;

                case 0:
                    Console.WriteLine(
                        "Regresando al menu de usuarios..."
                    );
                    break;

                default:
                    MostrarOpcionInvalida();
                    break;
            }

        } while (opcion != 0);
    }

    // ==========================================
    // MOSTRAR SUBMENU DE ACTUALIZACION
    // ==========================================

    static void MostrarMenuActualizarUsuario()
    {
        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine("          ACTUALIZAR USUARIO");
        Console.WriteLine("========================================");
        Console.WriteLine("1. Editar nombre");
        Console.WriteLine("2. Editar contacto");
        Console.WriteLine("3. Activar / desactivar usuario");
        Console.WriteLine("0. Volver al menu de usuarios");
        Console.WriteLine("========================================");
    }

    // ==========================================
    // ACCIONES DE ACTUALIZACION
    // ==========================================

    static void EditarNombreUsuario()
    {
        Console.WriteLine(
            "Se ha seleccionado editar el nombre del usuario."
        );
    }

    static void EditarContactoUsuario()
    {
        Console.WriteLine(
            "Se ha seleccionado editar el contacto del usuario."
        );
    }

    static void CambiarEstadoUsuario()
    {
        Console.WriteLine(
            "Se ha seleccionado activar o desactivar un usuario."
        );
    }


    static void EliminarUsuario()
    {
        Console.WriteLine(
            "Se ha seleccionado eliminar un usuario."
        );
    }


    // ==========================================
    // MODULO DE PRESTAMOS
    // ==========================================

    static void MenuPrestamos()
    {
        Console.WriteLine(
            "Se ha seleccionado el modulo de prestamos."
        );
    }

    // ==========================================
    // MODULO DE BUSQUEDAS Y REPORTES
    // ==========================================

    static void MenuBusquedasReportes()
    {
        Console.WriteLine(
            "Se ha seleccionado el modulo de busquedas y reportes."
        );
    }

    // ==========================================
    // MODULO DE GUARDAR / CARGAR DATOS
    // ==========================================

    static void MenuGuardarCargar()
    {
        Console.WriteLine(
            "Se ha seleccionado el modulo de guardar y cargar datos."
        );
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
    // FINALIZAR PROGRAMA
    // ==========================================

    static void Salir()
    {
        while (true)
        {
            Console.Write(
                "¿Desea guardar antes de salir? (S/N): "
            );

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
        Console.WriteLine(
            "Gracias por utilizar el sistema de biblioteca."
        );

        Console.WriteLine("Programa finalizado.");
    }

    // ==========================================
    // FUNCIONES GENERALES
    // ==========================================

    static int LeerOpcion()
    {
        Console.Write("Seleccione una opcion: ");

        string entrada = Console.ReadLine() ?? string.Empty;

        if (int.TryParse(entrada, out int opcion))
        {
            return opcion;
        }

        return -1;
    }

    static void MostrarOpcionInvalida()
    {
        Console.WriteLine(
            "Opcion no valida. Intente nuevamente."
        );
    }
}

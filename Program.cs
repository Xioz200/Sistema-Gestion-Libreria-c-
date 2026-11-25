using System;
using System.Collections.Generic;

class Program
{
    // ==========================================
    // PUNTO DE ENTRADA
    // ==========================================

    static void Main()
    {
        // Prueba del servicio de libros.
        MostrarPruebaLibroService();

        // Prueba del servicio de usuarios.
        MostrarPruebaUsuarioService();

        MostrarPruebaPrestamoService();
        MostrarComparacionArrayList();

        // Iniciar el menú principal.
        ShowMainMenu();


    }

    // ==========================================
    // MENU PRINCIPAL
    // ==========================================

    static void ShowMainMenu()
    {
        bool continuar = true;

        while (continuar)
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

            int opcion = ReadOption();

            switch (opcion)
            {
                case 1:
                    ShowBooksMenu();
                    break;

                case 2:
                    ShowUsersMenu();
                    break;

                case 3:
                    ShowLoansMenu();
                    break;

                case 4:
                    ShowSearchReportsMenu();
                    break;

                case 5:
                    ShowPersistenceMenu();
                    break;

                case 6:
                    continuar = !ConfirmExitAndSave();
                    break;

                default:
                    ShowInvalidOption();
                    break;
            }
        }
    }

    // ==========================================
    // FEATURE: BOOKS MENU
    // ==========================================

    static void ShowBooksMenu()
    {
        int opcion;

        do
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

            opcion = ReadOption();

            switch (opcion)
            {
                case 1:
                    RegisterBook();
                    break;

                case 2:
                    ListBooksMenu();
                    break;

                case 3:
                    ViewBookDetail();
                    break;

                case 4:
                    UpdateBookMenu();
                    break;

                case 5:
                    DeleteBook();
                    break;

                case 0:
                    Console.WriteLine("Regresando al menu principal...");
                    break;

                default:
                    ShowInvalidOption();
                    break;
            }

        } while (opcion != 0);
    }

    // REGISTRAR LIBRO

    static void RegisterBook()
    {
        Console.WriteLine(
            "Se ha seleccionado registrar un libro."
        );
    }

    // LISTAR LIBROS

    static void ListBooksMenu()
    {
        int opcion;

        do
        {
            Console.WriteLine();
            Console.WriteLine("========== LISTAR LIBROS ==========");
            Console.WriteLine("1. Listar todos");
            Console.WriteLine("2. Listar disponibles");
            Console.WriteLine("3. Listar prestados");
            Console.WriteLine("0. Volver");

            opcion = ReadOption();

            switch (opcion)
            {
                case 1:
                    ListBooksAll();
                    break;

                case 2:
                    ListBooksAvailable();
                    break;

                case 3:
                    ListBooksBorrowed();
                    break;

                case 0:
                    Console.WriteLine("Regresando al menu de libros...");
                    break;

                default:
                    ShowInvalidOption();
                    break;
            }

        } while (opcion != 0);
    }

    static void ListBooksAll()
    {
        MostrarPruebaLibros();
    }

    static void ListBooksAvailable()
    {
        Console.WriteLine(
            "Se ha seleccionado listar los libros disponibles."
        );
    }

    static void ListBooksBorrowed()
    {
        Console.WriteLine(
            "Se ha seleccionado listar los libros prestados."
        );
    }

    // DETALLE DE LIBRO

    static void ViewBookDetail()
    {
        Console.WriteLine(
            "Se ha seleccionado consultar el detalle de un libro por ID o ISBN."
        );
    }

    // ACTUALIZAR LIBRO

    static void UpdateBookMenu()
    {
        int opcion;

        do
        {
            Console.WriteLine();
            Console.WriteLine("========== ACTUALIZAR LIBRO ==========");
            Console.WriteLine("1. Editar titulo");
            Console.WriteLine("2. Editar autor");
            Console.WriteLine("3. Editar año / categoria");
            Console.WriteLine("0. Volver");

            opcion = ReadOption();

            switch (opcion)
            {
                case 1:
                    EditBookTitle();
                    break;

                case 2:
                    EditBookAuthor();
                    break;

                case 3:
                    EditBookYearCategory();
                    break;

                case 0:
                    Console.WriteLine("Regresando al menu de libros...");
                    break;

                default:
                    ShowInvalidOption();
                    break;
            }

        } while (opcion != 0);
    }

    static void EditBookTitle()
    {
        Console.WriteLine(
            "Se ha seleccionado editar el titulo del libro."
        );
    }

    static void EditBookAuthor()
    {
        Console.WriteLine(
            "Se ha seleccionado editar el autor del libro."
        );
    }

    static void EditBookYearCategory()
    {
        Console.WriteLine(
            "Se ha seleccionado editar el año o la categoria del libro."
        );
    }

    // ELIMINAR LIBRO

    static void DeleteBook()
    {
        Console.WriteLine(
            "Se ha seleccionado eliminar un libro."
        );

        Console.WriteLine(
            "Validacion: no permitir eliminar el libro si esta prestado."
        );
    }

    // ==========================================
    // FEATURE: USERS MENU
    // ==========================================

    static void ShowUsersMenu()
    {
        int opcion;

        do
        {
            Console.WriteLine();
            Console.WriteLine("========================================");
            Console.WriteLine("           GESTION DE USUARIOS");
            Console.WriteLine("========================================");
            Console.WriteLine("1. Registrar usuario");
            Console.WriteLine("2. Listar usuarios");
            Console.WriteLine("3. Ver detalle de usuario");
            Console.WriteLine("4. Actualizar usuario");
            Console.WriteLine("5. Eliminar usuario");
            Console.WriteLine("0. Volver al menu principal");
            Console.WriteLine("========================================");

            opcion = ReadOption();

            switch (opcion)
            {
                case 1:
                    RegisterUser();
                    break;

                case 2:
                    ListUsers();
                    break;

                case 3:
                    ViewUserDetail();
                    break;

                case 4:
                    UpdateUserMenu();
                    break;

                case 5:
                    DeleteUser();
                    break;

                case 0:
                    Console.WriteLine("Regresando al menu principal...");
                    break;

                default:
                    ShowInvalidOption();
                    break;
            }

        } while (opcion != 0);
    }

    static void RegisterUser()
    {
        Console.WriteLine(
            "Se ha seleccionado registrar un usuario."
        );
    }

    static void ListUsers()
    {
        MostrarPruebaUsuarios();
    }

    static void ViewUserDetail()
    {
        Console.WriteLine(
            "Se ha seleccionado consultar un usuario por ID o documento."
        );
    }

    // ACTUALIZAR USUARIO

    static void UpdateUserMenu()
    {
        int opcion;

        do
        {
            Console.WriteLine();
            Console.WriteLine("========== ACTUALIZAR USUARIO ==========");
            Console.WriteLine("1. Editar nombre");
            Console.WriteLine("2. Editar contacto");
            Console.WriteLine("3. Activar / desactivar");
            Console.WriteLine("0. Volver");

            opcion = ReadOption();

            switch (opcion)
            {
                case 1:
                    EditUserName();
                    break;

                case 2:
                    EditUserContact();
                    break;

                case 3:
                    ToggleUserActiveStatus();
                    break;

                case 0:
                    Console.WriteLine("Regresando al menu de usuarios...");
                    break;

                default:
                    ShowInvalidOption();
                    break;
            }

        } while (opcion != 0);
    }

    static void EditUserName()
    {
        Console.WriteLine(
            "Se ha seleccionado editar el nombre del usuario."
        );
    }

    static void EditUserContact()
    {
        Console.WriteLine(
            "Se ha seleccionado editar el contacto del usuario."
        );
    }

    static void ToggleUserActiveStatus()
    {
        Console.WriteLine(
            "Se ha seleccionado activar o desactivar un usuario."
        );
    }

    static void DeleteUser()
    {
        Console.WriteLine(
            "Se ha seleccionado eliminar un usuario."
        );

        Console.WriteLine(
            "Validacion: no permitir eliminar usuarios con prestamos activos."
        );
    }

    // ==========================================
    // FEATURE: LOANS MENU
    // ==========================================

    static void ShowLoansMenu()
    {
        int opcion;

        do
        {
            Console.WriteLine();
            Console.WriteLine("========================================");
            Console.WriteLine("           GESTION DE PRESTAMOS");
            Console.WriteLine("========================================");
            Console.WriteLine("1. Crear prestamo");
            Console.WriteLine("2. Listar prestamos");
            Console.WriteLine("3. Ver detalle de prestamo");
            Console.WriteLine("4. Registrar devolucion");
            Console.WriteLine("5. Eliminar prestamo");
            Console.WriteLine("0. Volver al menu principal");
            Console.WriteLine("========================================");

            opcion = ReadOption();

            switch (opcion)
            {
                case 1:
                    CreateLoan();
                    break;

                case 2:
                    ListLoansMenu();
                    break;

                case 3:
                    ViewLoanDetail();
                    break;

                case 4:
                    RegisterReturn();
                    break;

                case 5:
                    DeleteLoan();
                    break;

                case 0:
                    Console.WriteLine("Regresando al menu principal...");
                    break;

                default:
                    ShowInvalidOption();
                    break;
            }

        } while (opcion != 0);
    }

    static void CreateLoan()
    {
        MostrarPruebaPrestamo();
    }

    // ==========================================
    // PRUEBAS DEL SERVICIO DE USUARIOS
    // ==========================================

    static void MostrarPruebaUsuarioService()
    {
        UsuarioService servicioUsuarios = new UsuarioService();

        servicioUsuarios.AgregarUsuario(new Usuario(
            "1001001001", "Ana López", "3001234567",
            "ana@email.com", true
        ));

        servicioUsuarios.AgregarUsuario(new Usuario(
            "1002002002", "Carlos Pérez", "3107654321",
            "carlos@email.com", false
        ));

        servicioUsuarios.AgregarUsuario(new Usuario(
            "1003003003", "María Gómez", "3209876543",
            "maria@email.com", true
        ));

        servicioUsuarios.AgregarUsuario(new Usuario(
            "1004004004", "Andrés Rodríguez", "3155555555",
            "andres@email.com", true
        ));

        Console.WriteLine("\n===== PRUEBAS DEL SERVICIO DE USUARIOS =====");

        Console.WriteLine("\n--- Todos los usuarios ---");

        foreach (Usuario usuario in servicioUsuarios.ObtenerTodos())
        {
            Console.WriteLine(usuario.ResumenCorto());
        }

        Console.WriteLine("\n--- Buscar por documento ---");

        Usuario? encontrado =
            servicioUsuarios.BuscarPorDocumento("1001001001");

        Console.WriteLine(
            encontrado?.ResumenCorto() ?? "Usuario no encontrado."
        );

        Console.WriteLine("\n--- Buscar por nombre: Carlos ---");

        foreach (Usuario usuario in servicioUsuarios.BuscarPorNombre("Carlos"))
        {
            Console.WriteLine(usuario.ResumenCorto());
        }

        Console.WriteLine("\n--- Usuarios ordenados por nombre ---");

        foreach (Usuario usuario in servicioUsuarios.OrdenarPorNombre())
        {
            Console.WriteLine(usuario.Nombre);
        }

        Console.WriteLine("\n--- Eliminar usuario ---");

        bool eliminado = servicioUsuarios.EliminarUsuario("1004004004");

        Console.WriteLine(
            eliminado ? "Usuario eliminado correctamente."
                      : "No se encontró el usuario."
        );

        Console.WriteLine(
            $"Total de usuarios después de eliminar: {servicioUsuarios.ObtenerTodos().Count}"
        );
        Console.WriteLine("\n--- ESTADÍSTICAS DE USUARIOS ---");

        Console.WriteLine(
            $"Total de usuarios: {servicioUsuarios.ObtenerTotalUsuarios()}");

        Console.WriteLine(
            $"Usuarios activos: {servicioUsuarios.ContarUsuariosActivos()}");

        Console.WriteLine(
            $"Usuarios inactivos: {servicioUsuarios.ContarUsuariosInactivos()}");
    }

    // LISTAR PRESTAMOS

    static void ListLoansMenu()
    {
        int opcion;

        do
        {
            Console.WriteLine();
            Console.WriteLine("========== LISTAR PRESTAMOS ==========");
            Console.WriteLine("1. Listar todos");
            Console.WriteLine("2. Listar activos");
            Console.WriteLine("3. Listar cerrados");
            Console.WriteLine("0. Volver");

            opcion = ReadOption();

            switch (opcion)
            {
                case 1:
                    ListLoansAll();
                    break;

                case 2:
                    ListLoansActive();
                    break;

                case 3:
                    ListLoansClosed();
                    break;

                case 0:
                    Console.WriteLine("Regresando al menu de prestamos...");
                    break;

                default:
                    ShowInvalidOption();
                    break;
            }

        } while (opcion != 0);
    }

    static void ListLoansAll()
    {
        Console.WriteLine(
            "Se ha seleccionado listar todos los prestamos."
        );
    }

    static void ListLoansActive()
    {
        Console.WriteLine(
            "Se ha seleccionado listar los prestamos activos."
        );
    }

    static void ListLoansClosed()
    {
        Console.WriteLine(
            "Se ha seleccionado listar los prestamos cerrados o devueltos."
        );
    }

    static void ViewLoanDetail()
    {
        Console.WriteLine(
            "Se ha seleccionado consultar el detalle de un prestamo por ID."
        );
    }

    static void RegisterReturn()
    {
        Console.WriteLine(
            "Se ha seleccionado registrar la devolucion de un prestamo."
        );

        Console.WriteLine(
            "Accion prevista: cambiar el estado del prestamo a devuelto."
        );

        Console.WriteLine(
            "Accion prevista: marcar el libro como disponible."
        );
    }

    static void DeleteLoan()
    {
        Console.WriteLine(
            "Se ha seleccionado eliminar un prestamo."
        );

        Console.WriteLine(
            "Regla sugerida: eliminar solo si esta cerrado o fue creado por error."
        );

        Console.WriteLine(
            "Si se elimina un prestamo activo, devolver el libro automaticamente."
        );
    }

    // ==========================================
    // FEATURE: SEARCH AND REPORTS MENU
    // ==========================================

    static void ShowSearchReportsMenu()
    {
        int opcion;

        do
        {
            Console.WriteLine();
            Console.WriteLine("========================================");
            Console.WriteLine("       BUSQUEDAS Y REPORTES");
            Console.WriteLine("========================================");
            Console.WriteLine("1. Buscar libro");
            Console.WriteLine("2. Buscar usuario");
            Console.WriteLine("3. Reportes");
            Console.WriteLine("0. Volver al menu principal");
            Console.WriteLine("========================================");

            opcion = ReadOption();

            switch (opcion)
            {
                case 1:
                    SearchBook();
                    break;

                case 2:
                    SearchUser();
                    break;

                case 3:
                    ShowReportsMenu();
                    break;

                case 0:
                    Console.WriteLine("Regresando al menu principal...");
                    break;

                default:
                    ShowInvalidOption();
                    break;
            }

        } while (opcion != 0);
    }

    // BUSQUEDA DE LIBROS

    static void SearchBook()
    {
        int opcion;

        do
        {
            Console.WriteLine();
            Console.WriteLine("========== BUSCAR LIBRO ==========");
            Console.WriteLine("1. Buscar por titulo");
            Console.WriteLine("2. Buscar por autor");
            Console.WriteLine("3. Buscar por ID / ISBN");
            Console.WriteLine("4. Buscar por categoria");
            Console.WriteLine("0. Volver");

            opcion = ReadOption();

            switch (opcion)
            {
                case 1:
                    SearchBookByTitle();
                    break;

                case 2:
                    SearchBookByAuthor();
                    break;

                case 3:
                    SearchBookByIdIsbn();
                    break;

                case 4:
                    SearchBookByCategory();
                    break;

                case 0:
                    Console.WriteLine("Regresando al menu de busquedas...");
                    break;

                default:
                    ShowInvalidOption();
                    break;
            }

        } while (opcion != 0);
    }

    static void SearchBookByTitle()
    {
        Console.WriteLine(
            "Se ha seleccionado buscar libros por titulo."
        );
    }

    static void SearchBookByAuthor()
    {
        Console.WriteLine(
            "Se ha seleccionado buscar libros por autor."
        );
    }

    static void SearchBookByIdIsbn()
    {
        Console.WriteLine(
            "Se ha seleccionado buscar libros por ID o ISBN."
        );
    }

    static void SearchBookByCategory()
    {
        Console.WriteLine(
            "Se ha seleccionado buscar libros por categoria."
        );
    }

    // BUSQUEDA DE USUARIOS

    static void SearchUser()
    {
        int opcion;

        do
        {
            Console.WriteLine();
            Console.WriteLine("========== BUSCAR USUARIO ==========");
            Console.WriteLine("1. Buscar por nombre");
            Console.WriteLine("2. Buscar por ID / documento");
            Console.WriteLine("0. Volver");

            opcion = ReadOption();

            switch (opcion)
            {
                case 1:
                    SearchUserByName();
                    break;

                case 2:
                    SearchUserById();
                    break;

                case 0:
                    Console.WriteLine("Regresando al menu de busquedas...");
                    break;

                default:
                    ShowInvalidOption();
                    break;
            }

        } while (opcion != 0);
    }

    static void SearchUserByName()
    {
        Console.WriteLine(
            "Se ha seleccionado buscar usuarios por nombre."
        );
    }

    static void SearchUserById()
    {
        Console.WriteLine(
            "Se ha seleccionado buscar usuarios por ID o documento."
        );
    }

    // REPORTES

    static void ShowReportsMenu()
    {
        int opcion;

        do
        {
            Console.WriteLine();
            Console.WriteLine("========== REPORTES ==========");
            Console.WriteLine("1. Prestamos por usuario");
            Console.WriteLine("2. Prestamos por libro");
            Console.WriteLine("3. Prestamos vencidos");
            Console.WriteLine("4. Resumen general de libros");
            Console.WriteLine("0. Volver");

            opcion = ReadOption();

            switch (opcion)
            {
                case 1:
                    ReportByUser();
                    break;

                case 2:
                    ReportByBook();
                    break;

                case 3:
                    ReportOverdue();
                    break;

                case 4:
                    ReportSummary();
                    break;

                case 0:
                    Console.WriteLine("Regresando al menu de busquedas...");
                    break;

                default:
                    ShowInvalidOption();
                    break;
            }

        } while (opcion != 0);
    }

    static void ReportByUser()
    {
        Console.WriteLine(
            "Se ha seleccionado el reporte de prestamos por usuario."
        );
    }

    static void ReportByBook()
    {
        Console.WriteLine(
            "Se ha seleccionado el reporte de prestamos por libro."
        );
    }

    static void ReportOverdue()
    {
        Console.WriteLine(
            "Se ha seleccionado el reporte de prestamos vencidos."
        );
    }

    static void ReportSummary()
    {
        Console.WriteLine(
            "Se ha seleccionado el resumen general de libros."
        );

        Console.WriteLine(
            "El resumen contempla total de libros, disponibles y prestados."
        );
    }

    // ==========================================
    // FEATURE: PERSISTENCE MENU
    // ==========================================

    static void ShowPersistenceMenu()
    {
        int opcion;

        do
        {
            Console.WriteLine();
            Console.WriteLine("========================================");
            Console.WriteLine("             GESTION DE DATOS");
            Console.WriteLine("========================================");
            Console.WriteLine("1. Guardar datos");
            Console.WriteLine("2. Cargar datos");
            Console.WriteLine("3. Reiniciar datos");
            Console.WriteLine("0. Volver al menu principal");
            Console.WriteLine("========================================");

            opcion = ReadOption();

            switch (opcion)
            {
                case 1:
                    SaveData();
                    break;

                case 2:
                    LoadData();
                    break;

                case 3:
                    ConfirmResetData();
                    break;

                case 0:
                    Console.WriteLine("Regresando al menu principal...");
                    break;

                default:
                    ShowInvalidOption();
                    break;
            }

        } while (opcion != 0);
    }

    static void SaveData()
    {
        Console.WriteLine(
            "Se ha seleccionado guardar los datos de la biblioteca."
        );

        Console.WriteLine(
            "La persistencia real no se implementa en esta actividad."
        );
    }

    static void LoadData()
    {
        Console.WriteLine(
            "Se ha seleccionado cargar los datos de la biblioteca."
        );

        Console.WriteLine(
            "La carga real de datos no se implementa en esta actividad."
        );
    }

    static void ConfirmResetData()
    {
        while (true)
        {
            Console.Write(
                "¿Confirma que desea reiniciar los datos? (S/N): "
            );

            string respuesta = (
                Console.ReadLine() ?? string.Empty
            ).Trim();

            if (respuesta.Equals(
                "S", StringComparison.OrdinalIgnoreCase))
            {
                ResetData();
                return;
            }

            if (respuesta.Equals(
                "N", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(
                    "Se ha cancelado el reinicio de datos."
                );

                return;
            }

            Console.WriteLine(
                "Respuesta no valida. Escriba S o N."
            );
        }
    }

    static void ResetData()
    {
        Console.WriteLine(
            "Se ha seleccionado reiniciar los datos de la biblioteca."
        );

        Console.WriteLine(
            "El reinicio real no se implementa en esta actividad."
        );
    }

    // ==========================================
    // FEATURE: EXIT FLOW
    // ==========================================

    static bool ConfirmExitAndSave()
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
                SaveData();

                Console.WriteLine(
                    "Gracias por utilizar el sistema de biblioteca."
                );

                Console.WriteLine("Programa finalizado.");

                return true;
            }

            if (respuesta.Equals(
                "N", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(
                    "Se saldra sin guardar los datos."
                );

                Console.WriteLine(
                    "Gracias por utilizar el sistema de biblioteca."
                );

                Console.WriteLine("Programa finalizado.");

                return true;
            }

            Console.WriteLine(
                "Respuesta no valida. Escriba S o N."
            );
        }
    }

    // ==========================================
    // FUNCIONES AUXILIARES
    // ==========================================

    static int ReadOption()
    {
        Console.Write("Seleccione una opcion: ");

        string entrada = Console.ReadLine() ?? string.Empty;

        if (int.TryParse(entrada, out int opcion))
        {
            return opcion;
        }

        return -1;
    }

    static void ShowInvalidOption()
    {
        Console.WriteLine(
            "Opcion no valida. Intente nuevamente."
        );
    }

    // ==========================================
    // PRUEBAS DE LOS MODELOS DEL DOMINIO
    // ==========================================

    static void MostrarPruebaLibros()
    {
        Libro libro1 = new Libro(
            "ISBN-001",
            "Cien años de soledad",
            "Gabriel García Márquez",
            "Novela",
            1967,
            true
        );

        Libro libro2 = new Libro(
            "ISBN-002",
            "El principito",
            "Antoine de Saint-Exupéry",
            "Literatura",
            1943,
            false
        );

        Console.WriteLine("\n===== PRUEBA DE MODELO LIBRO =====");

        Console.WriteLine("\n--- Resumen de libros ---");
        Console.WriteLine(libro1.ResumenCorto());
        Console.WriteLine(libro2.ResumenCorto());

        Console.WriteLine("\n--- Detalle del primer libro ---");
        Console.WriteLine(libro1.DetalleCompleto());

        Console.WriteLine("\n--- Detalle del segundo libro ---");
        Console.WriteLine(libro2.DetalleCompleto());

        Console.WriteLine("\n--- Disponibilidad ---");
        Console.WriteLine($"Libro 1 disponible: {libro1.Disponible}");
        Console.WriteLine($"Libro 2 disponible: {libro2.Disponible}");

        Console.WriteLine("\n--- Método ToString ---");
        Console.WriteLine(libro1.ToString());
        Console.WriteLine(libro2.ToString());
    }

    static void MostrarPruebaUsuarios()
    {
        Usuario usuario1 = new Usuario(
            "1001001001",
            "Ana López",
            "3001234567",
            "ana@email.com",
            true
        );

        Usuario usuario2 = new Usuario(
            "1002002002",
            "Carlos Pérez",
            "3107654321",
            "carlos@email.com",
            false
        );

        Console.WriteLine("\n===== PRUEBA DE MODELO USUARIO =====");

        Console.WriteLine("\n--- Resumen de usuarios ---");
        Console.WriteLine(usuario1.ResumenCorto());
        Console.WriteLine(usuario2.ResumenCorto());

        Console.WriteLine("\n--- Detalle del primer usuario ---");
        Console.WriteLine(usuario1.DetalleCompleto());

        Console.WriteLine("\n--- Detalle del segundo usuario ---");
        Console.WriteLine(usuario2.DetalleCompleto());

        Console.WriteLine("\n--- Estado de los usuarios ---");
        Console.WriteLine($"Usuario 1 activo: {usuario1.Activo}");
        Console.WriteLine($"Usuario 2 activo: {usuario2.Activo}");

        Console.WriteLine("\n--- Método ToString ---");
        Console.WriteLine(usuario1.ToString());
        Console.WriteLine(usuario2.ToString());
    }

    static void MostrarPruebaPrestamo()
    {
        Prestamo prestamo1 = new Prestamo(
            1,
            "1001001001",
            "ISBN-001",
            DateTime.Today.AddDays(-10),
            DateTime.Today.AddDays(-3),
            null,
            EstadoPrestamo.Vencido
        );

        Console.WriteLine("\n===== PRUEBA DE MODELO PRESTAMO =====");

        Console.WriteLine("\n--- Resumen del préstamo ---");
        Console.WriteLine(prestamo1.ResumenCorto());

        Console.WriteLine("\n--- Detalle completo ---");
        Console.WriteLine(prestamo1.DetalleCompleto());

        Console.WriteLine("\n--- Validación del préstamo ---");
        Console.WriteLine($"Estado: {prestamo1.Estado}");
        Console.WriteLine($"¿Está vencido?: {prestamo1.EstaVencido()}");
        Console.WriteLine($"Días transcurridos: {prestamo1.DiasTranscurridos()}");

        Console.WriteLine("\n--- Método ToString ---");
        Console.WriteLine(prestamo1.ToString());
    }

    // ==========================================
    // PRUEBAS DEL SERVICIO DE LIBROS
    // ==========================================

    static void MostrarPruebaLibroService()
    {
        LibroService servicioLibros = new LibroService();

        // Registrar libros de prueba.
        servicioLibros.AgregarLibro(new Libro(
            "ISBN-S001",
            "El principito",
            "Antoine de Saint-Exupéry",
            "Literatura",
            1943,
            true
        ));

        servicioLibros.AgregarLibro(new Libro(
            "ISBN-S002",
            "Cien años de soledad",
            "Gabriel García Márquez",
            "Novela",
            1967,
            false
        ));

        servicioLibros.AgregarLibro(new Libro(
            "ISBN-S003",
            "La vorágine",
            "José Eustasio Rivera",
            "Novela",
            1924,
            true
        ));

        servicioLibros.AgregarLibro(new Libro(
            "ISBN-S004",
            "Don Quijote de la Mancha",
            "Miguel de Cervantes",
            "Novela",
            1605,
            true
        ));

        Console.WriteLine("\n===== PRUEBAS DEL SERVICIO DE LIBROS =====");

        // Obtener todos los libros.
        Console.WriteLine("\n--- Todos los libros ---");

        foreach (Libro libro in servicioLibros.ObtenerTodos())
        {
            Console.WriteLine(libro.ResumenCorto());
        }

        // Buscar por ISBN.
        Console.WriteLine("\n--- Buscar por ISBN: ISBN-S001 ---");

        Libro? encontrado = servicioLibros.BuscarPorIsbn("ISBN-S001");

        Console.WriteLine(
            encontrado?.ResumenCorto() ?? "Libro no encontrado."
        );

        // Buscar por título.
        Console.WriteLine("\n--- Buscar por título: cien ---");

        foreach (Libro libro in servicioLibros.BuscarPorTitulo("cien"))
        {
            Console.WriteLine(libro.ResumenCorto());
        }

        // Buscar por autor.
        Console.WriteLine("\n--- Buscar por autor: Gabriel ---");

        foreach (Libro libro in servicioLibros.BuscarPorAutor("Gabriel"))
        {
            Console.WriteLine(libro.ResumenCorto());
        }

        // Ordenar por título.
        Console.WriteLine("\n--- Libros ordenados por título ---");

        foreach (Libro libro in servicioLibros.OrdenarPorTitulo())
        {
            Console.WriteLine(libro.Titulo);
        }

        // Ordenar por año.
        Console.WriteLine("\n--- Libros ordenados por año ---");

        foreach (Libro libro in servicioLibros.OrdenarPorAnio())
        {
            Console.WriteLine($"{libro.Anio} - {libro.Titulo}");
        }

        // Eliminar por ISBN.
        Console.WriteLine("\n--- Eliminar libro ISBN-S004 ---");

        bool eliminado = servicioLibros.EliminarLibro("ISBN-S004");

        Console.WriteLine(
            eliminado
                ? "Libro eliminado correctamente."
                : "No se encontró el libro."
        );

        Console.WriteLine(
            $"Total de libros después de eliminar: {servicioLibros.ObtenerTodos().Count}"
        );
        Console.WriteLine("\n--- ESTADISTICAS DE LIBROS ---");

        Console.WriteLine(
            $"Total de libros: {servicioLibros.ObtenerTotalLibros()}");

        Console.WriteLine(
            $"Libros disponibles: {servicioLibros.ContarLibrosDisponibles()}");

        Console.WriteLine(
            $"Libros prestados: {servicioLibros.ContarLibrosPrestados()}");
    }

    static void MostrarPruebaPrestamoService()
    {
        PrestamoService servicioPrestamos = new PrestamoService();

        DateTime hoy = DateTime.Today;

        // Préstamo activo
        Prestamo prestamo1 = new Prestamo(
            1, "1001001001", "ISBN-S001",
            hoy.AddDays(-2), hoy.AddDays(5)
        );

        // Préstamo vencido
        Prestamo prestamo2 = new Prestamo(
            2, "1002002002", "ISBN-S002",
            hoy.AddDays(-10), hoy.AddDays(-5)
        );

        // Préstamo devuelto
        Prestamo prestamo3 = new Prestamo(
            3, "1003003003", "ISBN-S003",
            hoy.AddDays(-20), hoy.AddDays(-6),
            hoy.AddDays(-12), EstadoPrestamo.Devuelto
        );

        servicioPrestamos.AgregarPrestamo(prestamo1);
        servicioPrestamos.AgregarPrestamo(prestamo2);
        servicioPrestamos.AgregarPrestamo(prestamo3);

        Console.WriteLine("\n===== PRUEBAS DEL SERVICIO DE PRESTAMOS =====");

        // Obtener todos
        Console.WriteLine("\n--- Todos los prestamos ---");

        foreach (Prestamo prestamo in servicioPrestamos.ObtenerTodos())
        {
            Console.WriteLine(prestamo.ResumenCorto());
        }

        // Buscar por ID
        Console.WriteLine("\n--- Buscar prestamo por ID: 2 ---");

        Prestamo? encontrado = servicioPrestamos.BuscarPorId(2);

        Console.WriteLine(encontrado != null
            ? encontrado.DetalleCompleto()
            : "Prestamo no encontrado.");

        // Buscar por estado
        Console.WriteLine("\n--- Prestamos devueltos ---");

        foreach (Prestamo prestamo in servicioPrestamos.BuscarPorEstado(
            EstadoPrestamo.Devuelto))
        {
            Console.WriteLine(prestamo.ResumenCorto());
        }

        // Ordenar por fecha limite
        Console.WriteLine("\n--- Prestamos ordenados por fecha limite ---");

        foreach (Prestamo prestamo in servicioPrestamos.OrdenarPorFechaLimite())
        {
            Console.WriteLine(
                $"{prestamo.IdPrestamo} - {prestamo.FechaLimite:dd/MM/yyyy}"
            );
        }

        // KPIs
        Console.WriteLine("\n--- ESTADISTICAS DE PRESTAMOS ---");

        Console.WriteLine(
            $"Total de prestamos: {servicioPrestamos.ObtenerTotalPrestamos()}");

        Console.WriteLine(
            $"Prestamos activos: {servicioPrestamos.ContarPrestamosActivos()}");

        Console.WriteLine(
            $"Prestamos vencidos: {servicioPrestamos.ContarPrestamosVencidos()}");

        Console.WriteLine(
            $"Prestamos devueltos: {servicioPrestamos.ContarPrestamosDevueltos()}");

        Console.WriteLine(
            $"Promedio de dias: {servicioPrestamos.ObtenerPromedioDiasPrestamo():F2}");

        // Eliminar
        Console.WriteLine("\n--- Eliminar prestamo con ID 3 ---");

        bool eliminado = servicioPrestamos.EliminarPrestamo(3);

        Console.WriteLine(eliminado
            ? "Prestamo eliminado correctamente."
            : "No se encontro el prestamo.");

        Console.WriteLine(
            $"Total despues de eliminar: {servicioPrestamos.ObtenerTotalPrestamos()}");
    }
    static void MostrarComparacionArrayList()
    {
        Console.WriteLine("\n===== COMPARACION ARRAY VS LIST =====");

        // ARRAY: tiene un tamaño fijo.
        string[] librosArray = new string[2];

        librosArray[0] = "El principito";
        librosArray[1] = "La voragine";

        Console.WriteLine("\n--- Array ---");

        foreach (string libro in librosArray)
        {
            Console.WriteLine(libro);
        }

        Console.WriteLine($"Cantidad de elementos: {librosArray.Length}");

        // LIST: permite agregar y eliminar elementos dinamicamente.
        List<string> librosList = new List<string>();

        librosList.Add("El principito");
        librosList.Add("La voragine");
        librosList.Add("Cien años de soledad");

        Console.WriteLine("\n--- List ---");

        foreach (string libro in librosList)
        {
            Console.WriteLine(libro);
        }

        Console.WriteLine($"Cantidad de elementos: {librosList.Count}");

        // Comparación.
        Console.WriteLine("\n--- Diferencias ---");
        Console.WriteLine("Array: tiene un tamaño fijo.");
        Console.WriteLine("List: permite agregar y eliminar elementos.");
    }


}
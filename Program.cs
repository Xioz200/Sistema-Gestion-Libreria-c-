
using System;

class Program
{
    // ==========================================
    // PUNTO DE ENTRADA
    // ==========================================

    static void Main()
    {
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
        Console.WriteLine(
            "Se ha seleccionado listar todos los libros."
        );
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
        Console.WriteLine(
            "Se ha seleccionado listar los usuarios."
        );
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
        Console.WriteLine(
            "Se ha seleccionado crear un prestamo."
        );

        Console.WriteLine("Validaciones sugeridas:");
        Console.WriteLine("- El usuario debe existir y estar activo.");
        Console.WriteLine("- El libro debe existir y estar disponible.");
        Console.WriteLine("- Verificar el maximo de prestamos activos por usuario.");
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
}

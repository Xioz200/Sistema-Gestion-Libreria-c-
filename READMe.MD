# Sistema de Gestión de Biblioteca en C#

Aplicación de consola desarrollada en C# para representar un sistema de gestión de biblioteca. El proyecto se desarrolla como una aplicación monolítica y permite organizar las opciones relacionadas con libros, usuarios, préstamos, búsquedas, reportes y gestión de datos.

## Objetivo

Construir progresivamente un sistema de gestión de biblioteca aplicando fundamentos de programación en C#, métodos, estructuras de control, programación orientada a objetos, operaciones CRUD, manejo de excepciones y persistencia de datos.

## Tecnologías

- **Lenguaje:** C#
- **Plataforma:** .NET
- **Tipo de aplicación:** Consola
- **Arquitectura:** Monolítica
- **Control de versiones:** Git
- **Repositorio remoto:** GitHub

## Funcionalidades del proyecto

### 1. Libros
- Registrar libros.
- Listar todos los libros.
- Consultar libros disponibles y prestados.
- Consultar el detalle de un libro.
- Actualizar título, autor, año o categoría.
- Eliminar libros.

### 2. Usuarios
- Registrar y listar usuarios.
- Consultar el detalle de un usuario.
- Actualizar nombre y contacto.
- Activar o desactivar usuarios.
- Eliminar usuarios.

### 3. Préstamos
- Crear préstamos.
- Listar todos los préstamos.
- Consultar préstamos activos y cerrados.
- Consultar el detalle de un préstamo.
- Registrar devoluciones.
- Eliminar préstamos.

### 4. Búsquedas y reportes
- Buscar libros por título, autor, identificador o categoría.
- Buscar usuarios por nombre o documento.
- Consultar préstamos por usuario o libro.
- Consultar préstamos vencidos.
- Consultar un resumen general de libros disponibles y prestados.

### 5. Gestión de datos
- Guardar datos.
- Cargar datos.
- Reiniciar datos con confirmación.

## Estado actual

**Parte 1: estructura de menús y funciones.**

En esta etapa se implementan el menú principal, los submenús, la navegación entre opciones y las funciones que muestran mensajes descriptivos.

Las operaciones CRUD, las validaciones de negocio, las clases del dominio y la persistencia todavía no están implementadas. Se incorporarán progresivamente en las siguientes etapas del proyecto.

## Requisitos

- Tener instalado el SDK de .NET compatible con el proyecto.
- Tener instalado Git.
- Contar con un editor de código, como Visual Studio Code.

## Ejecución

Clona el repositorio desde GitHub y entra en la carpeta del proyecto. Después ejecuta:

```bash
dotnet restore
dotnet run
```

Los comandos deben ejecutarse desde el directorio que contiene el archivo `Biblioteca.csproj`.

Para comprobar la versión del SDK instalado:

```bash
dotnet --version
```

## Estructura del proyecto

```text
Gestion-Libreria/
├── Biblioteca.csproj
├── Program.cs
├── README.md
├── .gitignore
└── obj/ y bin/ (archivos generados por .NET)
```

La estructura podrá ampliarse a medida que se incorporen las clases y los servicios de gestión.

## Flujo de trabajo con Git

Se utilizan las siguientes ramas:

- `main`: versión estable del proyecto.
- `develop`: integración de funcionalidades.
- `feat/menu-principal`: desarrollo del menú principal y sus submenús.

Las nuevas funcionalidades podrán desarrollarse en ramas `feat/` independientes e integrarse posteriormente en `develop`.

## Autor

Proyecto académico desarrollado como ejercicio de sintaxis y fundamentos de programación en C#.
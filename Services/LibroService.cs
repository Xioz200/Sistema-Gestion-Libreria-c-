
using System;
using System.Collections.Generic;
using System.Linq;

public class LibroService
{
    // Colección dinámica de libros.
    private readonly List<Libro> libros = new List<Libro>();

    // ==========================================
    // AGREGAR LIBRO
    // ==========================================

    public void AgregarLibro(Libro libro)
    {
        if (libro == null)
        {
            throw new ArgumentNullException(nameof(libro));
        }

        bool existe = libros.Any(
            l => l.Isbn.Equals(libro.Isbn, StringComparison.OrdinalIgnoreCase)
        );

        if (existe)
        {
            throw new InvalidOperationException(
                "Ya existe un libro registrado con ese ISBN."
            );
        }

        libros.Add(libro);
    }

    // ==========================================
    // ELIMINAR LIBRO POR ISBN
    // ==========================================

    public bool EliminarLibro(string isbn)
    {
        Libro? libro = BuscarPorIsbn(isbn);

        if (libro == null)
        {
            return false;
        }

        return libros.Remove(libro);
    }

    // ==========================================
    // OBTENER TODOS LOS LIBROS
    // ==========================================

    public List<Libro> ObtenerTodos()
    {
        return new List<Libro>(libros);
    }

    // ==========================================
    // BUSCAR POR ISBN
    // ==========================================

    public Libro? BuscarPorIsbn(string isbn)
    {
        return libros.FirstOrDefault(
            l => l.Isbn.Equals(isbn, StringComparison.OrdinalIgnoreCase)
        );
    }

    // ==========================================
    // BUSCAR POR TITULO
    // ==========================================

    public List<Libro> BuscarPorTitulo(string titulo)
    {
        return libros
            .Where(l => l.Titulo.Contains(
                titulo,
                StringComparison.OrdinalIgnoreCase))
            .ToList();
    }

    // ==========================================
    // BUSCAR POR AUTOR
    // ==========================================

    public List<Libro> BuscarPorAutor(string autor)
    {
        return libros
            .Where(l => l.Autor.Contains(
                autor,
                StringComparison.OrdinalIgnoreCase))
            .ToList();
    }

    // ==========================================
    // ORDENAR POR TITULO
    // ==========================================

    public List<Libro> OrdenarPorTitulo()
    {
        return libros
            .OrderBy(l => l.Titulo)
            .ToList();
    }

    // ==========================================
    // ORDENAR POR AÑO
    // ==========================================

    public List<Libro> OrdenarPorAnio()
    {
        return libros
            .OrderBy(l => l.Anio)
            .ToList();
    }
        // ==========================================
    // ESTADÍSTICAS (KPIs)
    // ==========================================

    // Obtener la cantidad total de libros registrados.
    public int ObtenerTotalLibros()
    {
        return libros.Count;
    }

    // Contar los libros disponibles.
    public int ContarLibrosDisponibles()
    {
        return libros.Count(l => l.Disponible);
    }

    // Contar los libros que están prestados.
    public int ContarLibrosPrestados()
    {
        return libros.Count(l => !l.Disponible);
    }
}

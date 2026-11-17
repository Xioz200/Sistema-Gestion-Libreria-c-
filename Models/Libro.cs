
using System;

public class Libro
{
    // ==========================================
    // PROPIEDADES
    // ==========================================

    public string Isbn { get; set; }
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string Categoria { get; set; }
    public int Anio { get; set; }
    public bool Disponible { get; set; }

    // ==========================================
    // CONSTRUCTOR VACIO
    // ==========================================

    public Libro()
    {
        Isbn = string.Empty;
        Titulo = string.Empty;
        Autor = string.Empty;
        Categoria = string.Empty;
        Anio = 0;
        Disponible = true;
    }

    // ==========================================
    // CONSTRUCTOR COMPLETO
    // ==========================================

    public Libro(
        string isbn,
        string titulo,
        string autor,
        string categoria,
        int anio,
        bool disponible = true)
    {
        Isbn = isbn;
        Titulo = titulo;
        Autor = autor;
        Categoria = categoria;
        Anio = anio;
        Disponible = disponible;
    }

    // ==========================================
    // RESUMEN CORTO
    // ==========================================

    public string ResumenCorto()
    {
        return $"ISBN: {Isbn} | Titulo: {Titulo} | Autor: {Autor}";
    }

    // ==========================================
    // DETALLE COMPLETO
    // ==========================================

    public string DetalleCompleto()
    {
        string estado = Disponible ? "Disponible" : "Prestado";

        return
            $"ISBN: {Isbn}\n" +
            $"Titulo: {Titulo}\n" +
            $"Autor: {Autor}\n" +
            $"Categoria: {Categoria}\n" +
            $"Anio de publicacion: {Anio}\n" +
            $"Estado: {estado}";
    }

    // ==========================================
    // SOBRESCRITURA DE TOSTRING
    // ==========================================

    public override string ToString()
    {
        return ResumenCorto();
    }
}

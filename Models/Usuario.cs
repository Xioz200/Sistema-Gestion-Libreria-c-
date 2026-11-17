
using System;

public class Usuario
{
    // ==========================================
    // PROPIEDADES
    // ==========================================

    public string Documento { get; set; }
    public string Nombre { get; set; }
    public string Telefono { get; set; }
    public string Email { get; set; }
    public bool Activo { get; set; }

    // ==========================================
    // CONSTRUCTOR VACIO
    // ==========================================

    public Usuario()
    {
        Documento = string.Empty;
        Nombre = string.Empty;
        Telefono = string.Empty;
        Email = string.Empty;
        Activo = true;
    }

    // ==========================================
    // CONSTRUCTOR COMPLETO
    // ==========================================

    public Usuario(
        string documento,
        string nombre,
        string telefono,
        string email,
        bool activo = true)
    {
        Documento = documento;
        Nombre = nombre;
        Telefono = telefono;
        Email = email;
        Activo = activo;
    }

    // ==========================================
    // RESUMEN CORTO
    // ==========================================

    public string ResumenCorto()
    {
        string estado = Activo ? "Activo" : "Inactivo";

        return $"Documento: {Documento} | Nombre: {Nombre} | Estado: {estado}";
    }

    // ==========================================
    // DETALLE COMPLETO
    // ==========================================

    public string DetalleCompleto()
    {
        string estado = Activo ? "Activo" : "Inactivo";

        return
            $"Documento: {Documento}\n" +
            $"Nombre: {Nombre}\n" +
            $"Telefono: {Telefono}\n" +
            $"Correo electronico: {Email}\n" +
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

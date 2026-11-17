
using System;

public class Prestamo
{
    // ==========================================
    // PROPIEDADES
    // ==========================================

    public int IdPrestamo { get; set; }

    public string IdUsuario { get; set; }

    public string IdLibro { get; set; }

    public DateTime FechaPrestamo { get; set; }

    public DateTime FechaLimite { get; set; }

    public DateTime? FechaDevolucion { get; set; }

    public EstadoPrestamo Estado { get; set; }

    // ==========================================
    // CONSTRUCTOR VACIO
    // ==========================================

    public Prestamo()
    {
        IdPrestamo = 0;
        IdUsuario = string.Empty;
        IdLibro = string.Empty;

        FechaPrestamo = DateTime.MinValue;
        FechaLimite = DateTime.MinValue;
        FechaDevolucion = null;

        Estado = EstadoPrestamo.Activo;
    }

    // ==========================================
    // CONSTRUCTOR COMPLETO
    // ==========================================

    public Prestamo(
        int idPrestamo,
        string idUsuario,
        string idLibro,
        DateTime fechaPrestamo,
        DateTime fechaLimite,
        DateTime? fechaDevolucion = null,
        EstadoPrestamo estado = EstadoPrestamo.Activo)
    {
        IdPrestamo = idPrestamo;
        IdUsuario = idUsuario;
        IdLibro = idLibro;

        FechaPrestamo = fechaPrestamo;
        FechaLimite = fechaLimite;
        FechaDevolucion = fechaDevolucion;

        Estado = estado;
    }

    // ==========================================
    // COMPROBAR SI EL PRESTAMO ESTA VENCIDO
    // ==========================================

    public bool EstaVencido()
    {
        if (FechaPrestamo == DateTime.MinValue ||
            FechaLimite == DateTime.MinValue ||
            FechaDevolucion.HasValue)
        {
            return false;
        }

        return DateTime.Today > FechaLimite.Date;
    }

    // ==========================================
    // CALCULAR DIAS TRANSCURRIDOS
    // ==========================================

    public int DiasTranscurridos()
    {
        if (FechaPrestamo == DateTime.MinValue)
        {
            return 0;
        }

        DateTime fechaFinal = FechaDevolucion ?? DateTime.Now;

        return Math.Max(
            0,
            (fechaFinal.Date - FechaPrestamo.Date).Days
        );
    }

    // ==========================================
    // RESUMEN CORTO
    // ==========================================

    public string ResumenCorto()
    {
        return
            $"Prestamo: {IdPrestamo} | " +
            $"Usuario: {IdUsuario} | " +
            $"Libro: {IdLibro} | " +
            $"Estado: {Estado}";
    }

    // ==========================================
    // DETALLE COMPLETO
    // ==========================================

    public string DetalleCompleto()
    {
        string fechaDevolucion = FechaDevolucion.HasValue
            ? FechaDevolucion.Value.ToString("dd/MM/yyyy")
            : "Pendiente";

        string vencido = EstaVencido() ? "Si" : "No";

        return
            $"ID del prestamo: {IdPrestamo}\n" +
            $"Documento del usuario: {IdUsuario}\n" +
            $"ISBN del libro: {IdLibro}\n" +
            $"Fecha del prestamo: {FechaPrestamo:dd/MM/yyyy}\n" +
            $"Fecha limite: {FechaLimite:dd/MM/yyyy}\n" +
            $"Fecha de devolucion: {fechaDevolucion}\n" +
            $"Estado: {Estado}\n" +
            $"Esta vencido: {vencido}\n" +
            $"Dias transcurridos: {DiasTranscurridos()}";
    }

    // ==========================================
    // SOBRESCRITURA DE TOSTRING
    // ==========================================

    public override string ToString()
    {
        return ResumenCorto();
    }
}

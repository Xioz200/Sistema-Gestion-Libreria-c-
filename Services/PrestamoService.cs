
using System;
using System.Collections.Generic;
using System.Linq;

public class PrestamoService
{
    private readonly List<Prestamo> prestamos = new List<Prestamo>();

    // AGREGAR PRESTAMO
    public void AgregarPrestamo(Prestamo prestamo)
    {
        if (prestamo == null)
            throw new ArgumentNullException(nameof(prestamo));

        bool existe = prestamos.Any(
            p => p.IdPrestamo == prestamo.IdPrestamo
        );

        if (existe)
            throw new InvalidOperationException(
                "Ya existe un préstamo con ese ID."
            );

        prestamos.Add(prestamo);
    }

    // ELIMINAR PRESTAMO
    public bool EliminarPrestamo(int idPrestamo)
    {
        Prestamo? prestamo = BuscarPorId(idPrestamo);

        if (prestamo == null)
            return false;

        return prestamos.Remove(prestamo);
    }

    // OBTENER TODOS LOS PRESTAMOS
    public List<Prestamo> ObtenerTodos()
    {
        return new List<Prestamo>(prestamos);
    }

    // BUSCAR POR ID
    public Prestamo? BuscarPorId(int idPrestamo)
    {
        return prestamos.FirstOrDefault(
            p => p.IdPrestamo == idPrestamo
        );
    }

    // BUSCAR POR ESTADO
    public List<Prestamo> BuscarPorEstado(EstadoPrestamo estado)
    {
        return prestamos.Where(
            p => p.Estado == estado
        ).ToList();
    }

    // ORDENAR POR FECHA LIMITE
    public List<Prestamo> OrdenarPorFechaLimite()
    {
        return prestamos.OrderBy(
            p => p.FechaLimite
        ).ToList();
    }

    // KPI: TOTAL DE PRESTAMOS
    public int ObtenerTotalPrestamos()
    {
        return prestamos.Count;
    }

    // KPI: PRESTAMOS ACTIVOS
    public int ContarPrestamosActivos()
    {
        return prestamos.Count(
            p => p.Estado == EstadoPrestamo.Activo && !p.EstaVencido()
        );
    }

    // KPI: PRESTAMOS VENCIDOS
    public int ContarPrestamosVencidos()
    {
        return prestamos.Count(
            p => p.Estado == EstadoPrestamo.Vencido ||
                 (p.Estado == EstadoPrestamo.Activo && p.EstaVencido())
        );
    }

    // KPI: PRESTAMOS DEVUELTOS
    public int ContarPrestamosDevueltos()
    {
        return prestamos.Count(
            p => p.Estado == EstadoPrestamo.Devuelto
        );
    }

    // KPI: PROMEDIO DE DIAS DE PRESTAMO
    public double ObtenerPromedioDiasPrestamo()
    {
        if (prestamos.Count == 0)
            return 0;

        return prestamos.Average(
            p => p.DiasTranscurridos()
        );
    }
}

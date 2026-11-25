
using System;
using System.Collections.Generic;
using System.Linq;

public class UsuarioService
{
    // Colección dinámica que almacena los usuarios.
    private readonly List<Usuario> usuarios = new List<Usuario>();

    // ==========================================
    // AGREGAR USUARIO
    // ==========================================

    public void AgregarUsuario(Usuario usuario)
    {
        if (usuario == null)
        {
            throw new ArgumentNullException(nameof(usuario));
        }

        bool existe = usuarios.Any(
            u => u.Documento.Equals(
                usuario.Documento,
                StringComparison.OrdinalIgnoreCase
            )
        );

        if (existe)
        {
            throw new InvalidOperationException(
                "Ya existe un usuario registrado con ese documento."
            );
        }

        usuarios.Add(usuario);
    }

    // ==========================================
    // ELIMINAR USUARIO
    // ==========================================

    public bool EliminarUsuario(string documento)
    {
        Usuario? usuario = BuscarPorDocumento(documento);

        if (usuario == null)
        {
            return false;
        }

        return usuarios.Remove(usuario);
    }

    // ==========================================
    // OBTENER TODOS LOS USUARIOS
    // ==========================================

    public List<Usuario> ObtenerTodos()
    {
        return new List<Usuario>(usuarios);
    }

    // ==========================================
    // BUSCAR POR DOCUMENTO
    // ==========================================

    public Usuario? BuscarPorDocumento(string documento)
    {
        return usuarios.FirstOrDefault(
            u => u.Documento.Equals(
                documento,
                StringComparison.OrdinalIgnoreCase
            )
        );
    }

    // ==========================================
    // BUSCAR POR NOMBRE
    // ==========================================

    public List<Usuario> BuscarPorNombre(string nombre)
    {
        return usuarios
            .Where(u => u.Nombre.Contains(
                nombre,
                StringComparison.OrdinalIgnoreCase
            ))
            .ToList();
    }

    // ==========================================
    // ORDENAR POR NOMBRE
    // ==========================================

    public List<Usuario> OrdenarPorNombre()
    {
        return usuarios
            .OrderBy(u => u.Nombre)
            .ToList();
    }

    public int ObtenerTotalUsuarios()
    {
        return usuarios.Count;
    }

    public int ContarUsuariosActivos()
    {
        return usuarios.Count(u => u.Activo);
    }

    public int ContarUsuariosInactivos()
    {
        return usuarios.Count(u => !u.Activo);
    }

}
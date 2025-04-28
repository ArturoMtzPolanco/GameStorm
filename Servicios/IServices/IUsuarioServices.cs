using GameStorm.Models.Domain;

namespace GameStorm.Servicios.IServices
{
    public interface IUsuarioServices
    {
        List<Usuario> ObtenerUsuario();
        Usuario ObtenerPorId(int id);
        void AgregarUsuario(Usuario usuario);
        void ActualizarUsuario(Usuario usuario);
        void EliminarUsuario(int id);
    }
}

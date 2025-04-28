using GameStorm.Models.Domain;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameStorm.Models.Domain
{
    public class Usuario
    {
        [Key]
        public int PkUsuario { get; set; }

        public string Nombre { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        [ForeignKey("Roles")]
        public int FkRol { get; set; }

        public Rol? Roles { get; set; }
    }
}

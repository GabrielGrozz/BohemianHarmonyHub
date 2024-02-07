using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BohemianHarmonyHub.Models
{
    public class BandMember
    {
        [Key]
        public int BandMemberId { get; set; }

        [Required(ErrorMessage = "O nome do membro é obrigatório")]
        [StringLength(100, ErrorMessage = "O nome do membro não pode ultrapassar 100 caracteres")]
        public string? Name { get; set; }
        public string? Role { get; set; }

        public int BandId { get; set; }

        [JsonIgnore]
        public Band? Band { get; set; }
    }
}

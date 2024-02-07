using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BohemianHarmonyHub.Models
{
    public class Album
    {
        [Key]
        public int AlbumId { get; set; }

        [Required(ErrorMessage = "O título do álbum é obrigatório")]
        [StringLength(150, ErrorMessage = "O título do álbum não pode ultrapassar 150 caracteres")]
        public string? Title { get; set; }

        [Range(1700, 2100, ErrorMessage = "Por favor, insira um ano válido")]
        public int ReleaseYear { get; set; }

        public int BandId { get; set; }

        [JsonIgnore]
        public Band? Band { get; set; }
    }
}

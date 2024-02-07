using System.ComponentModel.DataAnnotations;

namespace BohemianHarmonyHub.Models
{
    public class Band
    {
        [Key]
        public int BandId { get; set; }

        [Required(ErrorMessage = "O nome da banda é obrigatório")]
        [StringLength(150, ErrorMessage = "O nome da banda não pode ultrapassar 150 caracteres")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "O gênero musical da banda é obrigatório")]
        [StringLength(100, ErrorMessage = "O gênero musical não pode ultrapassar 100 caracteres")]
        public string? Genre { get; set; }

        [StringLength(100, ErrorMessage = "O país de origem não pode ultrapassar 100 caracteres")]
        public string? CountryOfOrigin { get; set; }

        [Required(ErrorMessage = "O biográfia da banda é obrigatória")]
        [StringLength(1000, ErrorMessage = "A biografia não pode ultrapassar 1000 caracteres")]
        public string? BandBiography { get; set; }

        public ICollection<BandMember>? BandMembers { get; set; }
        public ICollection<Album>? Discography { get; set; }

    }
}

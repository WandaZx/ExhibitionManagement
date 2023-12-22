using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Picasso.Models.DTOs.Curation
{
    public class ApplyDto
    {
        public string MemberName { get; set; }

        public string MemberPhone { get; set; }

        public string MemberEmail { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "最多{1}字元")]
        public string ExhibitionName { get; set; }

        [Required]
        [BindRequired]
        public Guid SpaceId { get; set; }

        [Required]
        public string ExhibitionType { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "最多{1}字元")]
        public string ExhibitionDescription { get; set; }

        public string Image { get; set; }

        [NotMapped]
        [Required]
        public IFormFile ImageFile { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "最多{1}字元")]
        public string Organizer { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "最多{1}字元")]
        public string CoOrganizer { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        public string ExhibitionStatus { get; set; } 
    }
}

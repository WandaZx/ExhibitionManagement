using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Picasso.Models
{
    public class Spaces
    {
        [Key]
        [DisplayName("展場編號")]
        public Guid SpaceId { get; set; }

        [DisplayName("展場名稱")]
        public string SpaceName { get; set; }

        [DisplayName("展場地點")]
        public string SpaceLocation { get; set; }

        [DisplayName("展場容納人數")]
        public int SpaceCapacity { get; set; }

        [DisplayName("展場描述")]
        public string SpaceDescription { get; set; }

        [DisplayName("展場狀態")]
        public bool SpaceStatus { get; set; }

        public DateTime CreateDate { get; set; }
    }
}

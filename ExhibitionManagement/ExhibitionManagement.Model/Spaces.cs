using System.ComponentModel;

namespace ExhibitionManagement.Model
{
    class Spaces
    {
        [DisplayName("展場編號")]
        public int SpaceId { get; set; }

        [DisplayName("展場名稱")]
        public string SpaceName { get; set; }

        [DisplayName("展場地點")]
        public string SpaceLocation { get; set; }

        [DisplayName("展場容納人數")]
        public string SpaceCapacity { get; set; }

        [DisplayName("展場描述")]
        public string SpaceDescription { get; set; }

        [DisplayName("展場狀態")]
        public bool SpaceStatus { get; set; }
    }
}

using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ExhibitionManagement.Model
{
    class Exhibitions
    {
        [DisplayName("展覽編號")]
        public int ExhibitionId { get; set; }

        [DisplayName("展場編號")]
        public int SpaceId { get; set; }

        [DisplayName("會員編號")]
        public int MemberId { get; set; }

        [DisplayName("展覽名稱")]
        public string ExhibitionName { get; set; }

        [DisplayName("展覽類型")]
        public string ExhibitionType { get; set; }

        [DisplayName("開始日期")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }

        [DisplayName("結束日期")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }

        [DisplayName("主辦單位")]
        public string Organizer { get; set; }

        [DisplayName("協辦單位")]
        public string CoOrganizer { get; set; }

        [DisplayName("展覽描述")]
        public string ExhibitionDescription { get; set; }

        [DisplayName("展覽狀態")]
        public string ExhibitionStatus { get; set; }

        [DisplayName("展覽海報")]
        public string Image { get; set; }
    }
}

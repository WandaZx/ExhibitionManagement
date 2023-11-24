using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ExhibitionManagement.Model
{
    class ExhibitionApply
    {
        [DisplayName("會員編號")]
        public int ApplyId { get; set; }

        [DisplayName("會員編號")]
        public int MemberId { get; set; }

        [DisplayName("展覽編號")]
        public int ExhibitionId { get; set; }

        [DisplayName("報名日期")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime ApplyDate { get; set; }

        [DisplayName("報名時段")]
        public bool ApplyTime { get; set; }

        [DisplayName("報名狀態")]
        public bool ApplyStatus { get; set; }
    }
}

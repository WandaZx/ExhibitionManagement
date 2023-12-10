using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Picasso.Model
{
    public class ExhibitionApply
    {
        [Key]
        [DisplayName("會員編號")]
        public Guid ApplyId { get; set; }

        //[DisplayName("會員編號")]
        //public Guid MemberId { get; set; }

        //[DisplayName("展覽編號")]
        //public Guid ExhibitionId { get; set; }

        [DisplayName("報名日期")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime ApplyDate { get; set; }

        [DisplayName("報名時段")]
        public bool ApplyTime { get; set; }

        [DisplayName("報名狀態")]
        public bool ApplyStatus { get; set; }

        public DateTime CreateDate { get; set; }
    }
}

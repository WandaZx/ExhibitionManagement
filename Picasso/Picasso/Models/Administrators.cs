using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Picasso.Model
{
    public class Administrators
    {
        [Key]
        [DisplayName("管理員編號")]
        public Guid AdministratorId { get; set; }

        [DisplayName("管理員帳號")]
        public string AdministratorAccount { get; set; }

        [DisplayName("管理員密碼")]
        public string AdministratorPassword { get; set; }

        [DisplayName("管理員姓名")]
        public string AdministratorName { get; set; }

        [DisplayName("手機密碼")]
        public string AdministratorPhone { get; set; }

        [DisplayName("管理員信箱")]
        public string AdministratorEmail { get; set; }

        public DateTime CreateDate { get; set; }
    }
}

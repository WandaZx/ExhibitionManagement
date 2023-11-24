using System.ComponentModel;

namespace ExhibitionManagement.Model
{
    public class Members
    {
        [DisplayName("會員編號")]
        public int MemberId { get; set; }

        [DisplayName("會員帳號")]
        public string MemberAccount { get; set; }

        [DisplayName("會員密碼")]
        public string MemberPassword { get; set; }

        [DisplayName("會員姓名")]
        public string MemberName { get; set; }

        [DisplayName("會員身分")]
        public string MemberIdentity { get; set; }

        [DisplayName("手機號碼")]
        public string MemberPhone { get; set; }

        [DisplayName("會員信箱")]
        public string MemberEmail { get; set; }
    }
}
    
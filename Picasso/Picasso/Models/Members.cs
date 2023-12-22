using System.ComponentModel.DataAnnotations;

namespace Picasso.Model
{
    public class Members
    {
        [Key]
        public Guid MemberId { get; set; }

        public string MemberAccount { get; set; }

        public string MemberPassword { get; set; }

        public string MemberName { get; set; }

        public string MemberIdentity { get; set; }

        public string MemberPhone { get; set; }

        public string MemberEmail { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
    
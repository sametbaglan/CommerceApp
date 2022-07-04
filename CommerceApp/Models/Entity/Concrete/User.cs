using CommerceApp.Models.Entity.Abstract;

namespace CommerceApp.Models.Entity.Concrete
{
    public class User:BaseEntity
    {
        public int id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public userRole roleid { get; set; }

    }
}

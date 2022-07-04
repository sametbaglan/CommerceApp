using CommerceApp.Models.Entity.Abstract;
using System.Collections.Generic;

namespace CommerceApp.Models.Entity.Concrete
{
    public class userRole:BaseEntity
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<User>  Users{ get; set; }
    }
}

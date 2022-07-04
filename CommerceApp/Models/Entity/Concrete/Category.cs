using CommerceApp.Models.Entity.Abstract;
using System.Collections.Generic;

namespace CommerceApp.Models.Entity.Concrete
{
    public class Category : BaseEntity
    {
        public int id { get; set; }
        public string name { get; set; }
        public int? parentId { get; set; }
        public List<SubCategory> subCategories { get; set; }
    }
 

    public class SubCategory : BaseEntity
    {
        public int id { get; set; }
        public string name { get; set; }
        public int? parentId { get; set; }
        public List<SubCategory> subCategories { get; set; }
    }
}

using CommerceApp.Models.Entity.Abstract;

namespace CommerceApp.Models.Entity.Concrete
{
    public class ProductAttributeValue:BaseEntity
    {
        public int id { get; set; }
        public string name { get; set; }
        public int varyantid { get; set; }
        public int productid { get; set; }
        public int stock { get; set; }


    }
}

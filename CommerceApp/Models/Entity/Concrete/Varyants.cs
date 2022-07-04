using CommerceApp.Models.Entity.Abstract;

namespace CommerceApp.Models.Entity.Concrete
{
    public class Varyants : BaseEntity
    {
        public int id { get; set; }
        public int varyantid { get; set; }
        public string varyantname { get; set; }
        public int productid { get; set; }
    }
}

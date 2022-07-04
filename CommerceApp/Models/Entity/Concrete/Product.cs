using CommerceApp.Models.Entity.Abstract;
using System.Collections.Generic;

namespace CommerceApp.Models.Entity.Concrete
{
    public class Product : BaseEntity
    {
        public int id { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public decimal reducedprice { get; set; }
        public int stock { get; set; }
        public int categoryid { get; set; }
        public string descriptions { get; set; }
        public string modelcode { get; set; }
        public string brand { get; set; }
        public string imageUrl { get; set; }

    }
}

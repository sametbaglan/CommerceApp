using CommerceApp.Models.Entity;
using CommerceApp.Models.Entity.Concrete;
using System.Collections.Generic;

namespace CommerceApp.Models
{
    public class AllLayoutModel
    {
        string layout1 = "~/Views/Shared/_Layout.cshtml";
        string layout2 = "~/Views/Shared/_Layoutgasel.cshtml";
        public AllLayoutModel()
        {
            if(string.IsNullOrEmpty(Layout))
                Layout = layout2;
        }
        public List<ProductAttributeValue> productAttributeValues { get; set; }
        public List<Product> Products { get; set; }
        public string Layout { get; set; }
        public List<Attribute> Listattributes { get; set; }
        public List<AttributeValues> ListattributeValues { get; set; }
        public Category category { get; set; }
        public List<Category> Categories{ get; set; }
        public categoryAttirbute categoryAttirbute { get; set; }
        public Attribute attribute { get; set; }
        public AttributeValues attributeValue { get; set; }
        public Product product { get; set; }
        public AtttibutevaluesViewModel atttibutevaluesViewModel{ get; set; }

    }
}

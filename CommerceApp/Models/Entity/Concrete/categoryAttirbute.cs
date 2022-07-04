using CommerceApp.Models.Entity.Abstract;
using System.Collections.Generic;

namespace CommerceApp.Models.Entity.Concrete
{
    public class categoryAttirbute : BaseEntity
    {
        public int id { get; set; }
        public bool allowCustom { get; set; }
        public Attribute attribute { get; set; }
        public List<AttributeValues> attributeValues { get; set; }
        public int categoryId { get; set; }
        public bool required { get; set; }
        public bool varianter { get; set; }
        public bool slicer { get; set; }
    }
  
    public class Attribute : BaseEntity
    {
        public int id { get; set; }
        public string name { get; set; }
        public int attirbuteid { get; set; }
        public List<AttributeValues> attributeValues { get; set; }
    }

    public class AttributeValues : BaseEntity
    {
        public int id { get; set; }
        public string name { get; set; }
        public int categoryAttirbuteid { get; set; }
        public int Attributeid { get; set; }
      
    }

}

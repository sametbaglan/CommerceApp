﻿using System.Collections.Generic;

namespace CommerceApp.Models
{
    public class trendyol
    {
        public class Attribute
        {
            public int id { get; set; }
            public string name { get; set; }
        }

        public class AttributeValue
        {
            public int id { get; set; }
            public string name { get; set; }
        }

        public class CategoryAttribute
        {
            public bool allowCustom { get; set; }
            public Attribute attribute { get; set; }
            public List<AttributeValue> attributeValues { get; set; }
            public int categoryId { get; set; }
            public bool required { get; set; }
            public bool varianter { get; set; }
            public bool slicer { get; set; }
        }

        public class Root
        {
            public int id { get; set; }
            public string name { get; set; }
            public string displayName { get; set; }
            public List<CategoryAttribute> categoryAttributes { get; set; }
        }
    }
}

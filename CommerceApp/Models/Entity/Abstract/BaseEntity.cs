using System;

namespace CommerceApp.Models.Entity.Abstract
{
    public abstract class BaseEntity
    {
        public bool isActive { get; set; }
        public bool isDelete { get; set; }
        public DateTime CreateDate{ get; set; }
        public DateTime ModifyDate { get; set; }

    }
}

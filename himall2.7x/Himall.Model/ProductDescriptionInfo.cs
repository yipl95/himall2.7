//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Himall.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductDescriptionInfo:BaseModel
    {
        long _id;
        public new long Id { get{ return _id; } set{ _id=value; base.Id = value; } }
        public long ProductId { get; set; }
        public string Description { get; set; }
        public long DescriptionPrefixId { get; set; }
        public long DescriptiondSuffixId { get; set; }
        public string Meta_Title { get; set; }
        public string Meta_Description { get; set; }
        public string Meta_Keywords { get; set; }
        public string AuditReason { get; set; }
        public string MobileDescription { get; set; }
    
        public virtual ProductInfo ProductInfo { get; set; }
    }
}

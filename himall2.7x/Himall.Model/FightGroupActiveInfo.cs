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
    
    public partial class FightGroupActiveInfo:BaseModel
    {
        long _id;
        public new long Id { get{ return _id; } set{ _id=value; base.Id = value; } }
        public long ShopId { get; set; }
        public Nullable<decimal> OpenGroupReward { get; set; }
        public Nullable<decimal> InvitationReward { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime UseDate { get; set; }
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public string IconUrl { get; set; }
        public string GroupNotice { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public Nullable<int> LimitedNumber { get; set; }
        public Nullable<decimal> LimitedHour { get; set; }
        public Nullable<int> LimitQuantity { get; set; }
        public Nullable<int> GroupCount { get; set; }
        public Nullable<int> OkGroupCount { get; set; }
        public Nullable<System.DateTime> AddTime { get; set; }
        public Nullable<int> ManageAuditStatus { get; set; }
        public string ManageRemark { get; set; }
        public Nullable<System.DateTime> ManageDate { get; set; }
        public Nullable<long> ManagerId { get; set; }
        public Nullable<int> ActiveTimeStatus { get; set; }
        public Nullable<int> IsVirtualProduct { get; set; }
        public Nullable<int> IsCombo { get; set; }
        public Nullable<int> IsDelete { get; set; }
        public string PayCode { get; set; }
        public Nullable<decimal> ReturnMoney { get; set; }

    }
}

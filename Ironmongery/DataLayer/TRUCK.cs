//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class TRUCK
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Nullable<int> TruckID { get; set; }
        public Nullable<int> OrderId { get; set; }
        public string Observations { get; set; }
    
        public virtual LOGISTIC LOGISTIC { get; set; }
        public virtual PRODUCT_ORDERS PRODUCT_ORDERS { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModel
{
    using System;
    using System.Collections.ObjectModel;
    
    public partial class Registration
    {
        public int RegistrationID { get; set; }
        public Nullable<int> GuestID { get; set; }
        public Nullable<int> RoomID { get; set; }
        public Nullable<System.DateTime> EntryDate { get; set; }
        public Nullable<System.DateTime> ExitDate { get; set; }
        public Nullable<int> HotelID { get; set; }
        public Nullable<int> DiscountID { get; set; }
    
        public virtual Discounts Discounts { get; set; }
        public virtual Guests Guests { get; set; }
        public virtual Rooms Rooms { get; set; }
        public virtual Hotels Hotels { get; set; }
    }
}

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
    
    public partial class Services
    {
        public Services()
        {
            this.ServiceRealization = new ObservableCollection<ServiceRealization>();
        }
    
        public int ServiceID { get; set; }
        public string ServiceTitle { get; set; }
        public double ServiceCost { get; set; }
        public Nullable<int> HotelID { get; set; }
    
        public virtual Hotels Hotels { get; set; }
        public virtual ObservableCollection<ServiceRealization> ServiceRealization { get; set; }
    }
}

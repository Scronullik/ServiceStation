//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceStation.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class ApplicationModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ApplicationModel()
        {
            this.OptionCustomer = new HashSet<OptionCustomerModel>();
            this.ReasonCustomer = new HashSet<ReasonCustomerModel>();
        }
    
        public int Number { get; set; }
        public System.DateTime Date { get; set; }
        public Nullable<System.DateTime> FirstControlTime { get; set; }
        public Nullable<System.DateTime> SecondControlTime { get; set; }
        public string Type { get; set; }
        public Nullable<System.DateTime> Readiness { get; set; }
        public Nullable<System.DateTime> Extradition { get; set; }
        public string Revealed { get; set; }
        public string Recommendations { get; set; }
        public Nullable<System.Guid> ID_powerOfAttorney { get; set; }
        public System.Guid ID_car { get; set; }
        public System.Guid ID_employee { get; set; }
    
        public virtual CarModel Car { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OptionCustomerModel> OptionCustomer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReasonCustomerModel> ReasonCustomer { get; set; }
        public virtual EmployeeModel Employee { get; set; }
        public virtual PowerOfAttorneyModel PowerOfAttorney { get; set; }
        public virtual TypeRepairModel TypeRepair { get; set; }
    }
}

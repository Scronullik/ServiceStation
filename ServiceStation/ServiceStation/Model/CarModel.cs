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
    
    public partial class CarModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CarModel()
        {
            this.Application = new HashSet<ApplicationModel>();
        }
    
        public System.Guid ID { get; set; }
        public string VIN { get; set; }
        public System.Guid ID_model { get; set; }
        public decimal Mileage { get; set; }
        public string LicensePlate { get; set; }
        public string NumberEngine { get; set; }
        public string NumberChassis { get; set; }
        public string NumberBody { get; set; }
        public System.DateTime Year { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }
        public System.Guid ID_contractor { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApplicationModel> Application { get; set; }
        public virtual ContractorModel Contractor { get; set; }
        public virtual ModelModel Model { get; set; }
    }
}

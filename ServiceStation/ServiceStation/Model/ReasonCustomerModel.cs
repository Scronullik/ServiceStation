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
    
    public partial class ReasonCustomerModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ReasonCustomerModel()
        {
            this.Material = new HashSet<MaterialModel>();
            this.Work = new HashSet<WorkModel>();
        }
    
        public System.Guid ID { get; set; }
        public System.Guid ID_reason { get; set; }
        public int Number { get; set; }
    
        public virtual ApplicationModel Application { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaterialModel> Material { get; set; }
        public virtual ReasonModel Reason { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkModel> Work { get; set; }
    }
}

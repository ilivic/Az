//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hr_manager.ADOApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Intern
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Intern()
        {
            this.InternTask = new HashSet<InternTask>();
            this.Histr = new HashSet<Histr>();
        }
    
        public int Id_intern { get; set; }
        public string FullName { get; set; }
        public byte[] Photo { get; set; }
        public System.DateTime DataStart { get; set; }
        public Nullable<System.DateTime> DataFinish { get; set; }
        public bool IsActive { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InternTask> InternTask { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Histr> Histr { get; set; }
    }
}

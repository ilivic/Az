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
    
    public partial class Histr
    {
        public int id_Hist { get; set; }
        public int Task_id { get; set; }
        public int status_id { get; set; }
        public Nullable<int> Intern_id { get; set; }
        public System.DateTime date { get; set; }
        public string Title { get; set; }
    
        public virtual Intern Intern { get; set; }
        public virtual Status Status { get; set; }
        public virtual Task Task { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPFautosalon.BD_
{
    using System;
    using System.Collections.Generic;
    
    public partial class Склад
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Склад()
        {
            this.Место_на_складе = new HashSet<Место_на_складе>();
        }
    
        public int Уид { get; set; }
        public string Адрес { get; set; }
        public string Тип { get; set; }
        public Nullable<int> Вместимость { get; set; }
        public Nullable<int> Заполнено { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Место_на_складе> Место_на_складе { get; set; }
    }
}

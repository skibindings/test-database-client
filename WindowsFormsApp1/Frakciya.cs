//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Frakciya
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Frakciya()
        {
            this.Deputaties = new HashSet<Deputaty>();
            this.Pomoshnik_deputata_ = new HashSet<Pomoshnik_deputata_>();
            this.Sozyvies = new HashSet<Sozyvy>();
        }

        public override string ToString()
        {
            return Naimenovanie;
        }

        public int ID { get; set; }
        public string Naimenovanie { get; set; }
        public int Kolichestvo_deputatov { get; set; }
        public int Kolichestvo_deputatov_posledniy_sozyv { get; set; }
        public Nullable<int> Lider_frakcii { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Deputaty> Deputaties { get; set; }
        public virtual Deputaty Deputaty { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pomoshnik_deputata_> Pomoshnik_deputata_ { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sozyvy> Sozyvies { get; set; }
    }
}
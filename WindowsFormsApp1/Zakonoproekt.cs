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
    
    public partial class Zakonoproekt
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Zakonoproekt()
        {
            this.Kriteriys = new HashSet<Kriteriy>();
            this.Rassmotrenie_ZP = new HashSet<Rassmotrenie_ZP>();
            this.Versiya_ZP = new HashSet<Versiya_ZP>();
        }
    
        public int ID { get; set; }
        public string Naimenovanie { get; set; }
        public string Opisanie { get; set; }
        public int Vnesen { get; set; }
        public Nullable<int> Okonchatelniy_status { get; set; }
    
        public virtual Deputaty Deputaty { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kriteriy> Kriteriys { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rassmotrenie_ZP> Rassmotrenie_ZP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Versiya_ZP> Versiya_ZP { get; set; }
    }
}
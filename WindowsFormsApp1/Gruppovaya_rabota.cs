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
    
    public partial class Gruppovaya_rabota
    {
        public int ID { get; set; }
        public int Zasedanie { get; set; }
        public int Versiya_nachalnaya { get; set; }
        public int Versiya_konechnaya { get; set; }
    
        public virtual Versiya_ZP Versiya_ZP { get; set; }
        public virtual Versiya_ZP Versiya_ZP1 { get; set; }
        public virtual Zasedanie Zasedanie1 { get; set; }
    }
}

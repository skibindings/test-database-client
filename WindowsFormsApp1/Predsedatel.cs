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
    
    public partial class Predsedatel
    {
        public int Nomer { get; set; }
        public string Familiya { get; set; }
        public string Imya { get; set; }
        public string Otchestovo { get; set; }
        public System.DateTime Data_nachala { get; set; }
        public System.DateTime Data_konca { get; set; }
        public int Nomer_sozyva { get; set; }
    
        public virtual Sozyvy Sozyvy { get; set; }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StokUygulamasıMVC.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class SATISLAR
    {
        public int SATISID { get; set; }
        public Nullable<int> URUN { get; set; }
        public Nullable<int> MUSTERI { get; set; }
        public Nullable<int> ADET { get; set; }
        public Nullable<decimal> FİYAT { get; set; }
    
        public virtual MUSTERILER MUSTERILER { get; set; }
        public virtual URUNLER URUNLER { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JOVOICE.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class paymentnew
    {
        public int Id { get; set; }
        public string email { get; set; }
        public string name { get; set; }
        public Nullable<int> cardnumber { get; set; }
        public Nullable<int> cvv { get; set; }
        public Nullable<int> phone { get; set; }
    }
}

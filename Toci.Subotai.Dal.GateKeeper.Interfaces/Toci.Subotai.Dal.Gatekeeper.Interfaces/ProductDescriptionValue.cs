//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Toci.Subotai.Dal.Gatekeeper.Interfaces
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductDescriptionValue
    {
        public int Id { get; set; }
        public Nullable<int> IdProductDescriptionElements { get; set; }
        public string Value { get; set; }
    
        public virtual ProductDescriptionElement ProductDescriptionElement { get; set; }
    }
}

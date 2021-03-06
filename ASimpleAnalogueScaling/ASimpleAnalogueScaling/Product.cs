//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ScalingApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Product
    {
        public int ProductID { get; set; }
        [Required]
        [Display(Name = "Product Name")]
        public string Name { get; set; }
        [Display(Name = "Product Description")]
        [StringLength(300)]
        public string ProductDescription { get; set; }
        public Nullable<int> UnitMeasureCode { get; set; }
    
        public virtual UnitOfMeasure UnitOfMeasure { get; set; }
    }
}

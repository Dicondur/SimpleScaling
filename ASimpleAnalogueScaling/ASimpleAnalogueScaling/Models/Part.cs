using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ScalingApp.Models
{
    
    [Table("dbo.Parts")]
    public class Part
    {

        public uint PartID { get; set; }
        public string PartName { get; set; }
        public string ModelNo { get; set; }
        public string Manufacturer { get; set; }
        public string PartDescription { get; set; }

    }
}
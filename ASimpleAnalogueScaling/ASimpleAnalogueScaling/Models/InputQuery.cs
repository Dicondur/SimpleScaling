using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ScalingApp
{
    public partial class InputQuery
    {

        //public int QueryId { get; set; }

        [Display(Name = "Scaled Minimum")]
        [Required(ErrorMessage = "Please provide Min", AllowEmptyStrings = false)]
        public double ScaledMin { get; set; }
        [Display(Name = "Scaled Max")]
        [Required(ErrorMessage = "Please provide Max", AllowEmptyStrings = false)]
        public double ScaledMax { get; set; }
        [Display(Name = "Raw Minimum")]
        [Required(ErrorMessage = "Please provide Min", AllowEmptyStrings = false)]
        public double RawMin { get; set; }

        [Display(Name = "Raw Maximum")]
        [Required(ErrorMessage = "Please provide Max", AllowEmptyStrings = false)]
        [Range(1,100000)]
        public double RawMax { get; set; }
        public Nullable<double> RawInput { get; set; }
        public Nullable<double> ScaledInput { get; set; }

        public double Rate { get { return ((this.ScaledMax - this.ScaledMin) / (this.RawMax - this.RawMin)); } }
        public double Offset { get { return (this.ScaledMin - (this.RawMin * this.Rate)); } }

        public double? ScaledResult() {  return ((this.RawInput*this.Rate) + this.Offset);  }
        public double? RawResult() { return ((this.ScaledInput - this.Offset) / (this.Rate));  }
    }
}
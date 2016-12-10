using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASimpleAnalogueScaling
{
    public partial class InputQuery
    {
        public double Rate { get { return ((this.ScaledMax - this.ScaledMin) / (this.RawMax - this.RawMin)); } }
        public double Offset { get { return (this.ScaledMin - (this.RawMin * this.Rate)); } }

        public double? ScaledResult() {  return ((this.RawInput*this.Rate) + this.Offset);  }
        public double? RawResult() { return ((this.ScaledInput - this.Offset) / (this.Rate));  }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KODIRPC.PVR.Property
{
   public class Value
   {
       public bool available { get; set; }
       public bool recording { get; set; }
       public bool scanning { get; set; }
    }
}

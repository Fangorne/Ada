using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
#pragma warning disable CS0108

namespace KODIRPC.Profiles
{
   public class Password
   {
       public KODIRPC.Profiles.Password_encryption encryption { get; set; }
       public string value { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Rewind.Models.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class FileUploader
    {
        public int id { get; set; }
        public string filename { get; set; }
        public byte[] filedata { get; set; }
        public System.DateTime uploadtime { get; set; }
        public int regisid { get; set; }
    
        public virtual Registration Registration { get; set; }
    }
}

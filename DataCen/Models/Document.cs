//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataCen.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Document
    {
        public int DocumentId { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public string Type { get; set; }
        public string FileContent { get; set; }
        public string IsDeleted { get; set; }
        public string CreatedOn { get; set; }
        public string ModifiedOn { get; set; }
        public int BlogId { get; set; }
    
        public virtual Blog Blog { get; set; }
    }
}

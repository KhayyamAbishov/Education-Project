//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EducationProject.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class AssignTask
    {
        public int AssignTaskId { get; set; }
        public int TaskId { get; set; }
        public int StudentId { get; set; }
    
        public virtual Task Task { get; set; }
        public virtual Student Student { get; set; }
    }
}

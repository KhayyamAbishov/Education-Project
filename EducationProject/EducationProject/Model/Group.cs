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
    
    public partial class Group
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Group()
        {
            this.Students = new HashSet<Student>();
        }
    
        public int GroupId { get; set; }
        public int ProgramId { get; set; }
        public int MentorId { get; set; }
        public int TeacherId { get; set; }
        public int GroupCategoryId { get; set; }
        public string GroupName { get; set; }
        public Nullable<System.DateTime> GroupStartDate { get; set; }
    
        public virtual Program Program { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student> Students { get; set; }
        public virtual Mentor Mentor { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual GroupCategory GroupCategory { get; set; }
    }
}

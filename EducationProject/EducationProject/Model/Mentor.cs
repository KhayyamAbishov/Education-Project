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
    
    public partial class Mentor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mentor()
        {
            this.Groups = new HashSet<Group>();
        }
    
        public int MentorId { get; set; }
        public int PackageId { get; set; }
        public string MentorName { get; set; }
        public string MentorSurname { get; set; }
        public string MentorEmail { get; set; }
        public string MentorPhone { get; set; }
        public string MentorBio { get; set; }
        public string MentorPhoto { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Group> Groups { get; set; }
        public virtual Package Package { get; set; }
    }
}

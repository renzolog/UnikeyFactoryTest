//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary1.DAL.DAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class ExTest_Question
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ExTest_Question()
        {
            this.Pa_ExQuestion = new HashSet<Pa_ExQuestion>();
        }
    
        public int Id { get; set; }
        public Nullable<int> QuestionId { get; set; }
        public int ExTestId { get; set; }
        public int Position { get; set; }
    
        public virtual ExTest ExTest { get; set; }
        public virtual Question Question { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pa_ExQuestion> Pa_ExQuestion { get; set; }
    }
}

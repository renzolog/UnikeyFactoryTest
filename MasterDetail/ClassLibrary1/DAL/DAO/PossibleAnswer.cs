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
    
    public partial class PossibleAnswer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PossibleAnswer()
        {
            this.Pa_ExQuestion = new HashSet<Pa_ExQuestion>();
        }
    
        public int Id { get; set; }
        public string Text { get; set; }
        public byte IsCorrect { get; set; }
        public int QuestionId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pa_ExQuestion> Pa_ExQuestion { get; set; }
        public virtual Question Question { get; set; }
    }
}

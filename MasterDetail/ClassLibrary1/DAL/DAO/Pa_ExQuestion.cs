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
    
    public partial class Pa_ExQuestion
    {
        public int Id { get; set; }
        public Nullable<int> PossibleAnswerId { get; set; }
        public int QuestionExId { get; set; }
        public bool IsSelected { get; set; }
    
        public virtual ExTest_Question ExTest_Question { get; set; }
        public virtual PossibleAnswer PossibleAnswer { get; set; }
    }
}
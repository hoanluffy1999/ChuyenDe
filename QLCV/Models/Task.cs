//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLCV.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Task
    {
        public int Id { get; set; }
        public Nullable<int> JobId { get; set; }
        public Nullable<int> EmployeeId { get; set; }
        public Nullable<int> RateId { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
    }
}

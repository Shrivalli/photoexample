//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCFirstApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public int eid { get; set; }
        public string ename { get; set; }
        public Nullable<double> salary { get; set; }
        public Nullable<System.DateTime> doj { get; set; }
        public string designation { get; set; }
        public Nullable<int> deptid { get; set; }
    
        public virtual Department Department { get; set; }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace bookyourdoctor.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class doctor
    {
        public string doctor_id { get; set; }
        public string name { get; set; }
        public string date_of_birth { get; set; }
        public string phone { get; set; }
        public int MBBS_Code { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string confirm_password { get; set; }
        public string clinic_name { get; set; }
        public string hospital_address { get; set; }
        public string hospital_name { get; set; }
        public string clinic_address { get; set; }
        public string city { get; set; }
        public string specialization { get; set; }
        public int practising_years { get; set; }
        public int Fee { get; set; }
    }
}
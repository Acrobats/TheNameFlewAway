//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Self_Hosting.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string password { get; set; }
        public Nullable<byte> status { get; set; }

        public User(string name, string phone, string password, byte? status)
        {
            this.name = name;
            this.phone = phone;
            this.password = password;
            this.status = status;
        }
        public User()
        {

        }
    }
}

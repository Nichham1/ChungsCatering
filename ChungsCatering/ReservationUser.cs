//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChungsCatering
{
    using System;
    using System.Collections.Generic;
    
    public partial class ReservationUser
    {
        internal readonly object ReservationDescription;
        internal DateTime ReservationCreateDate;
        internal int SeatStatusID;
        internal int ReservationStatusID;
        internal int ReservationDescriptionID;

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string CustomerAddress { get; set; }
        public string Telephone { get; set; }
        public Nullable<System.DateTime> ReservationDateID { get; set; }
    }
}

using Ef_core_summery.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ef_core_summery.Models
{
    public class Member: BaseEntity
    {
        #region Properties
        /*
        Attributes:
●	Id – Unique identifier
●	Name
●	Email
●	PhoneNumber
●	Address
●	MembershipDate
●	Status (Active, Suspended)
        */
        public string? Name { get; set; } = null;
        public string? Email { get; set; } = null;
        public string? PhoneNumber { get; set; } = null;
        public string? address { get; set; } = null;
        public DateTime MembershipDate { get; set; }
        public MemberStatus status { get; set; }
        #endregion

        #region MemberLoans
        public virtual ICollection<MemberLoans> MemberLoans { get; set; } = new HashSet<MemberLoans>();
        #endregion
    }
}

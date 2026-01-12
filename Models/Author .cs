using System;
using System.Collections.Generic;
using System.Text;

namespace Ef_core_summery.Models
{
    internal class Author : BaseEntity
    {
//        Attributes:
//●	Id – Unique identifier
//●	FirstName
//●	LastName
//●	DateOfBirth
        public string? FirstName { get; set; } = null;
        public string? LastName { get; set; } = null;
        public DateTime DateOfBirth { get; set; }

    }
}

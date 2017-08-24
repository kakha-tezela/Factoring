using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FactoringService.Core.Domain
{
    public class RepresentivePerson
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string PersonalId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhysicalAddress { get; set; }
        public string RegistrationAddress { get; set; }
        public string DocumentNumber { get; set; }
        public DateTime DocumentDateOfIssue { get; set; }
        public string DocumentRegisteringOrganization { get; set; }
        public DateTime DocumentExpirationDate { get; set; }
        public PoliticPerson PoliticPerson { get; set; }
        public DateTime? PersonRegistrationDate { get; set; }
        public string PersonRegistrationCode { get; set; }
        public string PersonRegisteringOrganization { get; set; }
        public string PersonPosition { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }


        //§  მოქალაქეობა - int required
        // piris statusi ???
        //§  საბუთის ტიპი - int required(subtask 1)
        //§  სოციალური სტატუსი -  int required(subtask 3)
    }

    public enum PoliticPerson
    {
        Yes = 0,
        No = 1
    }
}
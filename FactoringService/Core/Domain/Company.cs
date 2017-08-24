using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FactoringService.Core.Domain
{
    public class Company
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public RepresentivePerson RepresentivePerson { get; set; }
        public string CompanyCode { get; set; }
        public BussinessType BussinessType { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string RegistrationAddress { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
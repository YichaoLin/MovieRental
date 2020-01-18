using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Codly.Models;

namespace Codly.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}
using asp_mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace asp_mvc.ViewModels
{
    public class NewCustomerViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }

        public int? Id { get; set; }

        public string Title
        {
            get
            {
                return Id != 0 ? "Edit Customer" : "New Customer";
            }
        }

        public NewCustomerViewModel()
        {
            Id = 0;
        }
    }
}
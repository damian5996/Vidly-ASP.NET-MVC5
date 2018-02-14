using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModel
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }

        public string Title  => (Customer != null && Customer.Id != 0) ? "Edit Customer" : "New Customer";
            

            //get
            //{
            //    return (Customer != null && Customer.Id != 0) ? "Edit Customer" : "New Customer";
            //}

            //get
            //{
            //    if (Customer != null && Customer.Id != 0)
            //        return "Edit Customer";

            //    return "New Customer";
            //}
        

    }
}
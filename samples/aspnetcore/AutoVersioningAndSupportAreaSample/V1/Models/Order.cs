using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoVersioningAndSupportAreaSample.V1.Models
{
    public class Order
    {
        public Order( string controller, string accountId, string apiVersion )
        {
            Controller = controller;
            AccountId = accountId;
            ApiVersion = apiVersion;
        }

        public string Controller { get; set; }

        public string AccountId { get; set; }

        public string ApiVersion { get; set; }
    }
}

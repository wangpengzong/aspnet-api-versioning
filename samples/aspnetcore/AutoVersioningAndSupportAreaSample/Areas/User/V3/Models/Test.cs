using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoVersioningAndSupportAreaSample.Areas.User.V3.Models
{
    public class Test
    {
        public Test( string controller, string accountId, string apiVersion )
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

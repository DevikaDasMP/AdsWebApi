using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineAdsApp1API.Models
{
    public class UserBindingModel
    {
        public int UserId { get; set; }

        public string UserName { get; set; }

        public string EmailId { get; set; }

        public int PhoneNo { get; set; }
    }
}
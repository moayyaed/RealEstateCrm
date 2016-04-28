﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Entities
{
    public enum Gender
    {
        Male,
        Female
    }

    public enum CustomerStatus
    {
        Invalid = 0,
        Advertising,
        Contract
    }

    public class Customer 
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MidleName { get; set; }

        public Gender? Gender { get; set; }

        public List<CustomerPhone> Phones { get; set; }

        public string Resource { get; set; }

        public CustomerStatus Status { get; set; }

        public int MinSum { get; set; }

        public int MaxSum { get; set; }

        public DateTime DateMeeting { get; set; }

        public int ContractSum { get; set; }

        public int ReheshSum { get; set; }

        public DateTime DateIn { get; set; }

        public DateTime DateClosed { get; set; }

        public DateTime DateContract { get; set; }

        public bool IsSiteAccess { get; set; }

        public int CityId { get; set; }

        public virtual City Cities { get; set; }

        public int SmsId { get; set; }

        public virtual Sms Smses { get; set; }

        public List<DistrictToСlient> DistrictToСlients { get; set; }

        public string ApplicationUserId { get; set; }

        [ForeignKey("ApplicationUserId")]
        public ApplicationUser User { get; set; }

        public string CustomerUserId { get; set; }

        [ForeignKey("CustomerUserId")]
        public ApplicationUser CustomerAccount { get; set; }
    }
}

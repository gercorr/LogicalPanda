﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class UserDetail
    {
        public int Id { get; set; }
        public string ApplicationIdentityId { get; set; }
        public string UserName { get; set; }
        public bool Admin { get; set; }
    }
}
﻿using Microsoft.AspNet.Identity.EntityFramework;

namespace IdentityAuth.Models
{
    public class ApplicationRole:IdentityRole
    {
        public ApplicationRole() { }

        public string Description { get; set; }
    }
}
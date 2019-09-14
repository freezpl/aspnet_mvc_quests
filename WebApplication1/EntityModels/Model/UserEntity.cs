using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityModels.Model
{
    public class UserEntity : IdentityUser
    {
        public string Name { get; set; }
        [Range(10, 99)]
        public int Years { get; set; }
    }
}

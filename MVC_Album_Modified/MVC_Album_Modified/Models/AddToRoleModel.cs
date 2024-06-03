using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Album_Modified.Models
{
    public class AddToRoleModel
    {
        public string Email { get; set; }
        public string SelectedRole { get; set; }
        public List<string> Roles { get; set;}
    }
}
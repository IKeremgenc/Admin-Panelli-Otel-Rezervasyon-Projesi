
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.EntityLayer.Concrete
{
    public class AppUser: IdentityUser<int>
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Sehir { get; set; }
        public string   Countrey { get; set; }
        public string Cinsiyet { get; set; }
        public string  WorkDepartman{ get; set; }
        public int WorkLocationid { get; set; }
        public WorkLocation WorkLocation{ get; set; }


    }
}

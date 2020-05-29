using CovidWebAPI.Model;
using Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidWebAPI.Data
{
    public class CovidAuthContext : IdentityDbContext<ApplicationUser>
    {
        public CovidAuthContext(DbContextOptions<CovidAuthContext> options):base(options)
        {

        }
    }
}

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemplateLogin.Web.Model
{
    public class TemplateLoginDbContext : IdentityDbContext
    {
        public TemplateLoginDbContext(DbContextOptions<TemplateLoginDbContext> options) : base(options)
        {
        }
    }
}

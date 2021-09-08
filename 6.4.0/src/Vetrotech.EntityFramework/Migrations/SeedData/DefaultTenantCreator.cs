using System.Linq;
using Vetrotech.EntityFramework;
using Vetrotech.MultiTenancy;

namespace Vetrotech.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly VetrotechDbContext _context;

        public DefaultTenantCreator(VetrotechDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}

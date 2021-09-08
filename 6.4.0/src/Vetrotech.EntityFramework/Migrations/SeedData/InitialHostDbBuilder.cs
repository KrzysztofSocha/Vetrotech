using Vetrotech.EntityFramework;
using EntityFramework.DynamicFilters;

namespace Vetrotech.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly VetrotechDbContext _context;

        public InitialHostDbBuilder(VetrotechDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}

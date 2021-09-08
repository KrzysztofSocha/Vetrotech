using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Vetrotech.EntityFramework;

namespace Vetrotech.Migrator
{
    [DependsOn(typeof(VetrotechDataModule))]
    public class VetrotechMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<VetrotechDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
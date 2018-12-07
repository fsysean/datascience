using Autofac;

namespace Sean.DataScience.Data.NpgSQL
{
    public class NpgSQLDataModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<NpgSQLData>();
        }
    }
}

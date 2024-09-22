using System.Threading.Tasks;

namespace NewABP.Demo.Data;

public interface IDemoDbSchemaMigrator
{
    Task MigrateAsync();
}

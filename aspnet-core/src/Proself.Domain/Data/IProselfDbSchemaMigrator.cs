using System.Threading.Tasks;

namespace Proself.Data;

public interface IProselfDbSchemaMigrator
{
    Task MigrateAsync();
}

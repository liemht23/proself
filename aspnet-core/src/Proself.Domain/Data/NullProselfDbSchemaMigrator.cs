using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Proself.Data;

/* This is used if database provider does't define
 * IProselfDbSchemaMigrator implementation.
 */
public class NullProselfDbSchemaMigrator : IProselfDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}

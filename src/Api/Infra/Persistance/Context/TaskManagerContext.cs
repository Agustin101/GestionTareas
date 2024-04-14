using Microsoft.EntityFrameworkCore;

namespace Api.Infra.Persistance.Context
{
    public class TaskManagerContext : DbContext
    {
        public TaskManagerContext(DbContextOptions<TaskManagerContext> opts) : base(opts)
        {
        }
    }
}

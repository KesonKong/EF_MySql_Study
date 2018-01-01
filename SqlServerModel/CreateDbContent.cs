using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SqlServerModel.Model
{
    public class CreateDbContent: DbContext
    {
        public DbSet<Dx_User> dx_User { get; set; }
        public DbSet<Dx_Role> dx_Roles { get; set; }

        static CreateDbContent()
        {

            /*CreateDatabaseIfNotExists是Database.SetInitializer指定数据库的默认方式，用于当数据库不存在时，自动创建数据库。由于该方式是默认方式，所以可以不需要任何代码进行指定，当然也可以使用代码来明确的指定。
             *DropCreateDatabaseIfModelChanges，先删除原数据库，后创建新的数据库。
             *DropCreateDatabaseAlways用于每次均先删除原数据库再创建新的数据库，不管数据模型是否发生改变。*/

            //Database.SetInitializer<CreateDbContent>(null);
            //Database.SetInitializer(new CreateDatabaseIfNotExists<CreateDbContent>());
            //Database.SetInitializer(new DropCreateDatabaseAlways<CreateDbContent>());
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<CreateDbContent>());
        }

        public CreateDbContent() : base("name=YiHouQin")
        {
            // 禁用延迟加载
            this.Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Fluent API
            //modelBuilder.Entity<Dx_User>().HasKey(d => d.UserId);
            //base.OnModelCreating(modelBuilder);
            
            // 禁用默认表名复数形式
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            // 禁用一对多级联删除
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            // 禁用多对多级联删除
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }
    }


}

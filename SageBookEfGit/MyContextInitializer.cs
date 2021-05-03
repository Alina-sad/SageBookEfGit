using System.Data.Entity;

namespace SageBookEfGit
{
    public class MyContextInitializer : CreateDatabaseIfNotExists<MyDbContext>
    {
        protected override void Seed(MyDbContext context)
        {
            Books b1 = new Books() { Title = "B1" };
            Books b2 = new Books() { Title = "B2" };

            context.Book.Add(b1);
            context.Book.Add(b2);

            context.SaveChanges();
        }
    }
}
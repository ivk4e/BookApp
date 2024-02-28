using BookApp.Data;

var db = new BookAppContext();

if (db.Database.EnsureCreated())
{
	Console.WriteLine("Database was created successfully.");
}
else
{
	Console.WriteLine("Database was not created.");
}

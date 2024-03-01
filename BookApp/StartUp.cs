using BookApp.Data;

var db = new BookAppContext();

db.Database.EnsureDeleted();

if (db.Database.EnsureCreated())
{
	Console.WriteLine("Database was created successfully.");
}
else
{
	Console.WriteLine("Database was not created.");
}

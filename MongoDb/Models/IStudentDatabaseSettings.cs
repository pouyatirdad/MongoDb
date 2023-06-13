namespace MongoDb.Models
{
	public interface IStudentDatabaseSettings
	{
        string StudentCoursesCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}

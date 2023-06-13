﻿namespace MongoDb.Models
{
	public class StudentDatabaseSettings : IStudentDatabaseSettings
	{
		public string StudentCoursesCollectionName { get; set; }=string.Empty;
		public string ConnectionString { get; set; } = string.Empty;
		public string DatabaseName { get; set; } = string.Empty;
	}
}

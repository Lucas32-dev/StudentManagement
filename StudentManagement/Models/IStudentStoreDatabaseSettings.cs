namespace StudentManagement.Models
{
    public interface IStudentStoreDatabaseSettings
    {  
        string StudentCoursesCollectionName { get; set; }
        string DatabaseName { get; set; }
        string ConnectionString { get; set; }
    }
}

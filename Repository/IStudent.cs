using webapp.Models;

namespace webapp.Repository
{
    public interface IStudent
    {
        List<Students> GetAllstudents();
        Students getStudentByid();

    }
}

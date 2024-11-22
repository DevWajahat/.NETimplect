
using webapp.Models;

namespace webapp.Repository
{
    public class StudentRepository : IStudent
    {
      
        public List<Students> getAllstudent()
        {
            return Datasource();
        }

        public List<Students> GetAllstudents()
        {
            throw new NotImplementedException();
        }

        public Students getStudentByid(int id)
        {
            return Datasource().Where(x => x.rollNumber == id).FirstOrDefault();
        }

        public Students getStudentByid()
        {
            throw new NotImplementedException();
        }

        private List<Students> Datasource()
        {
            return new List<Students>()
            {
                new Students{rollNumber=1, name="Rizwan", age=15,grade ="Matric"},
                new Students{rollNumber=2, name="Ayesha", age=22,grade ="Master"},
                new Students{rollNumber=3, name="Ali", age = 25, grade = "Matric"},
                new Students{rollNumber=4, name="Khansa", age = 12, grade="BA"},
                new Students{rollNumber=5, name="Wajahat",age = 33, grade="Inter"}
            };
        }

    }
}

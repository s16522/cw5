using cwiczenie3.DTO;

namespace cwiczenie3.Services
{
    public interface IStudentsDbService
    {
        public string PostStudent(PostStudentRequest student);

        public string PromoteStudents(PromoteStudentRequest request);
    }
}
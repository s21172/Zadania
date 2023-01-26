using Zad3.Models;

namespace Zad3.Services
{
    public interface ICSVService
    {
        public List<Student> GetAll();
        public Student GetByID(string studentId);
        public void Edit(string studentId, Student student);
        public void Add(Student student);
        public void Remove(string studentId);
    }
}

using Facality.Data;
using Facality.Models;

namespace Facality.Data.service
{
    public interface Istudent
    {
        Task<IEnumerable<Student>> GetAll();
        Task Add(Student student);
        Task<Student>GetById(int id);
        Task Updata(int id,Student student);
        Task Delete(Student student);
    }
}

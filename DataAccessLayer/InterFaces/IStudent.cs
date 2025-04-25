using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.InterFaces
{
    internal interface IStudent
    {
        IEnumerable<Student> GetAll();
        Student? GetById(int id);
        int Add(Student model);
        int Update(Student model);
        int Delete(Student model);
    }
}

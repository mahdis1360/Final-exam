using Poco;
using Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Text;

namespace EFRepository
{
    public class StudentRepo : IDataRepository<StudentPoco>

    {
        private readonly SchoolContext _context;

        public StudentRepo()
        {
            _context = new SchoolContext();

        }
        public void Add(params StudentPoco[] items)
        {

            StudentPoco s = new StudentPoco();
            _context.students.Add(s);
            _context.SaveChanges();
        }
        public IList<StudentPoco> GetAll(params Expression<Func<StudentPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public void Remove(params StudentPoco[] items)
        {
            StudentPoco s = new StudentPoco();
            StudentPoco student = _context.students.Find(s.Id);
            if (student != null)
            {
                throw new ArgumentOutOfRangeException("i didnot find");
            }
            _context.students.Remove(student);
            _context.SaveChanges();
        }

        public void Update(params StudentPoco[] items)
        {

        }
    }
}

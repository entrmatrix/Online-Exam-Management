using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseContext;
using Models;


namespace Repository
{
    public class CourseRepository
    {
        OrganizationDbContext _db=new OrganizationDbContext();
        public bool Add(Course course)
        {
            _db.Courses.Add(course);
            return _db.SaveChanges() > 0;
        }
    }
}

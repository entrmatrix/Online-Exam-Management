using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using  Repository;

namespace Bll
{
    public class CourseBll
    {
        CourseRepository _courseRepository=new CourseRepository();
        OrganizationRepository _organizationRepository =new OrganizationRepository();
        public bool Add(Course course)
        {
            return _courseRepository.Add(course);
        }

        public List<Organization> GetAllOrganizations()
        {
            return _organizationRepository.GetAll();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DatabaseContext;

namespace Repository
{
    public class OrganizationRepository
    {
        OrganizationDbContext db=new OrganizationDbContext();
        public bool Add(Organization organization)
        {
            db.Organizations.Add(organization);
         return   db.SaveChanges() > 0;
        }

        public List<Organization> GetAll()
        {
            var organizations = db.Organizations.ToList();
            return organizations;
        }
    }
}

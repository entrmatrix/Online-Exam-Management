using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Repository;


namespace Bll
{
   public class OrganizationBll
    {
       OrganizationRepository _organizationRepository=new OrganizationRepository();


       public bool Add(Organization organization)
       {
           return _organizationRepository.Add(organization);
       }
    }
}

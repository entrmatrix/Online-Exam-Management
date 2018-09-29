﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Models.ViewModels
{
    public class CourseEntryVm
    {
        public int Id { get; set; }
        public Organization Organization { get; set; }
        public int OrganizationId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Duration { get; set; }
        public int Credit { get; set; }
        public string Outline { get; set; }
        public string Tag { get; set; }
        public bool IsDeleted { get; set; }


        public List<SelectListItem> OrganizationListItem { get; set; }

        
    }
}

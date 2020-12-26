using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public Employer Employer { get; set; }

        public List<SelectListItem> Employers { get; set; }
        public List<int> SkillId { get; set; }
        public List<SelectListItem> Skills { get; set; }

        public AddJobViewModel()
        {
        }

        public AddJobViewModel(List<Employer> listOfEmployers, List<Skill> listOfSkills)
        {
            this.Employers = new List<SelectListItem>();
            foreach (Employer employer in listOfEmployers)
            {
                SelectListItem item = new SelectListItem
                {
                    Value = employer.Id.ToString(),
                    Text = employer.Name
                };
                Employers.Add(item);
            }

            this.Skills = new List<SelectListItem>();
            foreach (Skill skill in listOfSkills)
            {
                SelectListItem item = new SelectListItem
                {
                    Value = skill.Id.ToString(),
                    Text = skill.Name
                };
                Skills.Add(item);
            }
        }
    }
}

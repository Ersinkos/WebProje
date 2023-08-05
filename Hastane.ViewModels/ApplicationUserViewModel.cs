using Hastane.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.ViewModels
{
    public class ApplicationUserViewModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string userName { get; set; }
        public string City { get; set; }
        public bool isDoctor { get; set; }
        public Gender Gender { get; set; }
        public string Specialist { get; set; }
        public ApplicationUserViewModel()
        {

        }
        public ApplicationUserViewModel(ApplicationUser user)
        {
            Name = user.Name;
            City = user.City;
            Gender = user.Gender;
            Specialist = user.Specialist;
            isDoctor = user.IsDoctor;
            userName = user.UserName;
            Email = user.Email;
        }
        public ApplicationUser ConvertViewModelToModel(ApplicationUserViewModel user)
        {
            return new ApplicationUser
            {
                Name = user.Name,
                City = user.City,
                Gender = user.Gender,
                Specialist = user.Specialist,
                IsDoctor = user.isDoctor,
                Email = user.Email,
                UserName = user.userName
            };
        }
        public List<ApplicationUser> Doctors { get; set; } = new List<ApplicationUser>();
    }
}

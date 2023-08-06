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
		public string Name { get; set; } = null!;
		public string Email { get; set; } = null!;
		public string userName { get; set; } = null!;
		public string City { get; set; } = null!;
		public bool isDoctor { get; set; }
		public Gender Gender { get; set; }
		public string Specialist { get; set; }= null!;
		public ApplicationUserViewModel()
		{

		}
		public ApplicationUserViewModel(ApplicationUser user)
		{
			Name = user.Name;
			Email = user.Email;
			userName = user.UserName;
			City = user.City;
			Gender = user.Gender;
			Specialist = user.Specialist;
		}
		public ApplicationUser ConvertViewModelToModel(ApplicationUserViewModel user)
		{
			return new ApplicationUser
			{
				Name = user.Name,
				City = user.City,
				Gender = user.Gender,
				Specialist = user.Specialist,

				Email = user.Email,
				UserName = user.userName
			};
		}
		public List<ApplicationUser> Doctors { get; set; } = new List<ApplicationUser>();
	}
}

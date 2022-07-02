using System.Collections.Generic;
using ExamampleApp2Approach.Entities;
using ExampleApp.Model;

namespace ExamampleApp2Approach.Service
{
	public class HardwareService
	{
		private static List<Hardware> Hardwares { get; set; }
		private static List<Company> Companies { get; set; }
		
		
		public void Add(Hardware hardware)
		{
			Hardwares ??= new List<Hardware>();
			Hardwares.Add(hardware);
		}
		
		public List<Hardware> GetHardware()
		{
			var result = Hardwares ?? new List<Hardware>
			{
				new()
				{
					Description = "sdfsdf",
					Id = 1,
					Name = "NameHardware",
					Price = 1271623,
					Year = "2020",
					CompanyId = 2,
					NumberOfItems = "10"
				}
			};

			return result;
		}

		public List<Company> GetCompanies()
		{
			var result = Companies ?? new List<Company>()
			{
				new Company()
				{
					Id = 1,
					Name = "Company 1",

				},
				new Company()
				{
					Id = 2,
					Name = "Company 2",
				},
				new Company()
				{
					Id = 3,
					Name = "Company 3",
				}

			};

			return result;
		}


	}
}
using System.Collections.Generic;
using ExamampleApp2Approach.Entities;
using ExampleApp.Model;

namespace ExamampleApp2Approach.Service
{
	public class HardwareService
	{
		private static List<Hardware> Hardwares;
		private static List<Company> Companies;
		
		
		public void Add(Hardware hardware)
		{
			if (hardware is null)
			{
				Hardwares = new List<Hardware>();
				
			}

			Hardwares.Add(hardware);
		}
		
		public List<Hardware> GetHardware()
		{
			var result = Hardwares ?? new List<Hardware>()
			{
				new Hardware()
				{
					
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
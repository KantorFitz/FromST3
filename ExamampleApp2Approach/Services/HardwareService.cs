using System.Collections.Generic;
using ExamampleApp2Approach.Entities;
using ExampleApp.Model;

namespace ExamampleApp2Approach.Service
{
	public class HardwareService
	{
		private static List<Hardware> Hardwares;
		
		
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
			var result = new List<Hardware>();

			return result;
		}

		public List<Company> GetCompanies()
		{
			return new List<Company>()
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
		}


	}
}
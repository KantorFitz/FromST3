using System.Collections.Generic;
using ExamampleApp2Approach.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ExampleApp.Model
{
	public class HardwareModel
	{
		public HardwareModel()
		{
			var result = new List<Company>(); //change on serv class
			Companies = new SelectList(result, "Id", "Name");
		}

		public SelectList Companies { get; set; }
		public Hardware Hardware { get; set; }
	}
}
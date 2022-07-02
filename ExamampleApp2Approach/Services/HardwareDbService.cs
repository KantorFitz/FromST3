using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using Dapper;
using ExamampleApp2Approach.Entities;
using Microsoft.Data.SqlClient;

namespace ExamampleApp2Approach.Service
{
	public class HardwareDbService
	{
		private string connectionString = @"server=theshadowmoses\sqlexpress;database=Hardware;trusted_connection=true";

		public void Add(Hardware hardware)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				const string command = @"insert into Hardware 
								([Name], [Description], [Year], [NumberOfItems], [Price])
    							values
								(@Name, @Description, @Year, @NumberOfItems, @Price)";

				var db = new DynamicParameters();
				db.Add("@Name", hardware.Name);
				db.Add("@Description", hardware.Description);
				db.Add("@Year", hardware.Year);
				db.Add("@NumberOfItems", hardware.NumberOfItems);
				db.Add("@Price", hardware.Price);
				
			
				
				var result = connection.Execute(command, db);
			}
		}

		public List<Hardware> GetAll()
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				var result = connection.Query<Hardware>("Select * From Hardware").ToList();

				
				
				return result;
			}
		}
	}
}
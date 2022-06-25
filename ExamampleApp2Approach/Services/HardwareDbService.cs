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
		private string connectionString = @"server=localhost;database=examapleApp2Approach;trusted_connection=true";

		public void Add(Hardware hardware)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				var query = @"insert into Hardware 
								([Name], [Description], [Year], [NumberOfItems], [Price])
    							values
								(@Name, @Description, @Year, @NumberOfItems, @Price)";

				var db = new DynamicParameters();
				db.Add("@Name", hardware.Name);
				db.Add("@Description", hardware.Description);
				db.Add("@Year", hardware.Year);
				db.Add("@NumberOfItems", hardware.NumberOfItems);
				db.Add("@Price", hardware.Price);
				
			
				
				var result = connection.Execute(query, db);
			}
		}

		public List<Hardware> GetAll()
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				var result = connection.Query<Hardware>("Select * From Hardware").ToList();


				while (reader.Read())
				{
					var hardware = new Hardware();
					hardware.Id = reader.GetInt32(0);
					hardware.Name = reader.GetString(1);
					hardware.Description = reader.GetString(2);
					hardware.Price = reader.GetDecimal(3);
					hardware.Category = reader.GetString(4);
					result.Add(hardware);
				}

				return result;
			}

			{
			}
		}
	}
}
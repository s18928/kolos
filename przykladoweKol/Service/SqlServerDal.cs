using Microsoft.AspNetCore.Mvc;
using przykladoweKol.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace przykladoweKol.Service
{
    public class SqlServerDal : IAnimalDal
    {
        private const string ConString = "Data Source=db-mssql;Initial Catalog=s18928;Integrated Security=True";

        public IEnumerable<Animal> GetAnimals(string sortBy)
        {
            var list = new List<Animal>();

            using(var con = new SqlConnection(ConString))
            using(var com = new SqlCommand())
            {
                com.Connection = con;
                com.CommandText = "select * from Animal " +
                                    "INNER JOIN Owner ON Owner.IdOwner = Animal.IdOwner " +
                                    "Order By @sortBy";
                com.Parameters.AddWithValue("sortBy", sortBy);

                con.Open();
                var dr = com.ExecuteReader();

                while (dr.Read())
                {
                    var animal = new Animal();
                    animal.Name = dr["Animal.Name"].ToString();
                    animal.AnimalType = dr["Animal.Type"].ToString();
                    animal.DateOfAdmission = DateTime.Parse(dr["Animal.AdmissionDate"].ToString());
                    animal.LastNameOfOwner = dr["Owner.LastName"].ToString();

                    list.Add(animal);
                }
            }

            return list;
           
        }
    }
}

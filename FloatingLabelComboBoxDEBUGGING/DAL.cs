using Dapper;
using FloatingLabelComboBoxDEBUGGING.Models;
using System.Data;
using System.Data.SqlClient;

namespace MaterialDesignFixedHintTextBox
{
    public class DAL
    {
        private static readonly string ConnString = "Data Source=(local);Initial Catalog=CollegeDB;Integrated Security=True";

        //**********************************************************************************************************************************************

        public static async Task<List<StudentModel>> LoadStudentsAsync()
        {
            using (IDbConnection conn = new SqlConnection(ConnString))
            {
                var students = (await conn.QueryAsync<StudentModel>("SELECT * FROM Students")).ToList();
                return students;
            }
        }

        //**************************************************************************************************
        public static async Task<List<CountriesModel>> LoadCountriesAsync()
        {
            using (IDbConnection conn = new SqlConnection(ConnString))
            {
                var countries = (await conn.QueryAsync<CountriesModel>("SELECT * FROM Countries")).ToList();
                return countries;
            }
        }

        public static async Task<List<ProvincesModel>> LoadProvincesAsync()
        {
            using (IDbConnection conn = new SqlConnection(ConnString))
            {
                var provinces = (await conn.QueryAsync<ProvincesModel>("SELECT * FROM Provinces")).ToList();
                return provinces;
            }
        }


        public static async Task<List<DistrictsModel>> LoadDistrictsAsync()
        {
            using (IDbConnection conn = new SqlConnection(ConnString))
            {
                var districts = (await conn.QueryAsync<DistrictsModel>("SELECT * FROM Districts")).ToList();
                return districts;
            }
        }
    }
}

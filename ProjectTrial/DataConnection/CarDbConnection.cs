using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProjectTrial.DataConnection
{
    public class CarDbConnection
    {
        string sqlconnection = "Data Source=100.72.130.5;Initial Catalog=Training;Persist Security Info=True;User ID=TrainingUsr;Password=Tr@ininGU$r@#321";
        public string InsertCar(CarModel carModel)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlconnection);
            SqlCommand sqlCommandOj = new SqlCommand("insert into Car values("+"'" + carModel.car_model + "','" + carModel.category + "'," + carModel.prize + "," + carModel.Year_of_The_Model + ",'" + carModel.Description +"'"+ ")", sqlConnectionObj);
            sqlConnectionObj.Open();
            sqlCommandOj.ExecuteNonQuery();
            sqlConnectionObj.Close();
            return "Car details saved successfully";
        }
        public DataTable SelectCar()
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlconnection);
            SqlCommand sqlCommandOj = new SqlCommand("select * from Car", sqlConnectionObj);
            sqlConnectionObj.Open();
            SqlDataReader sqlDataReader = sqlCommandOj.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlDataReader);
            sqlConnectionObj.Close();
            return dt;
        }
        public string UpdateCar(CarModel carModel)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlconnection);
            SqlCommand sqlCommandOj = new SqlCommand("update Car set category='" + carModel.category + "',prize=" + carModel.prize + ", year_of_model= " + carModel.Year_of_The_Model +",Description='"+carModel.Description +"'"+" where car_model= '" + carModel.car_model +"'"+ "", sqlConnectionObj);
            sqlConnectionObj.Open();
            sqlCommandOj.ExecuteNonQuery();
            sqlConnectionObj.Close();
            return "Car details updated successfully";

        }
        public string DeleteCar(string car_model)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlconnection);
            SqlCommand sqlCommandOj = new SqlCommand("delete from Car where car_model='" + car_model + "'"+"", sqlConnectionObj);
            sqlConnectionObj.Open();
            sqlCommandOj.ExecuteNonQuery();
            sqlConnectionObj.Close();
            return "Car details deleted successfully";
        }

        public DataTable EditCarbyCategory(string car_model)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlconnection);
            SqlCommand sqlCommandOj = new SqlCommand("select * from Car where car_model='" + car_model + "'"+"", sqlConnectionObj);
            sqlConnectionObj.Open();
            SqlDataReader sqlDataReader = sqlCommandOj.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlDataReader);
            sqlConnectionObj.Close();
            return dt;
        }

    }
}
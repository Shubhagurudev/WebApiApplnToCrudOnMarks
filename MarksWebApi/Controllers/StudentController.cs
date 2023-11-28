using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.SqlClient;
using MarksWebApi.Models;
using System.Web.Mvc;
using MarksWebApi;

namespace MarksWebApi.Controllers
{
    public class StudentController : ApiController
    {
        public List<StudentModel> GetStudent()
        {
            SqlConnection cn = new SqlConnection("server = DESKTOP-KLA8RPE\\SQLEXPRESS;Integrated Security = true;database=MarksCrud");
            SqlCommand cmd = new SqlCommand("select * from Student", cn);
            cn.Open();          
            SqlDataReader dr = cmd.ExecuteReader();

            List<StudentModel> l = new List<StudentModel>();    
            while (dr.Read())
            {
               StudentModel m = new StudentModel();
                m.StudentRollNo = Convert.ToInt32(dr["StudentRollNo"]);
                m.StudentName = dr["StudentName"].ToString();
                m.ClassId = dr["ClassId"].ToString();
                m.SubjectName = dr["SubjectName"].ToString();             
                l.Add(m);                
            }
            cn.Close();
            return l;
        }      
    }
}

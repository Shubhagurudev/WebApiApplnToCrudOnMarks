using MarksWebApi.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MarksWebApi.Controllers
{
    public class SubjectMarksController : ApiController
    {
        public List<SubjectMdel> GetSubjectMarks()
        {
            SqlConnection cn = new SqlConnection("server = DESKTOP-KLA8RPE\\SQLEXPRESS;Integrated Security = true;database=MarksCrud");
            SqlCommand cmd = new SqlCommand("select * from SubjectMarks", cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            List<SubjectMdel> l = new List<SubjectMdel>();
            while (dr.Read())
            {
                SubjectMdel m = new SubjectMdel();
                m.StudentRollNo = Convert.ToInt32(dr["StudentRollNo"]);
                m.Marks = Convert.ToInt32(dr["Marks"]);


                l.Add(m);
            }
            cn.Close();
            return l;
        }


        public HttpStatusCode PostSubjectMarks(SubjectMdel sm)
        {
            SqlConnection cn = new SqlConnection("server = DESKTOP-KLA8RPE\\SQLEXPRESS;Integrated Security = true;database=MarksCrud");
            SqlCommand cmd = new SqlCommand("insert into SubjectMarks(StudentRollNo,Marks) values (@StudentRollNo,@Marks)", cn);
            cmd.Parameters.AddWithValue("@StudentRollNo", sm.StudentRollNo);
            cmd.Parameters.AddWithValue("@Marks", sm.Marks);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            return HttpStatusCode.OK;

        }

        public void PUTSubjectMarks(int id,SubjectMdel sm)
        {
            SqlConnection cn = new SqlConnection("server = DESKTOP-KLA8RPE\\SQLEXPRESS;Integrated Security = true;database=MarksCrud");

            SqlCommand cmd = new SqlCommand("Update SubjectMarks set Marks = @M where StudentRollNo=" + id, cn);          
            cmd.Parameters.AddWithValue("@M", sm.Marks);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public void DeleteSubjectMarks(int id)
        {
            SqlConnection cn = new SqlConnection("server = DESKTOP-KLA8RPE\\SQLEXPRESS;Integrated Security = true;database=MarksCrud");
            SqlCommand cmd = new SqlCommand("delete from SubjectMarks where StudentRollNo=" + id, cn);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}

        
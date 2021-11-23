using StudentRecordManagementSystem.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRecordManagementSystem.Models
{
    public class StudentDataAccessLayer
    {
        
      string connectionString = ConnectionString.CName;
      

        public IEnumerable<ToDo> GetAll()
        {
            List<ToDo> lstStudent = new List<ToDo>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spGetAll", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    ToDo ObjToDo = new ToDo();

                    ObjToDo.Id = Convert.ToInt32(rdr["Id"]);
                    ObjToDo.Notes = rdr["Notes"].ToString();
                    ObjToDo.Status = rdr["Status"].ToString();

                    if(rdr["ModifyDate"] != DBNull.Value)
                    {
                        ObjToDo.ComplitionDate = rdr["ModifyDate"].ToString();
                    }
                    else
                    {
                        ObjToDo.ComplitionDate = "";
                    }


                   
                    lstStudent.Add(ObjToDo);
                }
                con.Close();
            }
            return lstStudent;
        }


        public void Add(ToDo toDo)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAdd", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Notes", toDo.Notes);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void Update(ToDo toDo)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spUpdate", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", toDo.Id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public ToDo Get(int? id)
        {
            ToDo ObjToDo = new ToDo();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * FROM tblToDo WHERE Id= " + id;
                SqlCommand cmd = new SqlCommand(sqlQuery, con);

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    ObjToDo.Id = Convert.ToInt32(rdr["Id"]);
                    ObjToDo.Notes = rdr["Notes"].ToString();
                    ObjToDo.Status = rdr["Status"].ToString();                  
                }
            }
            return ObjToDo;
        }

        public void Delete(int? id)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spDelete", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}

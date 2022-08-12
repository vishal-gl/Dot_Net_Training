using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace New_Student
{
    class StudentSQL_Connection
    {
        SqlConnection conn;

        public StudentSQL_Connection()
        {
            conn = new SqlConnection("Server = NAG1-LHP_N76275; Database = newStudent; Integrated Security = SSPI");
        }

        public void ReadData()
        {
            SqlDataReader reader = null;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select Student.* ,Course.CName,Course.CTutor from Student  Inner Join Course on Student.CId=Course.CId  ", conn);
                reader = cmd.ExecuteReader();
                //Console.WriteLine(reader[0] + " "+reader[1]);
                while (reader.Read())
                {
                    //Console.WriteLine(reader[0] + " " + reader[1]);
                    Console.WriteLine("ID Name Age Standard City CourseName Tutor");
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.Write(reader[i] + "  ");
                    }
                    Console.WriteLine("");
                }
;            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        public void ReadData1()
        {
            SqlDataReader reader = null;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from Course", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("CId   CourseName  Tutor : ");
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.Write(reader[i] + " ");
                    }
                    Console.WriteLine("");
                }
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public bool InsertData(string name, string id, byte age, byte standard, string city,string cid)
        {
            try
            {
                conn.Open();
                string insertString = $"Insert into Student values('{id}','{name}','{age}','{standard}','{city}','{cid}')";

                SqlCommand cmd = new SqlCommand(insertString, conn);

                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public bool UpdateAge(string id, int age)
        {
            try
            {
                conn.Open();

                string UpdateString = $"update Student set Age = '{age}' where Id = '{id}";

                SqlCommand cmd = new SqlCommand(UpdateString, conn);

                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public bool UpdateCity(string id, string city)
        {
            try
            {
                conn.Open();

                string UpdateString = $"update Student set City = '{city}' where Id = '{id}'";

                SqlCommand cmd = new SqlCommand(UpdateString, conn);

                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public bool DeleteData(string id)
        {
            try
            {
                conn.Open();

                string DeleteString = $"delete from Student where Id = '{id}'";

                SqlCommand cmd = new SqlCommand(DeleteString, conn);

                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public int GetNumberOfRecords()
        {
            int count = -1;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select count(*) from Student", conn);

                count = (int)cmd.ExecuteScalar();
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return count;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using CommonLayer.Models;
using RespositoryLayer.Interfaces;

namespace RespositoryLayer.Services
{
    public class EmployeeRespository:IEmployeeRepository
    {
        string connectionstring = @"Data Source=LOKESH\SQLEXPRESS;Initial Catalog=MVCDB;Integrated Security=True";

        

        public IEnumerable<Employee> GetAllEmployees()
        {

            List<Employee> employees = new List<Employee>();

            using (SqlConnection conn = new SqlConnection(connectionstring))
            {

                SqlCommand cmd = new SqlCommand("empgetall_sp", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();
                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    Employee employee = new Employee();

                    employee.Id = Convert.ToInt32(dataReader["Id"]);
                    employee.Name = dataReader["Name"].ToString();
                    employee.ProfileImage = dataReader["ProfileImage"].ToString();
                    employee.Gender = dataReader["Gender"].ToString();
                    employee.Department = dataReader["Department"].ToString();
                    employee.Salary = Convert.ToInt64(dataReader["Salary"]);
                    employee.StartDate = Convert.ToDateTime(dataReader["StartDate"]);
                    employee.Notes = dataReader["Notes"].ToString();
                    employees.Add(employee);

                }
                conn.Close();
                return employees;
            }
        }

        public bool AddEmployee(Employee employee)
        {
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("empinsert_sp", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", employee.Id);
                    cmd.Parameters.AddWithValue("@name", employee.Name);
                    cmd.Parameters.AddWithValue("@profileimage", employee.ProfileImage);
                    cmd.Parameters.AddWithValue("@gender", employee.Gender);
                    cmd.Parameters.AddWithValue("@department", employee.Department);
                    cmd.Parameters.AddWithValue("@salary", employee.Salary);
                    cmd.Parameters.AddWithValue("@startdate", employee.StartDate);
                    cmd.Parameters.AddWithValue("@notes", employee.Notes);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
                return false;

            }
        }

        public Employee GetEmployeeById(int id)
        {
            Employee employee = new Employee();

            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("empbyid_sp", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id", id);
                    conn.Open();
                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {

                        employee.Id = Convert.ToInt32(dataReader["Id"]);
                        employee.Name = dataReader["Name"].ToString();
                        employee.ProfileImage = dataReader["ProfileImage"].ToString();
                        employee.Gender = dataReader["Gender"].ToString();
                        employee.Department = dataReader["Department"].ToString();
                        employee.Salary = Convert.ToInt64(dataReader["Salary"]);
                        employee.StartDate = Convert.ToDateTime(dataReader["StartDate"]);
                        employee.Notes = dataReader["Notes"].ToString();

                    }
                    return employee;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
                return null;

            }
        }

        public bool UpdateEmployee(Employee employee)
        {
            using(SqlConnection conn = new SqlConnection(connectionstring))
            {
                try
                {
                    conn.Open ();
                    SqlCommand cmd = new SqlCommand("empedit_sp", conn);
                    cmd.CommandType= CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", employee.Id);
                    cmd.Parameters.AddWithValue("@name", employee.Name);
                    cmd.Parameters.AddWithValue("@profileimage", employee.ProfileImage);
                    cmd.Parameters.AddWithValue("@gender", employee.Gender);
                    cmd.Parameters.AddWithValue("@department", employee.Department);
                    cmd.Parameters.AddWithValue("@salary", employee.Salary);
                    cmd.Parameters.AddWithValue("@startdate", employee.StartDate);
                    cmd.Parameters.AddWithValue("@notes",employee.Notes);
                    cmd.ExecuteNonQuery ();
                    return true;


                }catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    conn.Close ();
                }
                return false;
            }
        }

        public bool DeleteEmployee(int id)
        {
            using( SqlConnection conn = new SqlConnection(connectionstring))
            {
                try
                {
                    conn.Open ();

                    SqlCommand cmd = new SqlCommand("empdelete_sp", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    return true;


                }catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }finally
                {
                    conn.Close ();
                }
                return false;
            }
        }


    }
}

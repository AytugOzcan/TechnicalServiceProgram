using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TechnicalService.Managers;
using TechnicalService.Models;

namespace TechnicalService.DAL
{
    public class UserDAL:SqlManager
    {
        public List<User> GetUserList()
        {
            List<User> UserList = new List<User>();
            SqlDataReader dr = GetList("SELECT * FROM users WHERE user_active = 1");
            while (dr.Read())
            {
                User user = new User();
                user.user_id = Convert.ToInt16(dr[0]);
                user.user_name = dr[1].ToString();

                UserList.Add(user);
            }
            connection.Close();
            return UserList;
        }

        public string UserQuery(string user_name)
        {
            string result = "";
            try
            {
                string query = "SELECT COUNT(user_id) FROM users WHERE user_name = '" + user_name + "'";
                int user_exist_result = Convert.ToInt16(ExecuteGetData(query));
                if (user_exist_result == 1)
                {
                    result = "This user exists.";
                }
                else
                {
                    result = "User not found!";
                }

                return result;
                }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string UserAdd(string user_name, string pwd)
        {
            string result = "";
            try
            {
                    string addQuery = "INSERT INTO users(user_name,user_password,user_active) VALUES ('" + user_name + "', '" + pwd + "', 1)";
                    ExecuteQuery(addQuery);

                    string query = "SELECT COUNT(user_id) FROM users WHERE user_name = '" + user_name + "'";
                    int user_exist_result = Convert.ToInt16(ExecuteGetData(query));
                    if (user_exist_result > 0)
                    {
                        result = "Successful";
                        GetUserList();
                    }

                    else
                    {
                        result = "Failed to add record!";
                        GetUserList();
                    }
                return result;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string UserUpdate(string id, string user_name, string password)
        {
            string result = "";
            try
            {
                string query = "SELECT COUNT(user_id) FROM users WHERE user_id !='" + id + "' AND user_name = '" + user_name + "'";
                int user_exist_result = Convert.ToInt16(ExecuteGetData(query));
                if (user_exist_result == 0)
                {
                    string updateQuery = "UPDATE users SET user_name='" + user_name + "', user_password= '" + password + "' WHERE user_id='" + id + "'";
                    ExecuteQuery(updateQuery);
                    result = "Successful";
                }
                else
                {
                    result = "This user name already exists!";
                }
                return result;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string UserPassive(string id)
        {
            string result = "";
            try
            {
                string query = "SELECT COUNT(user_id) FROM users WHERE user_id ='" + id + "'";
                int user_exist_result = Convert.ToInt16(ExecuteGetData(query));
                if (user_exist_result > 0)
                {
                    string updateQuery = "UPDATE users SET user_active = 0 WHERE user_id='" + id + "'";
                    ExecuteQuery(updateQuery);
                    result = "Successful";
                }
                else
                {
                    result = "There is no such user!";
                }
                return result;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string UserDelete(string id)
        {
            string result = "";
            try
            {
                string query = "SELECT COUNT(user_id) FROM users WHERE user_id ='" + id + "'";
                int user_exist_result = Convert.ToInt16(ExecuteGetData(query));
                if (user_exist_result > 0)
                {
                    query = "SELECT COUNT(employee_id) FROM employees WHERE employee_user_id ='" + id + "'";
                    int employee_exist_result = Convert.ToInt16(ExecuteGetData(query));
                    if (employee_exist_result == 0)
                    {
                        string deleteQuery = "DELETE FROM users WHERE user_id='" + id + "'";
                        ExecuteQuery(deleteQuery);
                        result = "Successful";
                    }
                    else
                    {
                        result = "This username cannot be deleted because it is linked to a employee!";
                    }
                }
                else
                {
                    result = "User not found!";
                }
                return result;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
}

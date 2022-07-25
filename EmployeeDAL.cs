using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TechnicalService.Managers;
using TechnicalService.Models;

namespace TechnicalService.DAL
{
    class EmployeeDAL : SqlManager
    {
        public List<Employee> GetEmployeeList()
        {
            List<Employee> EmployeeList = new List<Employee>();
            SqlDataReader dr = GetList("SELECT employees.employee_id, employees.employee_fullname, employees.employee_phone, employees.employee_email, employees.employee_address, employees.employee_salary, users.user_name, roles.role_name FROM employees INNER JOIN roles ON employees.employee_role_id = roles.role_id  INNER JOIN users ON employees.employee_user_id = users.user_id WHERE employees.employee_active = '1'");
            while (dr.Read())
            {
                Employee employee = new Employee();
                employee.employee_id = Convert.ToInt16(dr[0]);
                employee.employee_fullname = dr[1].ToString();
                employee.employee_phone = dr[2].ToString();
                employee.employee_email = dr[3].ToString();
                employee.employee_address = dr[4].ToString();
                employee.employee_salary = dr[5].ToString();
                employee.user_name = dr[6].ToString();
                employee.role_name = dr[7].ToString();
                EmployeeList.Add(employee);
            }
            connection.Close();
            return EmployeeList;
        }

        public string EmployeeAdd(string full_name, string phone_number, string email, string address, string salary, string role_id, string user_id)
        {
            string result = "";
            try
            {
                string query = "SELECT COUNT(employee_id) FROM employees WHERE employee_user_id = '" + user_id + "' OR employee_phone = '" + phone_number + "' OR employee_email = '" + email + "'";
                int employee_exist_result = Convert.ToInt16(ExecuteGetData(query));
                if (employee_exist_result == 0)
                {
                    string addQuery = "INSERT INTO employees(employee_fullname,employee_phone,employee_email,employee_address,employee_salary,employee_role_id,employee_user_id,employee_active) VALUES ('" + full_name + "', '" + phone_number + "', '" + email + "', '" + address + "', '" + salary + "', '" + role_id + "', '" + user_id + "', 1)";
                    ExecuteQuery(addQuery);

                    query = "SELECT COUNT(employee_id) FROM employees WHERE employee_phone = '" + phone_number + "'";
                    employee_exist_result = Convert.ToInt16(ExecuteGetData(query));
                    if (employee_exist_result > 0)
                    {
                        GetEmployeeList();
                        result = "Successful";
                    }
                    else
                    {
                        GetEmployeeList();
                        result = "Failed to add record!";
                    }
                }
                else
                {
                    result = "There is already a employee registered at this user name, phone number or email address!";
                }
                return result;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        
        public string EmployeeUpdate(string id, string full_name, string phone_number, string email, string address, string salary, string employee_role_id, string emp_user_id)
        {
            string result = "";
            try
            {
                string query = "SELECT COUNT(employee_id) FROM employees WHERE employee_id !='" + id + "' AND (employee_user_id = '" + emp_user_id + "' OR employee_phone = '" + phone_number + "' OR employee_email = '" + email + "')";
                int employee_exist_result = Convert.ToInt16(ExecuteGetData(query));
                if (employee_exist_result == 0)
                {
                    string updateQuery = "UPDATE employees SET employee_fullname='" + full_name + "', employee_phone= '" + phone_number + "', employee_email='" + email + "', employee_address='" + address + "', employee_salary = '" + salary + "', employee_role_id = '" + employee_role_id + "', employee_user_id = '" + emp_user_id + "' WHERE employee_id='" + id + "'";
                    ExecuteQuery(updateQuery);
                    result = "Successful";
                }
                else
                {
                    result = "There is already a employee registered at this user name, phone number or email address!";
                }
                return result;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string employeePassive(string id)
        {
            string result = "";
            try
            {
                string updateQuery = "UPDATE employees SET employee_active = '0' WHERE employee_id='" + id + "'";
                ExecuteQuery(updateQuery);
                result = "Successful";
                return result;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

       
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TechnicalService.Managers;
using TechnicalService.Models;

namespace TechnicalService.DAL
{
    class CustomerDAL:SqlManager
    {

        public List<Customer> GetCustomerList()
        {
            List<Customer> CustomerList = new List<Customer>();
            SqlDataReader dr = GetList("SELECT * FROM customers");
            while (dr.Read())
            {
                Customer customer = new Customer();
                customer.customer_id = Convert.ToInt16(dr[0]);
                customer.customer_fullname = dr[1].ToString();
                customer.customer_phone = dr[2].ToString();
                customer.customer_email = dr[3].ToString();
                customer.customer_address = dr[4].ToString();
                CustomerList.Add(customer);
            }
            connection.Close();
            return CustomerList;
        }

        public string CustomerAdd(string full_name, string phone_number, string email, string address)
        {
            string result = "";
            try
            {
                string query = "SELECT COUNT(customer_id) FROM customers WHERE customer_phone = '" + phone_number + "' OR customer_email = '" + email + "'";
                int customer_exist_result = Convert.ToInt16(ExecuteGetData(query));
                if (customer_exist_result == 0)
                {
                    string addQuery = "INSERT INTO customers(customer_fullname,customer_phone,customer_email,customer_address) VALUES ('" + full_name + "', '" + phone_number + "', '" + email + "', '" + address + "')";
                    ExecuteQuery(addQuery);

                    query = "SELECT COUNT(customer_id) FROM customers WHERE customer_phone = '" + phone_number + "'";
                    customer_exist_result = Convert.ToInt16(ExecuteGetData(query));
                    if (customer_exist_result > 0)
                    {
                        GetCustomerList();
                        result = "Successful";
                    }

                    else
                    {
                        GetCustomerList();
                        result = "Failed to add record!";
                    }
                }
                else
                {
                    result = "There is already a customer registered at this phone number or e-mail address!";
                }
                return result;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string CustomerUpdate(string id, string full_name, string phone_number, string email, string address)
        {
            string result = "";
            try
            {
                string query = "SELECT COUNT(customer_id) FROM customers WHERE customer_id !='" + id + "' AND (customer_phone = '" + phone_number + "' OR customer_email = '" + email + "')";
                int contact_exist_result = Convert.ToInt16(ExecuteGetData(query));
                if (contact_exist_result == 0)
                {
                    string updateQuery = "UPDATE customers SET customer_fullname='" + full_name + "', customer_phone= '" + phone_number + "', customer_email='" + email + "', customer_address='" + address + "' WHERE customer_id='" + id + "'";
                    ExecuteQuery(updateQuery);
                    result = "Successful";
                }
                else
                {
                    result = "There is already a customer registered at this phone number or e-mail address!";
                }
                return result;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string GetCustomerPhone(string cst_id)
        {
            string result = "";
            try
            {
                string query = "SELECT customer_phone FROM customers WHERE customer_id = '" + cst_id + "'";
                result = ExecuteGetData(query);
                return result;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
}

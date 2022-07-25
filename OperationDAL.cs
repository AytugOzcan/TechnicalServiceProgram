using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TechnicalService.Managers;
using TechnicalService.Models;

namespace TechnicalService.DAL
{
    class OperationDAL : SqlManager
    {
        public List<Operation> GetOperationList()
        {
            List<Operation> OperationList = new List<Operation>();
            SqlDataReader dr = GetList("SELECT * FROM operations WHERE operation_active = '1'");
            while (dr.Read())
            {
                Operation operation = new Operation();
                operation.operation_id = Convert.ToInt16(dr[0]);
                operation.operation_name = dr[1].ToString();
                operation.operation_price = dr[2].ToString();

                OperationList.Add(operation);
            }
            connection.Close();
            return OperationList;
        }

        public string operationAdd(string operationName, string operationPrice)
        {
            string result = "";
            try
            {
                string query = "SELECT COUNT(operation_id) FROM operations WHERE operation_name = '" + operationName + "'";
                int operation_exist_result = Convert.ToInt16(ExecuteGetData(query));
                if (operation_exist_result == 0)
                {
                    string addQuery = "INSERT INTO operations(operation_name,operation_price,operation_active) VALUES ('" + operationName + "', '" + operationPrice + "', 1)";
                    ExecuteQuery(addQuery);

                    query = "SELECT COUNT(operation_id) FROM operations WHERE operation_name = '" + operationName + "'";
                    operation_exist_result = Convert.ToInt16(ExecuteGetData(query));
                    if (operation_exist_result > 0)
                    {
                        GetOperationList();
                        result = "Successful";
                    }

                    else
                    {
                        GetOperationList();
                        result = "Failed to add record!";
                    }
                }
                else
                {
                    result = "This operation already exists!";
                }
                return result;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string operationUpdate(string id, string operationName, string operationPrice)
        {
            string result = "";
            try
            {
                string query = "SELECT COUNT(operation_id) FROM operations WHERE operation_id != '" + id + "' AND operation_name = '" + operationName + "' ";
                int operation_exist_result = Convert.ToInt16(ExecuteGetData(query));
                if (operation_exist_result == 0)
                {
                    string updateQuery = "UPDATE operations SET operation_name = '" + operationName + "', operation_price = '" + operationPrice + "' WHERE operation_id = '" + id + "'";
                    ExecuteQuery(updateQuery);
                    result = "Successful";
                }
                else
                {
                    result = "This operation is already registered!";
                }
                return result;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string operationPassive(string id)
        {
            string result = "";
            try
            {
                string updateQuery = "UPDATE operations SET operation_active = '0' WHERE operation_id='" + id + "'";
                ExecuteQuery(updateQuery);
                result = "Successful";
                return result;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string operationIdQuery(string oprName)
        {
            string result = "";
            string query = "";
            try
            {
                query = "SELECT COUNT(operation_id) FROM operations WHERE operation_name = '" + oprName + "' AND operation_active = 1";
                int operation_exist_result = Convert.ToInt16(ExecuteGetData(query));
                if (operation_exist_result == 0)
                {
                    result = "Operation not found!";
                }
                else
                {
                    query = "SELECT operation_id FROM operations WHERE operation_name = '" + oprName + "'";
                    result = ExecuteGetData(query);
                }
                return result;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string operationPriceQuery(string oprName)
        {
            string result = "";
            string query = "";
            try
            {
                query = "SELECT COUNT(operation_id) FROM operations WHERE operation_name = '" + oprName + "' AND operation_active = 1";
                int operation_exist_result = Convert.ToInt16(ExecuteGetData(query));
                if (operation_exist_result == 0)
                {
                    result = "Operation not found!";
                }
                else
                {
                    query = "SELECT operation_price FROM operations WHERE operation_name = '" + oprName + "'";
                    result = ExecuteGetData(query);
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

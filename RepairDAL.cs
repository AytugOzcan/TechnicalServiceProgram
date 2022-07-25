using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TechnicalService.Managers;
using TechnicalService.Models;

namespace TechnicalService.DAL
{
    class RepairDAL : SqlManager
    {
        public List<PendingDevices> GetPendingDevicesList()
        {
            List<PendingDevices> PendingDevicesList = new List<PendingDevices>();
            SqlDataReader dr = GetList("SELECT repairs.repair_id, repairs.received_time, device_types.device_type_name, device_brands.device_brand_name, device_models.device_model_name, operations.operation_name, repairs.repair_description, employees.employee_fullname, customers.customer_fullname FROM   repairs INNER JOIN device_models ON repairs.device_model_id = device_models.device_model_id INNER JOIN device_types ON device_models.device_type_id = device_types.device_type_id INNER JOIN device_brands ON device_models.device_brand_id = device_brands.device_brand_id INNER JOIN operations ON repairs.operation_id = operations.operation_id INNER JOIN employees ON repairs.employee_id = employees.employee_id INNER JOIN customers ON repairs.customer_id = customers.customer_id WHERE repairs.repaired != '1' AND repairs.delivered != '1'");
            while (dr.Read())
            {
                PendingDevices pendingDevices = new PendingDevices();
                pendingDevices.repair_id = Convert.ToInt16(dr[0]);
                pendingDevices.received_time = dr[1].ToString();
                pendingDevices.device_type_name = dr[2].ToString();
                pendingDevices.device_brand_name = dr[3].ToString();
                pendingDevices.device_model_name = dr[4].ToString();
                pendingDevices.operation_name = dr[5].ToString();
                pendingDevices.repair_description = dr[6].ToString();
                pendingDevices.employee_fullname = dr[7].ToString();
                pendingDevices.customer_fullname = dr[8].ToString();

                PendingDevicesList.Add(pendingDevices);
            }
            connection.Close();
            return PendingDevicesList;
        }

        public List<RepairedDevices> GetRepairedDevicesList()
        {
            List<RepairedDevices> RepairedDevicesList = new List<RepairedDevices>();
            SqlDataReader dr = GetList("SELECT repairs.repair_id, repairs.repaired_time, device_types.device_type_name, device_brands.device_brand_name, device_models.device_model_name, operations.operation_name, repairs.repair_description, employees.employee_fullname, customers.customer_fullname FROM   repairs INNER JOIN device_models ON repairs.device_model_id = device_models.device_model_id INNER JOIN device_types ON device_models.device_type_id = device_types.device_type_id INNER JOIN device_brands ON device_models.device_brand_id = device_brands.device_brand_id INNER JOIN operations ON repairs.operation_id = operations.operation_id INNER JOIN employees ON repairs.employee_id = employees.employee_id INNER JOIN customers ON repairs.customer_id = customers.customer_id WHERE repairs.repaired = '1' AND repairs.delivered = '0'");
            while (dr.Read())
            {
                RepairedDevices repairedDevices = new RepairedDevices();
                repairedDevices.repair_id = Convert.ToInt16(dr[0]);
                repairedDevices.repaired_time = dr[1].ToString();
                repairedDevices.device_type_name = dr[2].ToString();
                repairedDevices.device_brand_name = dr[3].ToString();
                repairedDevices.device_model_name = dr[4].ToString();
                repairedDevices.operation_name = dr[5].ToString();
                repairedDevices.repair_description = dr[6].ToString();
                repairedDevices.employee_fullname = dr[7].ToString();
                repairedDevices.customer_fullname = dr[8].ToString();

                RepairedDevicesList.Add(repairedDevices);
            }
            connection.Close();
            return RepairedDevicesList;
        }

        public List<DeliveredDevices> GetDeliveredDevicesList()
        {
            List<DeliveredDevices> DeliveredDevicesList = new List<DeliveredDevices>();
            SqlDataReader dr = GetList("SELECT repairs.repair_id, repairs.delivered_time, device_types.device_type_name, device_brands.device_brand_name, device_models.device_model_name, operations.operation_name, repairs.repair_description, employees.employee_fullname, customers.customer_fullname FROM   repairs INNER JOIN device_models ON repairs.device_model_id = device_models.device_model_id INNER JOIN device_types ON device_models.device_type_id = device_types.device_type_id INNER JOIN device_brands ON device_models.device_brand_id = device_brands.device_brand_id INNER JOIN operations ON repairs.operation_id = operations.operation_id INNER JOIN employees ON repairs.employee_id = employees.employee_id INNER JOIN customers ON repairs.customer_id = customers.customer_id WHERE repairs.delivered = '1'");
            while (dr.Read())
            {
                DeliveredDevices deliveredDevices = new DeliveredDevices();
                deliveredDevices.repair_id = Convert.ToInt16(dr[0]);
                deliveredDevices.delivered_time = dr[1].ToString();
                deliveredDevices.device_type_name = dr[2].ToString();
                deliveredDevices.device_brand_name = dr[3].ToString();
                deliveredDevices.device_model_name = dr[4].ToString();
                deliveredDevices.operation_name = dr[5].ToString();
                deliveredDevices.repair_description = dr[6].ToString();
                deliveredDevices.employee_fullname = dr[7].ToString();
                deliveredDevices.customer_fullname = dr[8].ToString();

                DeliveredDevicesList.Add(deliveredDevices);
            }
            connection.Close();
            return DeliveredDevicesList;
        }

        public string GetCustomerID(int a, string repairid)
        {
            string result = "";
            string query = "";
            try
            {
                if (a == 1)
                {
                    query = "SELECT customer_id FROM repairs WHERE repair_id = '" + repairid + "'";
                    result = ExecuteGetData(query);
                }
                else if (a == 2)
                {
                    query = "SELECT COUNT(customer_id) FROM customers WHERE customer_phone = '" + repairid + "'";
                    int customer_exist_result = Convert.ToInt16(ExecuteGetData(query));
                    if (customer_exist_result == 0)
                    {
                        result = "Customer not found!";
                    }
                    else
                    {
                        query = "SELECT customer_id FROM customers WHERE customer_phone = '" + repairid + "'";
                        result = ExecuteGetData(query);
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string GetTechnicianID(string repair_id)
        {
            string result = "";
            string query = "SELECT COUNT(employee_id) FROM repairs WHERE repair_id = '" + repair_id + "'";
            int technician_exist_result = Convert.ToInt16(ExecuteGetData(query));
            if (technician_exist_result == 0)
            {
                result = "Technician not found!";
            }
            else
            {
                query = "SELECT employee_id FROM repairs WHERE repair_id = '" + repair_id + "'";
                result = ExecuteGetData(query);
            }
            return result;
        }

        public List<Technician> GetTechnicianList()
        {
            List<Technician> TechnicianList = new List<Technician>();
            string query = "SELECT employees.employee_id, employees.employee_fullname FROM employees INNER JOIN roles ON employees.employee_role_id = roles.role_id INNER JOIN auths ON roles.role_auth_id = auths.auth_id WHERE auth_repaired = 1 AND employee_active = 1 AND role_active = 1";
            SqlDataReader dr = GetList(query);
            while (dr.Read())
            {
                Technician technician = new Technician();
                technician.employee_id = Convert.ToInt16(dr[0]);
                technician.employee_fullname = dr[1].ToString();
                TechnicianList.Add(technician);
            }
            connection.Close();
            return TechnicianList;
        }
        
        public string RepairAdd(string repair_description, string received_time, string customer_id, string device_model_id, string operation_id, string employee_id)
        {
            string addQuery = "INSERT INTO repairs(repair_description,received_time,repaired,delivered,customer_id,device_model_id,operation_id,employee_id) VALUES ('" + repair_description + "', '" + received_time + "', 0, 0,  '" + customer_id + "', '" + device_model_id + "', '" + operation_id + "', '" + employee_id + "')";
            ExecuteQuery(addQuery);
            string result = "Adding successful.";
            return result;
        }

        public string RepairUpdate(string id, string repair_description, string received_time, string customer_id, string device_model_id, string operation_id, string employee_id)
        {
            string updateQuery = "UPDATE repairs SET repair_description = '" + repair_description + "', received_time = '" + received_time + "', customer_id = '" + customer_id + "', device_model_id = '" + device_model_id + "', operation_id = '" + operation_id + "', employee_id = '" + employee_id + "' WHERE repair_id='" + id + "'";
            ExecuteQuery(updateQuery);
            string result = "Successful";
            return result;
        }

        public string DeviceRepaired(string repair_id, string repaired_time)
        {
            string result = "";
            string query = "SELECT COUNT(customer_id) FROM repairs WHERE repaired = '0' AND delivered = '0' AND repair_id = '" + repair_id + "'";
            int device_exists = Convert.ToInt16(ExecuteGetData(query));
            if (device_exists == 0)
            {
                result = "Record not found!";
            }
            else
            {
                string updateQuery = "UPDATE repairs SET repaired = 1, repaired_time = '" + repaired_time + "' WHERE repair_id='" + repair_id + "'";
                ExecuteQuery(updateQuery);
                result = "Successful";
            }
            return result;
        }

        public string CountRepaired(string customer_id)
        {
            string result = "";
            string query = "SELECT COUNT(customer_id) FROM repairs WHERE repaired = 1 AND customer_id = '" + customer_id + "'";
            result = ExecuteGetData(query);
            return result;
        }

        public string CountDelivered(string customer_id)
        {
            string result = "";
            string query = "SELECT COUNT(customer_id) FROM repairs WHERE delivered = 1 AND customer_id = '" + customer_id + "'";
            result = ExecuteGetData(query);
            return result;
        }

        public string DeviceDelivered(string repair_id, string delivered_time, string payment_price, int payment_discount)
        {
            string result = "";
            string query = "SELECT COUNT(customer_id) FROM repairs WHERE repaired = '1' AND delivered = '0' AND repair_id = '" + repair_id +"'";
            int device_exists = Convert.ToInt16(ExecuteGetData(query));
            if (device_exists == 0)
            {
                result = "Record not found!";
            }
            else
            {
                string updateQuery = "UPDATE repairs SET delivered = 1, delivered_time = '" + delivered_time + "' WHERE repair_id='" + repair_id + "'";
                ExecuteQuery(updateQuery);
                updateQuery = "INSERT INTO payments(payment_price, payment_discount, payment_repair_id, payment_active) VALUES ('" + payment_price  + "', '" + payment_discount +"', '" + repair_id + "', 1)";
                ExecuteQuery(updateQuery);
                result = "Successful";
            }
            return result;
        }

    }
}

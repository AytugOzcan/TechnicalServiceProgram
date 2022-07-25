using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TechnicalService.Managers;
using TechnicalService.Models;

namespace TechnicalService.DAL
{
    class EmpRoleDAL : SqlManager
    {
        public List<Role> GetRoleList()
        {
            List<Role> RoleList = new List<Role>();
            SqlDataReader dr = GetList("SELECT roles.role_id, roles.role_name, auths.auth_employee, auths.auth_user, auths.auth_device, auths.auth_operation, auths.auth_payment, auths.auth_customer, auths.auth_repair_reg, auths.auth_repaired, auths.auth_delivered FROM roles INNER JOIN auths ON roles.role_auth_id = auths.auth_id WHERE roles.role_active = '1'");
            while (dr.Read())
            {
                Role role = new Role();
                role.role_id = Convert.ToInt16(dr[0]);
                role.role_name = dr[1].ToString();
                role.auth_employee = dr[2].ToString();
                role.auth_user = dr[3].ToString();
                role.auth_device = dr[4].ToString();
                role.auth_operation = dr[5].ToString();
                role.auth_payment = dr[6].ToString();
                role.auth_customer = dr[7].ToString();
                role.auth_repair_reg = dr[8].ToString();
                role.auth_repaired = dr[9].ToString();
                role.auth_delivered = dr[10].ToString();
                RoleList.Add(role);
            }
            connection.Close();
            return RoleList;
        }

        public string authsAdd(string auths_Employee, string auths_User, string auths_Device, string auths_Operation, string auths_Payment, string auths_Customer, string auths_RepairReg, string auths_Repair, string auths_Delivery)
        {
            string result = "";
            try
            {
                string query = "SELECT COUNT(auth_id) FROM auths WHERE auth_employee = '" + auths_Employee + "' AND auth_user = '" + auths_User + "' AND auth_device = '" + auths_Device + "' AND auth_operation = '" + auths_Operation + "' AND auth_payment = '" + auths_Payment + "' AND auth_customer = '" + auths_Customer + "' AND auth_repair_reg = '" + auths_RepairReg + "' AND auth_repaired = '" + auths_Repair + "' AND auth_delivered = '" + auths_Delivery + "'";
                int auth_exist_result = Convert.ToInt16(ExecuteGetData(query));
                if (auth_exist_result == 0)
                {
                    string addQuery = "INSERT INTO auths(auth_employee, auth_user, auth_device, auth_operation, auth_payment, auth_customer, auth_repair_reg, auth_repaired, auth_delivered) VALUES ('" + auths_Employee + "', '" + auths_User + "', '" + auths_Device + "', '" + auths_Operation + "', '" + auths_Payment + "', '" + auths_Customer + "', '" + auths_RepairReg + "', '" + auths_Repair + "', '" + auths_Delivery + "')";
                    ExecuteQuery(addQuery);
                    string idQuery = "SELECT auth_id FROM auths WHERE auth_employee = '" + auths_Employee + "' AND auth_user = '" + auths_User + "' AND auth_device = '" + auths_Device + "' AND auth_operation = '" + auths_Operation + "' AND auth_payment = '" + auths_Payment + "' AND auth_customer = '" + auths_Customer + "' AND auth_repair_reg = '" + auths_RepairReg + "' AND auth_repaired = '" + auths_Repair + "' AND auth_delivered = '" + auths_Delivery + "'";
                    result = ExecuteGetData(idQuery);
                }
                else
                {
                    string idQuery = "SELECT auth_id FROM auths WHERE auth_employee = '" + auths_Employee + "' AND auth_user = '" + auths_User + "' AND auth_device = '" + auths_Device + "' AND auth_operation = '" + auths_Operation + "' AND auth_payment = '" + auths_Payment + "' AND auth_customer = '" + auths_Customer + "' AND auth_repair_reg = '" + auths_RepairReg + "' AND auth_repaired = '" + auths_Repair + "' AND auth_delivered = '" + auths_Delivery + "'";
                    idQuery = ExecuteGetData(idQuery);
                    query = "SELECT COUNT(role_id) FROM roles WHERE role_auth_id = '" + idQuery + "' AND role_active = '0'";
                    int is_the_role_passive = Convert.ToInt16(ExecuteGetData(query));
                    if (is_the_role_passive == 0)
                    {
                        result = "These authorizations are already registered in an active role!";
                    }
                    else
                    {
                        result = " " + idQuery;
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string authidQuery(string role_id)
        {
            string query = "SELECT role_auth_id FROM roles WHERE role_id = '"+ role_id +"'";
            return query = ExecuteGetData(query);
        }

        public string authsUpdate(string id, string auths_Employee, string auths_User, string auths_Device, string auths_Operation, string auths_Payment, string auths_Customer, string auths_RepairReg, string auths_Repair, string auths_Delivery)
        {
            string result = "";
            try
            {
                string query = "SELECT COUNT(auth_id) FROM auths WHERE auth_id != '" + id + "' AND auth_employee = '" + auths_Employee + "' AND auth_user = '" + auths_User + "' AND auth_device = '" + auths_Device + "' AND auth_operation = '" + auths_Operation + "' AND auth_payment = '" + auths_Payment + "' AND auth_customer = '" + auths_Customer + "' AND auth_repair_reg = '" + auths_RepairReg + "' AND auth_repaired = '" + auths_Repair + "' AND auth_delivered = '" + auths_Delivery + "'";
                int auth_exist_result = Convert.ToInt16(ExecuteGetData(query));
                if (auth_exist_result == 0)
                {
                    string updateQuery = "UPDATE auths SET auth_employee = '" + auths_Employee + "', auth_user = '" + auths_User + "', auth_device = '" + auths_Device + "', auth_operation = '" + auths_Operation + "', auth_payment = '" + auths_Payment + "', auth_customer = '" + auths_Customer + "', auth_repair_reg = '" + auths_RepairReg + "', auth_repaired = '" + auths_Repair + "', auth_delivered = '" + auths_Delivery + "' WHERE auth_id ='" + id + "'";
                    ExecuteQuery(updateQuery);
                    result = "Successful";
                }
                else
                {
                    result = "These auths is already registered!";
                }
                return result;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }



        public string roleAdd(string role_name, string auth_id)
        {
            string result = "";
            try
            {
                string query = "SELECT COUNT(role_id) FROM roles WHERE role_name = '" + role_name + "'";
                int role_exist_result = Convert.ToInt16(ExecuteGetData(query));
                if (role_exist_result == 0)
                {
                                
                    string addQuery = "INSERT INTO roles(role_name, role_auth_id, role_active) VALUES ('" + role_name + "', '" + auth_id + "', 1)";
                    ExecuteQuery(addQuery);

                    query = "SELECT COUNT(role_id) FROM roles WHERE role_name = '" + role_name + "'";
                    role_exist_result = Convert.ToInt16(ExecuteGetData(query));
                    if (role_exist_result > 0)
                    {
                        GetRoleList();
                        result = "Successful";
                    }

                    else
                    {
                        GetRoleList();
                        result = "Failed to add record!";
                    }
                }
                else
                {
                    result = "This role already exists!";
                }
                return result;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string roleUpdate(string id, string role_name)
        {
            string result = "";
            try
            {
                string query = "SELECT COUNT(role_id) FROM roles WHERE role_id !='" + id + "' AND  role_name = '" + role_name + "'";
                int role_exist_result = Convert.ToInt16(ExecuteGetData(query));
                if (role_exist_result == 0)
                {
                    string updateQuery = "UPDATE roles SET role_name = '" + role_name + "' WHERE role_id='" + id + "'";
                    ExecuteQuery(updateQuery);
                    result = "Successful";
                }
                else
                {
                    result = "This role is already registered!";
                }
                return result;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string rolePassive(string id)
        {
            string result = "";
            try
            {
                string updateQuery = "UPDATE roles SET role_active = '0' WHERE role_id='" + id + "'";
                ExecuteQuery(updateQuery);
                result = "Successful";
                return result;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string roleActive(string id)
        {
            string result = "";
            try
            {
                string updateQuery = "UPDATE roles SET role_active = '1' WHERE role_id='" + id + "'";
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

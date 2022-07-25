using System;
using TechnicalService.Managers;

namespace TechnicalService.DAL
{
    public class ManagerAuthDAL : SqlManager
    {
        public string Authority(int a, string user_id)
        {
            string result = "";
            try
            {
                string auth_query = "";
                string query = "SELECT role_auth_id FROM roles WHERE role_id IN (SELECT employee_role_id FROM employees WHERE employee_user_id = '" + user_id + "' AND employee_active = 1) AND role_active = 1";
                if (a == 1) { auth_query = "SELECT auth_employee FROM auths WHERE auth_id IN (" + query + ")"; }
                else if (a == 2) { auth_query = "SELECT auth_user FROM auths WHERE auth_id IN (" + query + ")"; }
                else if (a == 3) { auth_query = "SELECT auth_device FROM auths WHERE auth_id IN (" + query + ")"; }
                else if (a == 4) { auth_query = "SELECT auth_operation FROM auths WHERE auth_id IN (" + query + ")"; }
                else if (a == 5) { auth_query = "SELECT auth_payment FROM auths WHERE auth_id IN (" + query + ")"; }
                else if (a == 6) { auth_query = "SELECT auth_customer FROM auths WHERE auth_id IN (" + query + ")"; }
                else if (a == 7) { auth_query = "SELECT auth_repair_reg FROM auths WHERE auth_id IN (" + query + ")"; }
                else if (a == 8) { auth_query = "SELECT auth_repaired FROM auths WHERE auth_id IN (" + query + ")"; }
                else if (a == 9) { auth_query = "SELECT auth_delivered FROM auths WHERE auth_id IN (" + query + ")"; }

                string authorityQuery = ExecuteGetData(auth_query);
                if (authorityQuery == "1")
                {
                    result = "Successful";
                }
                else
                {
                    result = "You are not authorized!";
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

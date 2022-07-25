using System;
using TechnicalService.Managers;

namespace TechnicalService.DAL
{
    class LoginDAL : SqlManager
    {
        public string Login(string user_name, string user_password)
        {
            string result = "";
            try
            {
                string query = "SELECT COUNT(user_id) FROM users WHERE user_name='" + user_name + "' AND user_password='" + user_password + "' AND user_active = 1";
                int user_exist_result = Convert.ToInt16(ExecuteGetData(query));
                if (user_exist_result > 0)
                {
                    query = "SELECT user_id FROM users WHERE user_name='" + user_name + "'";
                    result = ExecuteGetData(query);
                    Shared.user_id = result;
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

        public string Password(string old_password)
        {
            string result;
            string query = "SELECT COUNT(user_id) FROM users WHERE user_id='" + Shared.user_id + "' AND user_password='" + old_password + "'";
            int checkPwd = Convert.ToInt16(ExecuteGetData(query));
            if (checkPwd == 0)
            {
                result = "Your old password is incorrect!";
            }
            else
            {
                result = "";
            }
            return result;
        }
    }
}

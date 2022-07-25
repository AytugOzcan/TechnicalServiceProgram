using System;
using TechnicalService.Managers;

namespace TechnicalService.DAL
{
    class UserOperationsDAL : SqlManager
    {

        public string Update(string oldPass, string newPass)
        {
            string result = "";
            try
            {
                string query = "SELECT COUNT(user_id) FROM users WHERE user_id='" + Shared.user_id + "' AND user_password='" + oldPass + "'";
                int user_exist_result = Convert.ToInt16(ExecuteGetData(query));
                if (user_exist_result > 0)
                {
                    string updateQuery = "UPDATE users SET user_password ='" + newPass + "' WHERE user_id='" + Shared.user_id + "'";
                    ExecuteQuery(updateQuery);
                    result = "Successful";
                }
                else
                {
                    result = "You entered an incorrect password!";
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

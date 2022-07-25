namespace TechnicalService.Models
{
    public class Role
    {
        public int role_id { get; set; }
        public string role_name { get; set; }
        public string auth_employee { get; set; }
        public string auth_user { get; set; }
        public string auth_device { get; set; }
        public string auth_operation { get; set; }
        public string auth_payment { get; set; }
        public string auth_customer { get; set; }
        public string auth_repair_reg { get; set; }
        public string auth_repaired { get; set; }
        public string auth_delivered { get; set; }
    }

}

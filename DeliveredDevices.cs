namespace TechnicalService.Models
{
    class DeliveredDevices
    {
        public int repair_id { get; set; }
        public string delivered_time { get; set; }
        public string device_type_name { get; set; }
        public string device_brand_name { get; set; }
        public string device_model_name { get; set; }
        public string operation_name { get; set; }
        public string repair_description { get; set; }
        public string employee_fullname { get; set; }
        public string customer_fullname { get; set; }
    }
}

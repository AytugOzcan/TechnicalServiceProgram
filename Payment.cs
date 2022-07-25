namespace TechnicalService.Models
{
    class Payment
    {
        public int payment_id { get; set; }
        public string delivered_time { get; set; }
        public string repaired_time { get; set; }
        public string customer_fullname { get; set; }
        public string payment_price { get; set; }
        public string payment_discount { get; set; }
        public string device_type_name { get; set; }
        public string device_brand_name { get; set; }
        public string device_model_name { get; set; }
        public string repair_description { get; set; }
    }
}

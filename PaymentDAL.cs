using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TechnicalService.Managers;
using TechnicalService.Models;

namespace TechnicalService.DAL
{
    class PaymentDAL : SqlManager
    {
        public List<Payment> GetPaymentList()
        {
            List<Payment> PaymentList = new List<Payment>();
            SqlDataReader dr = GetList("SELECT payments.payment_id, repairs.delivered_time, repairs.repaired_time, customers.customer_fullname, payments.payment_price, payments.payment_discount, device_types.device_type_name, device_brands.device_brand_name, device_models.device_model_name, repairs.repair_description FROM payments INNER JOIN repairs ON payments.payment_repair_id = repairs.repair_id INNER JOIN customers ON repairs.customer_id = customers.customer_id INNER JOIN device_models ON repairs.device_model_id = device_models.device_model_id INNER JOIN device_types ON device_models.device_type_id = device_types.device_type_id INNER JOIN device_brands ON device_models.device_brand_id = device_brands.device_brand_id WHERE payment_active = '1'");
            while (dr.Read())
            {
                Payment payment = new Payment();
                payment.payment_id = Convert.ToInt16(dr[0]);
                payment.delivered_time = dr[1].ToString();
                payment.repaired_time = dr[2].ToString();
                payment.customer_fullname = dr[3].ToString();
                payment.payment_price = dr[4].ToString();
                payment.payment_discount = dr[5].ToString();
                payment.device_type_name = dr[6].ToString();
                payment.device_brand_name = dr[7].ToString();
                payment.device_model_name = dr[8].ToString();
                payment.repair_description = dr[9].ToString();

                PaymentList.Add(payment);
            }
            connection.Close();
            return PaymentList;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TechnicalService.Managers;
using TechnicalService.Models;

namespace TechnicalService.DAL
{
    class DeviceDAL : SqlManager
    {
        public List<DeviceType> GetDeviceTypeList()
        {
            List<DeviceType> DeviceTypeList = new List<DeviceType>();
            SqlDataReader dr = GetList("SELECT * FROM device_types WHERE device_type_active = 1");
            while (dr.Read())
            {
                DeviceType deviceType = new DeviceType();
                deviceType.device_type_id = Convert.ToInt16(dr[0]);
                deviceType.device_type_name = dr[1].ToString();

                DeviceTypeList.Add(deviceType);
            }
            connection.Close();
            return DeviceTypeList;
        }

        public List<DeviceBrand> GetDeviceBrandList()
        {
            List<DeviceBrand> DeviceBrandList = new List<DeviceBrand>();
            SqlDataReader dr = GetList("SELECT * FROM device_brands WHERE device_brand_active = 1");
            while (dr.Read())
            {
                DeviceBrand deviceBrand = new DeviceBrand();
                deviceBrand.device_brand_id = Convert.ToInt16(dr[0]);
                deviceBrand.device_brand_name = dr[1].ToString();

                DeviceBrandList.Add(deviceBrand);
            }
            connection.Close();
            return DeviceBrandList;
        }

        public List<DeviceModel> GetDeviceModelList()
        {
            List<DeviceModel> DeviceModelList = new List<DeviceModel>();
            SqlDataReader dr = GetList("SELECT device_models.device_model_id, device_types.device_type_name, device_brands.device_brand_name, device_models.device_model_name FROM device_types INNER JOIN device_models ON device_types.device_type_id = device_models.device_type_id INNER JOIN device_brands ON device_models.device_brand_id = device_brands.device_brand_id WHERE device_model_active = 1 AND device_type_active = 1 AND device_brand_active = 1");
            while (dr.Read())
            {
                DeviceModel deviceModel = new DeviceModel();
                deviceModel.device_model_id = Convert.ToInt16(dr[0]);
                deviceModel.device_type_name = dr[1].ToString();
                deviceModel.device_brand_name = dr[2].ToString();
                deviceModel.device_model_name = dr[3].ToString();

                DeviceModelList.Add(deviceModel);
            }
            connection.Close();
            return DeviceModelList;
        }


        public List<DeviceModel2> GetDeviceModel2List(string device_type_id, string device_brand_id)
        {
            List<DeviceModel2> DeviceModel2List = new List<DeviceModel2>();
            string query = "SELECT  dm.device_model_name FROM device_types dt INNER JOIN device_models dm ON dt.device_type_id = dm.device_type_id INNER JOIN device_brands db ON dm.device_brand_id = db.device_brand_id WHERE device_model_active = 1 AND device_type_active = 1 AND db.device_brand_active = 1 AND dm.device_type_id = " + device_type_id + " AND dm.device_brand_id = " + device_brand_id;
            SqlDataReader dr = GetList(query);
            while (dr.Read())
            {
                DeviceModel2 deviceModel2 = new DeviceModel2();
                deviceModel2.device_model_name = dr[0].ToString();
            
                DeviceModel2List.Add(deviceModel2);
            }
            connection.Close();
            return DeviceModel2List;
        }

        public string deviceTypeAdd(string deviceTypeName)
        {
            string result = "";
            try
            {
                string query = "SELECT COUNT(device_type_id) FROM device_types WHERE device_type_name = '" + deviceTypeName + "'";
                int devicetype_exist_result = Convert.ToInt16(ExecuteGetData(query));
                if (devicetype_exist_result == 0)
                {
                    string addQuery = "INSERT INTO device_types(device_type_name,device_type_active) VALUES ('" + deviceTypeName + "', 1)";
                    ExecuteQuery(addQuery);

                    query = "SELECT COUNT(device_type_id) FROM device_types WHERE device_type_name = '" + deviceTypeName + "'";
                    devicetype_exist_result = Convert.ToInt16(ExecuteGetData(query));
                    if (devicetype_exist_result > 0)
                    {
                        GetDeviceTypeList();
                        result = "Successful";
                    }

                    else
                    {
                        GetDeviceTypeList();
                        result = "Failed to add record!";
                    }
                }
                else
                {
                    result = "This device type already exists!";
                }
                return result;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string deviceTypeUpdate(string id, string deviceTypeName)
        {
            string result = "";
            try
            {
                string query = "SELECT COUNT(device_type_id) FROM device_types WHERE device_type_id != '" + id + "' AND device_type_name = '" + deviceTypeName + "' ";
                int devicetype_exist_result = Convert.ToInt16(ExecuteGetData(query));
                if (devicetype_exist_result == 0)
                {
                    string updateQuery = "UPDATE device_types SET device_type_name = '" + deviceTypeName + "' WHERE device_type_id = '" + id + "'";
                    ExecuteQuery(updateQuery);
                    result = "Successful";
                }
                else
                {
                    result = "This device type is already registered!";
                }
                return result;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string deviceTypePassive(string id)
        {
            string result = "";
            try
            {
                string updateQuery = "UPDATE device_types SET device_type_active = '0' WHERE device_type_id='" + id + "'";
                ExecuteQuery(updateQuery);
                result = "Successful";
                return result;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string deviceBrandAdd(string deviceBrandName)
        {
            string result = "";
            try
            {
                string query = "SELECT COUNT(device_brand_id) FROM device_brands WHERE device_brand_name = '" + deviceBrandName + "'";
                int devicebrand_exist_result = Convert.ToInt16(ExecuteGetData(query));
                if (devicebrand_exist_result == 0)
                {
                    string addQuery = "INSERT INTO device_brands(device_brand_name,device_brand_active) VALUES ('" + deviceBrandName + "', 1)";
                    ExecuteQuery(addQuery);

                    query = "SELECT COUNT(device_brand_id) FROM device_brands WHERE device_brand_name = '" + deviceBrandName + "'";
                    devicebrand_exist_result = Convert.ToInt16(ExecuteGetData(query));
                    if (devicebrand_exist_result > 0)
                    {
                        GetDeviceBrandList();
                        result = "Successful";
                    }

                    else
                    {
                        GetDeviceBrandList();
                        result = "Failed to add record!";
                    }
                }
                else
                {
                    result = "This device brand already exists!";
                }
                return result;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string deviceBrandUpdate(string id, string deviceBrandName)
        {
            string result = "";
            try
            {
                string query = "SELECT COUNT(device_brand_id) FROM device_brands WHERE device_brand_id != '" + id + "' AND device_brand_name = '" + deviceBrandName + "' ";
                int devicebrand_exist_result = Convert.ToInt16(ExecuteGetData(query));
                if (devicebrand_exist_result == 0)
                {
                    string updateQuery = "UPDATE device_brands SET device_brand_name = '" + deviceBrandName + "' WHERE device_brand_id = '" + id + "'";
                    ExecuteQuery(updateQuery);
                    result = "Successful";
                }
                else
                {
                    result = "This device brand is already registered!";
                }
                return result;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string deviceBrandPassive(string id)
        {
            string result = "";
            try
            {
                string updateQuery = "UPDATE device_brands SET device_brand_active = '0' WHERE device_brand_id='" + id + "'";
                ExecuteQuery(updateQuery);
                result = "Successful";
                return result;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string deviceModelAdd(string deviceModelName, string dtype_id, string dbrand_id)
        {
            string result = "";
            try
            {
                string query = "SELECT COUNT(device_model_id) FROM device_models WHERE device_model_name = '" + deviceModelName + "' AND device_type_id = '" + dtype_id + "' AND device_brand_id = '" + dbrand_id + "'";
                int devicemodel_exist_result = Convert.ToInt16(ExecuteGetData(query));
                if (devicemodel_exist_result == 0)
                {
                    string addQuery = "INSERT INTO device_models(device_model_name, device_type_id, device_brand_id, device_model_active) VALUES ('" + deviceModelName + "', '" + dtype_id + "', '" + dbrand_id + "', 1)";
                    ExecuteQuery(addQuery);

                    query = "SELECT COUNT(device_model_id) FROM device_models WHERE device_model_name = '" + deviceModelName + "' AND device_type_id = '" + dtype_id + "' AND device_brand_id = '" + dbrand_id + "'";
                    devicemodel_exist_result = Convert.ToInt16(ExecuteGetData(query));
                    if (devicemodel_exist_result > 0)
                    {
                        GetDeviceModelList();
                        result = "Successful";
                    }

                    else
                    {
                        GetDeviceModelList();
                        result = "Failed to add record!";
                    }
                }
                else
                {
                    result = "There is such a model depending on this type and brand!";
                }
                return result;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string deviceModelUpdate(string id, string deviceModelName, string typeid, string brandid)
        {
            string result = "";
            try
            {
                string query = "SELECT COUNT(device_model_id) FROM device_models WHERE device_model_id != '" + id + "' AND device_type_id = '" + typeid + "' AND device_brand_id = '" + brandid + "'";
                int devicemodel_exist_result = Convert.ToInt16(ExecuteGetData(query));
                if (devicemodel_exist_result == 0)
                {
                    string updateQuery = "UPDATE device_models SET device_model_name = '" + deviceModelName + "', device_type_id = '" + typeid + "', device_brand_id = '" + brandid + "'  WHERE device_model_id = '" + id + "'";
                    ExecuteQuery(updateQuery);
                    result = "Successful";
                }
                else
                {
                    result = "This device model is already registered!";
                }
                return result;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string deviceModelPassive(string id)
        {
            string result = "";
            try
            {
                string updateQuery = "UPDATE device_models SET device_model_active = '0' WHERE device_model_id='" + id + "'";
                ExecuteQuery(updateQuery);
                result = "Successful";
                return result;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string deviceModelIdQuery(string model_name, string type_id, string brand_id)
        {
            string result = "";
            try
            {
                string idQuery = "SELECT COUNT(device_model_id) FROM device_types INNER JOIN device_models ON device_types.device_type_id = device_models.device_type_id INNER JOIN device_brands ON device_models.device_brand_id = device_brands.device_brand_id WHERE device_models.device_type_id  = '" + type_id + "' AND device_models.device_brand_id = '" + brand_id + "' AND device_model_name = '" + model_name + "' AND device_model_active = 1 AND device_type_active = 1 AND device_brand_active = 1";
                int devicemodel_exist_result = Convert.ToInt16(ExecuteGetData(idQuery));
                if (devicemodel_exist_result == 0)
                {
                    result = "Device model not found!";
                }
                else
                {
                    idQuery = "SELECT device_model_id FROM device_types INNER JOIN device_models ON device_types.device_type_id = device_models.device_type_id INNER JOIN device_brands ON device_models.device_brand_id = device_brands.device_brand_id WHERE device_models.device_type_id  = '" + type_id + "' AND device_models.device_brand_id = '" + brand_id + "' AND device_model_name = '" + model_name + "' AND device_model_active = 1 AND device_type_active = 1 AND device_brand_active = 1";
                    result = ExecuteGetData(idQuery);
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

using ContohXamarinSep2020.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ContohXamarinSep2020.Services
{
    public class EmployeeServices
    {
        private HttpClient _client;
        public EmployeeServices()
        {
            _client = new HttpClient();
        }

        public async Task<List<Employee>> GetAll()
        {
            List<Employee> lstEmp = new List<Employee>();
            var uri = new Uri($"{Helpers.restUrl}/api/EmployeeDapper");
            try
            {
                var response = await _client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    lstEmp = JsonConvert.DeserializeObject<List<Employee>>(content);
                }
                return lstEmp;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task Insert(Employee emp)
        {
            var uri = new Uri($"{Helpers.restUrl}/api/EmployeeDapper/TambahEmployee");
            try
            {
                var jsonData = JsonConvert.SerializeObject(emp);
                var content = new StringContent(jsonData, Encoding.UTF8,
                    "application/json");
                var response = await _client.PostAsync(uri, content);
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception("Gagal menambahkan data");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

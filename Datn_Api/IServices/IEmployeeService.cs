﻿using Datn_Shared.Models;
using Datn_Shared.ViewModels.AccountViewModels;
using Datn_Shared.ViewModels.CustomerViewModels;
using Datn_Shared.ViewModels.EmployeeViewModels;

namespace Datn_Api.IServices
{
    public interface IEmployeeService
    {
        public Task<List<Employee>> GetAllEmployee();
        public Task<Employee> GetEmployeebyId(Guid id);
        public Task<Employee> GetEmployeebyNames(string name);
        public Task<EmployeeView> GetEmployeebyName(string name);
        public Task<bool> UpdateProfileEmployee(string userName, UpdateProfileEmployee employee);
        public Task<Response> UpdatePasswordEmployee(string userName, UpdatePasswordEmployee employee);
        public Task<bool> UpdateImageEmployee(string userName, string image);
    }
}

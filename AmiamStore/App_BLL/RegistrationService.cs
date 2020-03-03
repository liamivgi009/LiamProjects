using AmiamStore.App_BLL.Entities;
using AmiamStore.App_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmiamStore.App_BLL
{
    public class RegistrationService
    {
        private readonly UsersRepository _usersRepository = new UsersRepository();
        private readonly CustomersRepository _customersRepository = new CustomersRepository();
        private readonly LoginBLL _usersService = new LoginBLL();

        public void Register(User user, Customer customer)
        {
            _usersRepository.Insert(user);
            customer.UserID = _usersService.GetUserIdByUserName(user.Username);
            _customersRepository.Insert(customer);
        }
    }
}
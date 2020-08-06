using OOPS.BLL.Abstract;
using OOPS.Core.Data.UnitOfWork;
using OOPS.DTO.Company;
using OOPS.DTO.Employee;
using OOPS.DTO.ProjectBase;
using OOPS.MapConfig.ConfigProfile;
using OOPS.Model.CompanyModels;
using OOPS.Model.EmployeeModel;
using OOPS.Model.ProjectBaseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.BLL.Concreate
{
    public class UserService : IUserService
    {
        private readonly IUnitofWork uow;
        public UserService(IUnitofWork _uow)
        {
            uow = _uow;
        }

        public UserDTO CheckRegistration(string UserName, string EMail)
        {
            var checkUser = uow.GetRepository<User>().Get(z => (z.EMail == EMail || z.UserName == UserName));
            return MapperFactory.CurrentMapper.Map<UserDTO>(checkUser);
        }

        public bool deleteUser(int userId)
        {
            throw new NotImplementedException();
        }

        public UserDTO FindwithMail(string mail)
        {
            throw new NotImplementedException();
        }

        public UserDTO FindwithUserName(string userName)
        {
            throw new NotImplementedException();
        }

        public UserDTO FindwithUsernameandMail(UserDTO loginUser)
        {
            throw new NotImplementedException();
        }

        public UserDTO FindwithUsernameandMail(string mailorUserName, string password)
        {
            throw new NotImplementedException();
        }

        public List<UserDTO> getAll()
        {
            throw new NotImplementedException();
        }

        public List<UserDTO> getAllUserinRole(int RoleID)
        {
            throw new NotImplementedException();
        }

        public UserDTO getUser(int Id)
        {
            throw new NotImplementedException();
        }

        public UserDTO LoginUser(UserDTO loginUser)
        {
            var getUser = uow.GetRepository<User>().Get(z => (z.EMail == loginUser.EMail ||
                                                        z.UserName == loginUser.UserName) &&
                                                        z.Password == loginUser.Password);
            return MapperFactory.CurrentMapper.Map<UserDTO>(getUser);
        }



        public UserDTO newUser(UserDTO user, CompanyDTO company, EmployeeDTO employee)
        {
            var addedEmployee = MapperFactory.CurrentMapper.Map<Employee>(employee);
            var addedUser = MapperFactory.CurrentMapper.Map<User>(user);
            var addedCompany = MapperFactory.CurrentMapper.Map<Company>(company);

            addedEmployee.User = addedUser;
            addedEmployee.Company = addedCompany;
            addedCompany.Employees.Add(addedEmployee); 
            addedUser.Employee = addedEmployee;
            addedUser.RoleID = 1;
            addedUser.Company = addedCompany;

            uow.GetRepository<Employee>().Add(addedEmployee);

            addedUser = uow.GetRepository<User>().Add(addedUser);

            uow.GetRepository<Company>().Add(addedCompany);

            uow.SaveChanges();

            return MapperFactory.CurrentMapper.Map<UserDTO>(addedUser);
        }


        public UserDTO updateUser(UserDTO user)
        {
            throw new NotImplementedException();
        }

        public UserDTO updateUserCompany(UserDTO user)
        {
            throw new NotImplementedException();
        }

        public UserDTO updateUserRole(UserDTO user)
        {
            throw new NotImplementedException();
        }
    }
}

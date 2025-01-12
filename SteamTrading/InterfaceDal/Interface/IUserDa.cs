﻿using InterfaceDal.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDal.Interface
{
    public interface IUserDa
    {
        Task<bool> CreateUser(UserDto user);
        bool CheckIfUserExists(long steamId);
        Task<UserDto?> GetUser(long steamId);
        Task<IEnumerable<UserDto>?> GetAllBots();
    }
}

﻿using SignalR.Infrastructure.Dtos.OnlineUserDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.Infrastructure.EFRepositorys.OnlineUserEFRepositorys
{
    public interface IOnlineUserEFRepository
    {
        Task<IEnumerable<OnlineUserDto>> GetOnlineUsersAsync();
    }
}

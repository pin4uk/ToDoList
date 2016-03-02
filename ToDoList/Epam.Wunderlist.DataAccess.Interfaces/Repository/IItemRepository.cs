﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Wunderlist.DataAccess.Interfaces.DTO;

namespace Epam.Wunderlist.DataAccess.Interfaces.Repository
{
    public interface IItemRepository : IRepository<DalItem>
    {
        IEnumerable<DalItem> GetByToDoListId(int todolistid);
    }
}
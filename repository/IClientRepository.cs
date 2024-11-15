using ConsoleApp.core;
using ConsoleApp.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Repository
{
    public interface IClientRepository : IRepository<Client>
    {
        Client? FindBySurname(String surname);
    }
}

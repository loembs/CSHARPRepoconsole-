using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.entities;
namespace ConsoleApp.service
{
    public interface IClientService
    {
        List<Client> FindAll();
        Client FindById(int id);
        void Save(Client client);
        void Delete(int id);
        void Update(Client client);
        Client? FindBySurname(string surnom);

    }
}

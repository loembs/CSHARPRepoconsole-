using ConsoleApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ConsoleApp.entities;
using ConsoleApp.core;
using ConsoleApp.service;

namespace ConsoleApp.service.Impl
{
    public class ClientServiceImpl : IClientService
    {
        private readonly IClientRepository clientRepository;

        public ClientServiceImpl(IClientRepository clientRepository) => this.clientRepository = clientRepository;

        public void Delete(int id)
        {
            clientRepository.Delete(id);
        }

        public List<Client> FindAll()
        {
            return clientRepository.SelectAll();
        }

        public Client FindById(int id)
        {
            return clientRepository.SelectById(id);
        }

        public void Save(Client client)
        {
            clientRepository.Insert(client);
        }

        public void Update(Client client)
        {
            clientRepository.Update(client);
        }
        public Client? FindBySurname(string surnom)
        {
            return clientRepository.FindBySurname(surnom);
        }
    }
}

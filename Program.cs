﻿using ConsoleApp.Repository;
using ConsoleApp.service;
using ConsoleApp.views;
using ConsoleApp.service.Impl;
using ConsoleApp.entities;
using ConsoleApp.Repository.Impl;

namespace ConsoleApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IClientRepository clientRepository = new ClientRepositoryImpl();
            IClientService clientService = new ClientServiceImpl(clientRepository);

            int choice;
            do
            {
                choice = Menu();
                switch (choice)
                {
                    case 1:
                        Client client = ClientView.CreateClient();
                        clientService.Save(client);
                        break;
                    case 2:
                        ClientView.ListClients(clientService.FindAll());
                        break;
                    case 3:
                        ClientView.ListClients(clientService.FindAll());
                        Client client1 = clientService.FindById(ClientView.SaisirId());
                        if (client1 != null)
                        {
                            ClientView.UpdateClient(client1);
                            clientService.Update(client1);
                        }
                        break;
                    case 4:
                        ClientView.ListClients(clientService.FindAll());
                        Client client2 = clientService.FindById(ClientView.SaisirId());
                        if (client2 != null)
                            clientService.Delete(client2.Id);

                        break;
                    case 5:
                        Console.WriteLine("Surnom du client : ");
                        Client? client3 = clientService.FindBySurname(Console.ReadLine()!);
                        if (client3 != null)
                        {
                            ClientView.ListDetteClient(client3);
                        }
                        break;
                    case 0:
                        Console.WriteLine("Au revoir!");
                        break;
                    default:
                        Console.WriteLine("Choix invalide!");
                        break;
                }
            } while (choice != 0);

        }


        public static int Menu()
        {
            Console.WriteLine("1. Créer un client");
            Console.WriteLine("2. Afficher tous les clients");
            Console.WriteLine("3. Modifier un client");
            Console.WriteLine("4. Supprimer un client");
            Console.WriteLine("5. Afficher les dettes d'un client");
            Console.WriteLine("0. Quitter");
            Console.Write("Votre choix : ");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}


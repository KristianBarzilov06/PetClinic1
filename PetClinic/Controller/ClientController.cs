using PetClinic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetClinic.Controller
{
    class ClientController
    {
        public List<Clients> GetAllClients()
        {
            using (PetClinicDBEntities db = new PetClinicDBEntities())
            {
                return db.Clients.ToList();
            }
        }

        public void AddCLient(Clients client)
        {
            using (PetClinicDBEntities db = new PetClinicDBEntities())
            {
                client.Id = db.Clients.ToList().LastOrDefault().Id + 1;
                db.Clients.Add(client);
                db.SaveChanges();
            }
        }
        public void UpdateClient(Clients client)
        {
            using(PetClinicDBEntities db = new PetClinicDBEntities())
            {
                var clientToUpdate = db.Clients.Where(c => c.Id == client.Id).FirstOrDefault();
                if (clientToUpdate != null)
                {
                    clientToUpdate = client;
                    db.SaveChanges();
                }
            }
        }

        public void DeleteClient(Clients client)
        {
            using(PetClinicDBEntities db = new PetClinicDBEntities())
            {
                var clientToDelete = db.Clients.Where(c => c.Id == client.Id).FirstOrDefault();
                if(clientToDelete != null)
                {
                    db.Clients.Remove(clientToDelete);
                    db.SaveChanges();
                }
            }
        }
    }
}

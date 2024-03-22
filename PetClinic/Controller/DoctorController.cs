using PetClinic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetClinic.Controller
{
    class DoctorController
    {
        public List<Doctor> GetAllDoctors()
        {
            using (PetClinicDBEntities db = new PetClinicDBEntities())
            {
                return db.Doctors.ToList();
            }
        }

        public void AddDoctor(Doctor doctor)
        {
            using (PetClinicDBEntities db = new PetClinicDBEntities())
            {
                doctor.Id = db.Doctors.ToList().LastOrDefault().Id + 1;
                db.Doctors.Add(doctor);
                db.SaveChanges();
            }
        }

        public void UpdateDoctor(Doctor doctor)
        {
            using (PetClinicDBEntities db = new PetClinicDBEntities())
            {
                var doctorToUpdate = db.Doctors.Where(d => d.Id == doctor.Id).FirstOrDefault();
                if (doctorToUpdate != null)
                {
                    doctorToUpdate.Id = doctor.Id;
                    doctorToUpdate.Username = doctor.Username;
                    doctorToUpdate.Password = doctor.Password;
                    db.SaveChanges();
                }
            }
        }
        public void DeleteDoctor(Doctor doctor)
        {
            using (PetClinicDBEntities db = new PetClinicDBEntities())
            {
                var doctorToDelete = db.Doctors.Where(d => d.Id == doctor.Id).FirstOrDefault();
                if (doctorToDelete != null)
                {
                    db.Doctors.Remove(doctorToDelete);
                    db.SaveChanges();
                }
            }
        }
    }
}

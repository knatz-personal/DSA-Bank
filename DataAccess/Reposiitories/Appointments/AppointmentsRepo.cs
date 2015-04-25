using System.Linq;
using DataAccess.EntityModel;

namespace DataAccess.Reposiitories.Appointments
{
    public class AppointmentsRepo : IDataRepository<Appointment>
    {
        private readonly DsaDataContext _db = new DsaDataContext();

        public IQueryable<Appointment> ListAll()
        {
            return _db.Appointments.AsQueryable();
        }

        public void Create(Appointment newItem)
        {
            _db.Appointments.Add(newItem);
            _db.SaveChanges();
        }

        public Appointment Read(Appointment itemToRead)
        {
            Appointment result = _db.Appointments.Find(itemToRead.ID);
            return result;
        }

        public void Update(Appointment updatedItem)
        {
            Appointment o = _db.Appointments.Find(updatedItem.ID);

            if (o != null)
            {
                o.Duration = updatedItem.Duration;
                o.Description = updatedItem.Description;
                o.IsAccepted = updatedItem.IsAccepted;
                _db.SaveChanges();
            }
        }

        public void Delete(Appointment itemToDelete)
        {
            Appointment o = _db.Appointments.Find(itemToDelete.ID);

            if (o != null)
            {
                _db.Appointments.Remove(o);
                _db.SaveChanges();
            }
        }
    }
}
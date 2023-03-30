using System;
using System.Collections;
using System.Collections.Generic;
using WindowsFormsApp3.domain;
using WindowsFormsApp3.repo;

namespace WindowsFormsApp3.srv
{
    public class SrvReservation
    {
        private readonly IDictionary<string, string> props = new SortedList<string, string>();
        private readonly RepoReservation repo;

        public SrvReservation(IDictionary<string, string> props)
        {
            this.props = props;
            repo = new RepoReservation(this.props);
        }

        public void addReservation(Reservation a)
        {
            try
            {
                repo.save(a);
            }
            catch (ValidationException e)
            {
                throw e;
            }
            
        }

        public void deleteReservation(int id)
        {
            repo.delete(id);
        }

        public void updateReservation(int id, Reservation a)
        {
            repo.update(id, a);
        }

        public IEnumerable findAll()
        {
            return repo.findAll();
        }

        public IEnumerable<Reservation> findAllFromAgent(string agent)
        {
            return repo.findAllFromAgent(agent);
        }
    }
}
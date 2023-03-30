using System;
using System.Collections;
using System.Collections.Generic;
using WindowsFormsApp3.domain;
using WindowsFormsApp3.repo;

namespace WindowsFormsApp3.srv
{
    public class SRVTrip
    {
        private readonly IDictionary<string, string> props = new SortedList<string, string>();
        private readonly RepoTrip repo;

        public SRVTrip(IDictionary<string, string> props)
        {
            this.props = props;
            repo = new RepoTrip(this.props);
        }

        public void addTrip(Trip a)
        {
            repo.save(a);
        }

        public void deleteTrip(int id)
        {
            repo.delete(id);
        }

        public void updateTrip(int id, Trip a)
        {
            try
            {
                repo.update(id, a);
            }
            catch (RepoException repoException)
            {
                
                throw repoException;
            }
            
        }


        public Trip findOne(int id)
        {
            try
            {
                return repo.findOne(id);
            }
            catch (RepoException repoException)
            {
                
                throw repoException;
            }
            
        }

        public IEnumerable findAll()
        {
            return repo.findAll();
        }

        public IEnumerable findByObjective(string obj, int leave1, int leave2)
        {
            return repo.findByObjective(obj, leave1, leave2);
        }
    }
}
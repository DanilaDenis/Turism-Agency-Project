using System;
using System.Collections;
using System.Collections.Generic;
using WindowsFormsApp3.domain;
using WindowsFormsApp3.repo;

namespace WindowsFormsApp3.srv
{
    public class SRVAgent
    {
        private readonly IDictionary<string, string> props = new SortedList<string, string>();
        private readonly RepoAgent repo;

        public SRVAgent(IDictionary<string, string> props)
        {
            this.props = props;
            repo = new RepoAgent(this.props);
        }


        public void addAgent(string name,string agency,string email, string password)
        {
            Agent a = new Agent(name, password, email, agency);
            try
            {
                repo.save(a);
            }
            catch (ValidationException exception)
            {

                throw exception;
            }
            catch (RepoException repoException)
            {
                throw repoException;
            }
            
        }

        public void deleteAgent(int id)
        {
            repo.delete(id);
        }

        public void updateAgent(int id, Agent a)
        {
            repo.update(id, a);
        }

        public Agent findByIdentity(string email, string password)
        {
            return repo.findByIdentity(email, password);
        }

        public IEnumerable findAll()
        {
            return repo.findAll();
        }
    }
}
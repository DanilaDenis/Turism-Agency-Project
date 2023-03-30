using System.Collections.Generic;
using System.Web.Caching;
using log4net;
using WindowsFormsApp3.domain;

namespace WindowsFormsApp3.repo
{
    public class RepoAgent : IRepository<int, Agent>
    {
        private static readonly ILog log = LogManager.GetLogger("RepoAgent");

        private readonly IDictionary<string, string> props;

        public RepoAgent(IDictionary<string, string> props)
        {
            log.Info("RepoAgent");
            this.props = props;
        }

        public Agent findOne(int id)
        {
            log.InfoFormat("Entering findOne with value {0}", id);
            var con = DBUtils.getConnection(props);

            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "select nume, parola, email,agentie from Agent where id=@id";
                var paramId = comm.CreateParameter();
                paramId.ParameterName = "@id";
                paramId.Value = id;
                comm.Parameters.Add(paramId);

                using (var dataR = comm.ExecuteReader())
                {
                    if (dataR.Read())
                    {
                        var nume = dataR.GetString(0);
                        var parola = dataR.GetString(1);
                        var email = dataR.GetString(2);
                        var agentie = dataR.GetString(3);
                        var task = new Agent(nume, parola, email, agentie);
                        log.InfoFormat("Exiting findOne with value {0}", task);
                        return task;
                    }
                }
            }
            return null;
        }
        
        public Agent findOneByEmail(string email)
        {
            var con = DBUtils.getConnection(props);

            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "select nume, parola,agentie from Agent where email=@email";
                var paramId = comm.CreateParameter();
                paramId.ParameterName = "@email";
                paramId.Value = email;
                comm.Parameters.Add(paramId);

                using (var dataR = comm.ExecuteReader())
                {
                    if (dataR.Read())
                    {
                        var nume = dataR.GetString(0);
                        var parola = dataR.GetString(1);
                        var agentie = dataR.GetString(2);
                        var task = new Agent(nume, parola, email, agentie);
                        return task;
                    }
                }
            }
            return null;
        }

        public IEnumerable<Agent> findAll()
        {
            var con = DBUtils.getConnection(props);
            IList<Agent> tasksR = new List<Agent>();
            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "select nume, parola, email,agentie from Agent";

                using (var dataR = comm.ExecuteReader())
                {
                    while (dataR.Read())
                    {
                        var nume = dataR.GetString(0);
                        var parola = dataR.GetString(1);
                        var email = dataR.GetString(2);
                        var agentie = dataR.GetString(3);
                        var task = new Agent(nume, parola, email, agentie);
                        tasksR.Add(task);
                    }
                }
            }

            return tasksR;
        }

        public void save(Agent entity)
        {
            AgentValidator agentValidator = new AgentValidator();
            var con = DBUtils.getConnection(props);
            try
            {
                agentValidator.validate(entity);
            }
            catch (ValidationException exception)
            {
                
                throw exception;
            }

            if (findOneByEmail(entity.Email) != null)
            {
                RepoException repoException = new RepoException("Email alrady in use");
                throw repoException;
            }
            
            using (var comm = con.CreateCommand())
            {
                comm.CommandText =
                    "insert into Agent(nume,parola,email,agentie)  values (@nume, @parola, @email, @agentie)";
                var paramId = comm.CreateParameter();
                paramId.ParameterName = "@nume";
                paramId.Value = entity.Name;
                comm.Parameters.Add(paramId);

                var paramDesc = comm.CreateParameter();
                paramDesc.ParameterName = "@parola";
                paramDesc.Value = entity.Password;
                comm.Parameters.Add(paramDesc);

                var paramEmail = comm.CreateParameter();
                paramEmail.ParameterName = "@email";
                paramEmail.Value = entity.Email;
                comm.Parameters.Add(paramEmail);

                var paramElems = comm.CreateParameter();
                paramElems.ParameterName = "@agentie";
                paramElems.Value = entity.Agency;
                comm.Parameters.Add(paramElems);

                var result = comm.ExecuteNonQuery();
            }
        }

        public void delete(int id)
        {
            var con = DBUtils.getConnection(props);
            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "delete from Agent where id=@id";
                var paramId = comm.CreateParameter();
                paramId.ParameterName = "@id";
                paramId.Value = id;
                comm.Parameters.Add(paramId);
                var dataR = comm.ExecuteNonQuery();
            }
        }

        public void update(int oldId, Agent entity)
        {
            var con = DBUtils.getConnection(props);
            using (var comm = con.CreateCommand())
            {
                comm.CommandText =
                    "update * from Agent where id=@id set nume = @nume, parola = @parola, email = @email, agentie = @agentie ";
                var paramId = comm.CreateParameter();
                paramId.ParameterName = "@id";
                paramId.Value = oldId;
                comm.Parameters.Add(paramId);

                var paramNume = comm.CreateParameter();
                paramId.ParameterName = "@nume";
                paramId.Value = entity.Name;
                comm.Parameters.Add(paramId);

                var paramDesc = comm.CreateParameter();
                paramDesc.ParameterName = "@parola";
                paramDesc.Value = entity.Password;
                comm.Parameters.Add(paramDesc);

                var paramEmail = comm.CreateParameter();
                paramEmail.ParameterName = "@email";
                paramEmail.Value = entity.Email;
                comm.Parameters.Add(paramEmail);

                var paramElems = comm.CreateParameter();
                paramElems.ParameterName = "@agentie";
                paramElems.Value = entity.Agency;
                comm.Parameters.Add(paramElems);
                var dataR = comm.ExecuteNonQuery();
            }
        }

        public Agent findByIdentity(string email, string password)
        {
            var con = DBUtils.getConnection(props);
            IList<Agent> tasksR = new List<Agent>();
            using (var comm = con.CreateCommand())
            {
                comm.CommandText =
                    "select nume, parola, email,agentie from Agent where email = @email and parola = @password";
                var paramId = comm.CreateParameter();
                paramId.ParameterName = "@email";
                paramId.Value = email;
                comm.Parameters.Add(paramId);

                var paramPs = comm.CreateParameter();
                paramPs.ParameterName = "@password";
                paramPs.Value = password;
                comm.Parameters.Add(paramPs);

                using (var dataR = comm.ExecuteReader())
                {
                    if (dataR.Read())
                    {
                        var nume = dataR.GetString(0);
                        var parola = dataR.GetString(1);
                        var email1 = dataR.GetString(2);
                        var agentie = dataR.GetString(3);
                        var task = new Agent(nume, parola, email1, agentie);
                        return task;
                    }
                    
                }
            }

            return null;
        }
    }
}
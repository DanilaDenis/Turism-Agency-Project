using System;
using System.Collections.Generic;
using log4net;
using WindowsFormsApp3.domain;

namespace WindowsFormsApp3.repo
{
    public class RepoReservation : IRepository<int, Reservation>
    {
        private static readonly ILog log = LogManager.GetLogger("SortingTaskDbRepository");

        private readonly IDictionary<string, string> props;

        public RepoReservation(IDictionary<string, string> props)
        {
            log.Info("Creating SortingTaskDbRepository ");
            this.props = props;
        }

        public Reservation findOne(int id)
        {
            log.InfoFormat("Entering findOne with value {0}", id);
            var con = DBUtils.getConnection(props);

            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "select client,telephone,tickets,trip,agent from Reservation where id=@id";
                var paramId = comm.CreateParameter();
                paramId.ParameterName = "@id";
                paramId.Value = id;
                comm.Parameters.Add(paramId);

                using (var dataR = comm.ExecuteReader())
                {
                    if (dataR.Read())
                    {
                        var client = dataR.GetString(0);
                        var telephone = dataR.GetString(1);
                        var tickets = dataR.GetInt32(2);
                        var trip = dataR.GetInt32(3);
                        var agent = dataR.GetString(4);
                        var task = new Reservation(client, telephone, tickets, trip,agent);
                        log.InfoFormat("Exiting findOne with value {0}", task);
                        return task;
                    }
                }
            }

            log.InfoFormat("Exiting findOne with value {0}", null);
            return null;
        }

        public IEnumerable<Reservation> findAll()
        {
            var con = DBUtils.getConnection(props);
            IList<Reservation> tasksR = new List<Reservation>();
            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "select client,telephone,tickets,trip,agent from Reservation";

                using (var dataR = comm.ExecuteReader())
                {
                    while (dataR.Read())
                    {
                        var client = dataR.GetString(0);
                        var telephone = dataR.GetString(1);
                        var tickets = dataR.GetInt32(2);
                        var trip = dataR.GetInt32(3);
                        var agent = dataR.GetString(4);
                        var task = new Reservation(client, telephone, tickets, trip,agent);
                        tasksR.Add(task);
                    }
                }
            }

            return tasksR;
        }
        public IEnumerable<Reservation> findAllFromAgent(string a)
        {
            var con = DBUtils.getConnection(props);
            IList<Reservation> tasksR = new List<Reservation>();
            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "select client,telephone,tickets,trip,agent from Reservation where agent = @agent";
                var paramId = comm.CreateParameter();
                paramId.ParameterName = "@agent";
                paramId.Value = a;
                comm.Parameters.Add(paramId);
                using (var dataR = comm.ExecuteReader())
                {
                    while (dataR.Read())
                    {
                        var client = dataR.GetString(0);
                        var telephone = dataR.GetString(1);
                        var tickets = dataR.GetInt32(2);
                        var trip = dataR.GetInt32(3);
                        var agent = dataR.GetString(4);
                        var task = new Reservation(client, telephone, tickets, trip,agent);
                        tasksR.Add(task);
                    }
                }
            }

            return tasksR;
        }

        public void save(Reservation entity)
        {
            var con = DBUtils.getConnection(props);
            ReservationValidator validator = new ReservationValidator();
            try
            {
                validator.validate(entity);
            }
            catch (ValidationException exception)
            {
                throw exception;
            }
            using (var comm = con.CreateCommand())
            {
                comm.CommandText =
                    "insert into Reservation(client,telephone,tickets,trip,agent)  values (@client, @telephone, @tickets,@trip,@agent)";
                var paramId = comm.CreateParameter();
                paramId.ParameterName = "@client";
                paramId.Value = entity.Client;
                comm.Parameters.Add(paramId);

                var paramDesc = comm.CreateParameter();
                paramDesc.ParameterName = "@telephone";
                paramDesc.Value = entity.Telephone;
                comm.Parameters.Add(paramDesc);

                var paramEmail = comm.CreateParameter();
                paramEmail.ParameterName = "@tickets";
                paramEmail.Value = entity.Tickets;
                comm.Parameters.Add(paramEmail);

                var paramTrip = comm.CreateParameter();
                paramTrip.ParameterName = "@trip";
                paramTrip.Value = entity.Trip;
                comm.Parameters.Add(paramTrip);
                
                var paramAgent = comm.CreateParameter();
                paramAgent.ParameterName = "@agent";
                paramAgent.Value = entity.Agent;
                comm.Parameters.Add(paramAgent);

                var result = comm.ExecuteNonQuery();
            }
        }

        public void delete(int id)
        {
            var con = DBUtils.getConnection(props);
            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "delete from Reservation where id=@id";
                var paramId = comm.CreateParameter();
                paramId.ParameterName = "@id";
                paramId.Value = id;
                comm.Parameters.Add(paramId);
                var dataR = comm.ExecuteNonQuery();
            }
        }

        public void update(int oldId, Reservation entity)
        {
            var con = DBUtils.getConnection(props);
            using (var comm = con.CreateCommand())
            {
                comm.CommandText =
                    "update * from Reservation where id=@id set client = @client, telephone = @telephone, tickets = @tickets, trip = @trip";
                var paramId = comm.CreateParameter();
                paramId.ParameterName = "@id";
                paramId.Value = oldId;
                comm.Parameters.Add(paramId);

                var paramNume = comm.CreateParameter();
                paramId.ParameterName = "@client";
                paramId.Value = entity.Client;
                comm.Parameters.Add(paramId);

                var paramDesc = comm.CreateParameter();
                paramDesc.ParameterName = "@telephone";
                paramDesc.Value = entity.Telephone;
                comm.Parameters.Add(paramDesc);

                var paramEmail = comm.CreateParameter();
                paramEmail.ParameterName = "@tickets";
                paramEmail.Value = entity.Tickets;
                comm.Parameters.Add(paramEmail);

                var paramTrip = comm.CreateParameter();
                paramEmail.ParameterName = "@trip";
                paramEmail.Value = entity.Trip;
                comm.Parameters.Add(paramTrip);

                var dataR = comm.ExecuteNonQuery();
            }
        }
    }
}
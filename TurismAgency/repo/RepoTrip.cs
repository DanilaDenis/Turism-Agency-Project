using System.Collections.Generic;
using log4net;
using WindowsFormsApp3.domain;

namespace WindowsFormsApp3.repo
{
    public class RepoTrip : IRepository<int, Trip>
    {
        private static readonly ILog log = LogManager.GetLogger("SortingTaskDbRepository");

        private readonly IDictionary<string, string> props;

        public RepoTrip(IDictionary<string, string> props)
        {
            log.Info("Creating SortingTaskDbRepository ");
            this.props = props;
        }

        public Trip findOne(int id)
        {
            log.InfoFormat("Entering findOne with value {0}", id);
            var con = DBUtils.getConnection(props);

            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "select obiectiv,firma,plecare,pret,bilete from Trip where id=@id";
                var paramId = comm.CreateParameter();
                paramId.ParameterName = "@id";
                paramId.Value = id;
                comm.Parameters.Add(paramId);

                using (var dataR = comm.ExecuteReader())
                {
                    if (dataR.Read())
                    {
                        var obj = dataR.GetString(0);
                        var firma = dataR.GetString(1);
                        var leave = dataR.GetInt32(2);
                        var price = dataR.GetInt32(3);
                        var seats = dataR.GetInt32(4);
                        var task = new Trip(obj, firma, leave, price, seats);
                        task.Id = id;
                        log.InfoFormat("Exiting findOne with value {0}", task);
                        return task;
                    }
                }
            }
            RepoException repoException = new RepoException("Trip does not exist");
            throw repoException;
        }

        public IEnumerable<Trip> findAll()
        {
            var con = DBUtils.getConnection(props);
            IList<Trip> tasksR = new List<Trip>();
            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "select id,obiectiv,firma,plecare,bilete,pret from Trip";

                using (var dataR = comm.ExecuteReader())
                {
                    while (dataR.Read())
                    {
                        var id = dataR.GetInt32(0);
                        var obj = dataR.GetString(1);
                        var firma = dataR.GetString(2);
                        var leave = dataR.GetInt32(3);
                        var seats = dataR.GetInt32(4);
                        var price = dataR.GetInt32(5);

                        var task = new Trip(obj, firma, leave, price, seats);
                        task.Id = id;
                        tasksR.Add(task);
                    }
                }
            }

            return tasksR;
        }

        public void save(Trip entity)
        {
            var con = DBUtils.getConnection(props);

            using (var comm = con.CreateCommand())
            {
                comm.CommandText =
                    "insert into Trip(obiectiv,firma,plecare,pret,bilete)  values (@obj, @firma, @leave, @price,@seats)";
                var paramId = comm.CreateParameter();
                paramId.ParameterName = "@obj";
                paramId.Value = entity.Objective;
                comm.Parameters.Add(paramId);

                var paramDesc = comm.CreateParameter();
                paramDesc.ParameterName = "@firma";
                paramDesc.Value = entity.TransportFirm;
                comm.Parameters.Add(paramDesc);

                var paramEmail = comm.CreateParameter();
                paramEmail.ParameterName = "@leave";
                paramEmail.Value = entity.Leave;
                comm.Parameters.Add(paramEmail);

                var paramElems = comm.CreateParameter();
                paramElems.ParameterName = "@price";
                paramElems.Value = entity.Price;
                comm.Parameters.Add(paramElems);

                var paramSeats = comm.CreateParameter();
                paramSeats.ParameterName = "@seats";
                paramSeats.Value = entity.AvailableSeats;
                comm.Parameters.Add(paramSeats);

                var result = comm.ExecuteNonQuery();
            }
        }

        public void delete(int id)
        {
            var con = DBUtils.getConnection(props);
            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "delete from Trip where id=@id";
                var paramId = comm.CreateParameter();
                paramId.ParameterName = "@id";
                paramId.Value = id;
                comm.Parameters.Add(paramId);
                var dataR = comm.ExecuteNonQuery();
            }
        }

        public void update(int oldId, Trip entity)
        {
            if (findOne(oldId) == null)
            {
                RepoException repoException = new RepoException("Trip does not exist");
                throw repoException;
            }
            
            var con = DBUtils.getConnection(props);
            using (var comm = con.CreateCommand())
            {
                comm.CommandText =
                    "update Trip  set obiectiv= @obj, firma=@firma,plecare = @leave, bilete = @seats,pret =@price where id=@id";
                var paramId = comm.CreateParameter();
                paramId.ParameterName = "@id";
                paramId.Value = oldId;
                comm.Parameters.Add(paramId);

                var paramNume = comm.CreateParameter();
                paramNume.ParameterName = "@obj";
                paramNume.Value = entity.Objective;
                comm.Parameters.Add(paramNume);

                var paramDesc = comm.CreateParameter();
                paramDesc.ParameterName = "@firma";
                paramDesc.Value = entity.TransportFirm;
                comm.Parameters.Add(paramDesc);

                var paramEmail = comm.CreateParameter();
                paramEmail.ParameterName = "@leave";
                paramEmail.Value = entity.Leave;
                comm.Parameters.Add(paramEmail);

                var paramSeats = comm.CreateParameter();
                paramSeats.ParameterName = "@seats";
                paramSeats.Value = entity.AvailableSeats;
                comm.Parameters.Add(paramSeats);

                var paramElems = comm.CreateParameter();
                paramElems.ParameterName = "@price";
                paramElems.Value = entity.Price;
                comm.Parameters.Add(paramElems);


                comm.ExecuteNonQuery();
            }
        }

        public IEnumerable<Trip> findByObjective(string obj, int leave1, int leave2)
        {
            var con = DBUtils.getConnection(props);
            IList<Trip> tasksR = new List<Trip>();

            using (var comm = con.CreateCommand())
            {
                comm.CommandText =
                    "select obiectiv,firma,plecare,pret,bilete from Trip where obiectiv = @obj and plecare >= @leave1 and plecare <= @leave2";
                var paramId = comm.CreateParameter();
                paramId.ParameterName = "@obj";
                paramId.Value = obj;
                comm.Parameters.Add(paramId);

                var paraml1 = comm.CreateParameter();
                paraml1.ParameterName = "@leave1";
                paraml1.Value = leave1;
                comm.Parameters.Add(paraml1);

                var paraml2 = comm.CreateParameter();
                paraml2.ParameterName = "@leave2";
                paraml2.Value = leave2;
                comm.Parameters.Add(paraml2);

                using (var dataR = comm.ExecuteReader())
                {
                    while (dataR.Read())
                    {
                        var obiect = dataR.GetString(0);
                        var firma = dataR.GetString(1);
                        var leave = dataR.GetInt32(2);
                        var price = dataR.GetInt32(3);
                        var seats = dataR.GetInt32(4);
                        var task = new Trip(obiect, firma, leave, price, seats);
                        tasksR.Add(task);
                        log.InfoFormat("Exiting findOne with value {0}", task);
                    }
                }
            }

            log.InfoFormat("Exiting findOne with value {0}", null);
            return tasksR;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using DBSystem.DAL;
using DBSystem.ENTITIES;

namespace DBSystem.BLL
{
    public class PlayerController
    {
        public Player FindByPKID(int id)
        {
            using (var context = new ContextFSIS())
            {
                return context.Players.Find(id);
            }
        }
        public List<Player> List()
        {
            using (var context = new ContextFSIS())
            {
                return context.Players.ToList();
            }
        }
        public List<Player> FindByID(int id)
        {
            using (var context = new ContextFSIS())
            {
                IEnumerable<Player> results =
                    context.Database.SqlQuery<Player>("Player_GetByTeam @ID"
                        , new SqlParameter("ID", id));
                return results.ToList();
            }
        }
    }
}

using Ex05.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex05.Repositories
{
    public interface ITimeRepository
    {
        public IList<Time> ListaTodosTimes();
        public Time BuscarTimePorId(int id);
        public void IserirTime(Time time);
    }
}

using BusinessObjects.Models;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class TableRepository : ITableRepository
    {

        //Remeber: 1. Change Repository form private to public
        //         2. Implement Interface

        public List<Table> GetTables()
        => TableDAO.Instance.GetTables();

        //If including a sub entity
        //public List<subTable> GetsubTables()
        //=> TableDAO.Instance.GetsubTables();

        public Table GetTableById(int id)
        => TableDAO.Instance.GetTableById(id);

        public void DeleteTable(Table o)
        => TableDAO.Instance.DeleteTable(o);

        public void UpdateTable(Table o)
        => TableDAO.Instance.UpdateTable(o);

        public void SaveTable(Table o)
        => TableDAO.Instance.SaveTable(o);
    }
}

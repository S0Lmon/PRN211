using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ITableRepository
    {

        //Remeber to change interface form private to public

        List<Table> GetTables();

        //If including a sub entity
        //List<subTable> GetsubTables();

        Table GetTableById(int id);

        void DeleteTable(Table o);

        void UpdateTable(Table o);

        void SaveTable(Table o);
    }
}

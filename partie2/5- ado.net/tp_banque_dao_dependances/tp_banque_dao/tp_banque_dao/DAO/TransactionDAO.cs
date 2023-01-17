using Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_banque_dao.DAO
{
    internal class TransactionDAO : BaseDAO<Operation>
    {
        public override int Create(Operation element)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(Operation element)
        {
            throw new NotImplementedException();
        }

        public override (bool, Operation) Find(int index)
        {
            throw new NotImplementedException();
        }

        public override (bool, List<Operation>) Find(Func<Operation, bool> criteria)
        {
            throw new NotImplementedException();
        }

        public override List<Operation> FindAll()
        {
            throw new NotImplementedException();
        }

        public override bool Update(Operation element)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AggregateDataManager.Utility;

namespace AggregateDataManager.Interfaces
{
    public interface IFilter
    {
        void DefineFilter(string DataMember, Operator FilterOperator, string FilterValue);

        bool Evaluate();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregateDataManager.Interfaces
{
    public interface IDataModel
    {
        string MemberName { get; }

        string MemberValue { get; }

        Decimal? CalcuationValue { get; }
    }
}

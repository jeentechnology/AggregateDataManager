using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregateDataManager.Interfaces
{
    public interface IAggregateResponse
    {
        int ResposneCount { get; }

        int ValueCount { get; }

        decimal ScoreValue { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AggregateDataManager.Interfaces;

namespace AggregateDataManager.DataModels
{
    public class DataModel : IDataModel
    {
        public decimal? CalcuationValue { get; set; }

        public string MemberName { get; set; }

        public string MemberValue { get; set; }
    }
}

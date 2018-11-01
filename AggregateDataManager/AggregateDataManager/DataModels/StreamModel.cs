using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AggregateDataManager.Interfaces;

namespace AggregateDataManager.DataModels
{
    public class StreamModel
    {
        public List<IDataModel> DataMembers;
    }
}

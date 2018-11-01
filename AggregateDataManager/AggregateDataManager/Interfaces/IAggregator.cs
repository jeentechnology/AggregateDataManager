using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregateDataManager.Interfaces
{
    public interface IAggregator
    {
        /// <summary>
        /// Takes in a value and updates the aggregate stream
        /// </summary>
        void UpdateValue();

        /// <summary>
        /// Gets the current value of the aggregate stream
        /// </summary>
        void GetCurrentValue();
    }
}

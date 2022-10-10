using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HData.Interface
{
    public interface IFilterData
    {
        string FilterDataNo { get; set; } //Increment
        string FilterDataType { get; set; } //string, int, bool, date
        string FilterDataName { get; set; }
        string Comparator { get; set; } // =, <>, <, >, Like etc
        string FilterDataValue { get; set; } //allways as string
        
    }
}

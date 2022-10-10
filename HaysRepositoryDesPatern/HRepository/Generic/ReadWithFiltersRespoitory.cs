using HData.Interface;
using HData.Model;
using System;
using System.Linq.Dynamic.Core;
using Microsoft.EntityFrameworkCore.DynamicLinq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HRepository.Generic
{
    
    public class ReadWithFiltersRespoitory<TEintity>: ReadRepositoryGeneric<TEintity>   where TEintity: EntityMain
    {
        DataModel DBContext;

        public ReadWithFiltersRespoitory(DataModel myDataModel): base(myDataModel)
        {
            DBContext = myDataModel;
        }
       

        public IEnumerable<TEintity> GetByFilters(IEnumerable<IFilterData> filterData)
        {
            try
            {
                var myArr = filterData.OrderBy(x => x.FilterDataNo).Select(a => a.FilterDataValue).ToArray();
                var myResult = DBContext.Set<TEintity>().Where(GetStringFromFilterData(filterData), myArr);
                return myResult;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        private string GetStringFromFilterData(IEnumerable<IFilterData> filterData)
        {
            string myStr = "";
            string myAnd = "";
            int myNum = 0;
            foreach (var js in filterData.OrderBy(x=>x.FilterDataNo))
            {
                string myVal = js.FilterDataValue;
                if (js.FilterDataType.ToLower().Contains("string"))
                { 
                    myVal="'" + myVal + "'";
                }
                myStr+=string.Format(" {0} {1} {2} @{3}", myAnd, js.FilterDataName, js.Comparator, myNum);
                myNum++;
            }
            return myStr;
        }
    }
}

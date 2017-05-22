using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesProject.DataModel

{
    /// <summary>
    /// Позволяет выбрать строку подключения к базе данных в зависимости от параметра компиляции
    /// </summary>
    public class ContextDecorator : DataModelDataContext
    {
        public ContextDecorator() :
#if Debug
    base(SalesProject.Properties.Settings.Default.DBTestConnectionString)
#else
    base(SalesProject.Properties.Settings.Default.DBTestConnectionString)
#endif
        {

        }
    }
}

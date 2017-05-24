using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesProject.Controlles
{
    /// <summary>
    /// Интерфейс, предоставляющий доступ к модели
    /// </summary>
    /// <typeparam name="TModel">Тип модели</typeparam>
    class IModelController<TModel> where TModel : /*System.ComponentModel.INotifyPropertyChanged,*/ new() 
    {
        /// <summary>
        /// Получает модель, управляемую контроллером 
        /// </summary>
        TModel Model { get; set; }


    
    }
}

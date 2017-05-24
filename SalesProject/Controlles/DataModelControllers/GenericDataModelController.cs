using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SalesProject.Controlles
{
    /// <summary>
    /// Базовый контроллер для работы с моделью
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    class GenericDataModelController<TModel>: IModelController<TModel> where TModel : /*System.ComponentModel.INotifyPropertyChanged,*/ new()
    {
        private TModel model = default(TModel);

        public TModel Model
        {
            get
            {
                if (model == null)
                {
                    model = new TModel();
                    
                }
                return model;
            }
            set
            {
                
                model = value;
            }

        }
    }
}

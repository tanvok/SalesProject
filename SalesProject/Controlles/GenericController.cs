using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesProject.Controlles.Interfaces;

namespace SalesProject.Controlles
{
    class GenericController<TModel>: IModelController<TModel> where TModel : /*System.ComponentModel.INotifyPropertyChanged,*/ new()
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

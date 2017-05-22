using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Data.Linq;
using SalesProject.DataModel;
using SalesProject.Controlles.Interfaces;


/// <summary>
/// основной контроллер-одиночка приложения, через который прозводится доступ к базе данных
/// </summary>
namespace SalesProject.Controlles
{
    class DataModelController: GenericController<ContextDecorator>
    {
        private static DataModelController instance;

        /// <summary>
        /// Получает единственный экземпляр контроллера
        /// </summary>
        public static DataModelController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataModelController();
                }
                return instance;
            }
        }


        

        /// <summary>
        /// Сохраняет изменения в модели
        /// </summary>
        public void SubmitChanges()
        {
            //Contract.Requires(Model != null);
            //try
            //{
            Model.SubmitChanges();
            //}

            //catch
            //{
            //    if (recreate == SubmitParams.RecreateModel)
            //    {
            //DeleteModel();
            //throw new ApplicationException("При сохранении данных возникла ошибка. Изменения будут отменены.");
            //    }

            //}

        }


        
        public ContextDecorator NewModel()
        {
            return new ContextDecorator();
        }

        public void DeleteModel()
        {
            //Model.Refresh(RefreshMode.OverwriteCurrentValues);
            Model = null;
            //обращаемся к модели, чтобы обновились все представления
            Model.SubmitChanges();

        }



        private string GetCurrentUser()
        {
            return System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        }

        

        internal void ShowApplicationException(Exception e)
        {
            System.Windows.Forms.MessageBox.Show(e.Message,
                "ИС Учет продаж", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
        }
    }
}



/*

namespace Kadr.Controllers
{

    public class KadrController : UIX.Controllers.GenericController<ContextDecorator>
    {

        /// <summary>
        /// Текущая версия БД (для проверки соотвествия)
        /// </summary>
        private const string CurrentDBVersion = "1.1";

        public event EventHandler<SubmitModelChangesArgs> SubmitingModelChanges;
        public event EventHandler<SubmitModelChangesArgs> SubmitModelChanges;

        //событие при создании модели
        public event EventHandler CreatingModel;

        private static KadrController instance;


        private KadrController()
        {
        }

        /// <summary>
        /// Проверка соответсвия версии БД
        /// </summary>
        /// <returns></returns>
        public bool CheckDataBaseVersion()
        {
            urn true;
        }

        protected override void OnModelCreated()
        {
            base.OnModelCreated();
            if (CreatingModel != null)
                CreatingModel(KadrController.Instance, EventArgs.Empty);
            KadrController.Instance.Model.CommandTimeout = 100000;

        }

        


        #region OtherMethods

        /// <summary>
        /// Возвращиет список отделов, соответсвующих представлению departments
        /// </summary>
        /// <param name="departments"></param>
        /// <returns></returns>
        public IEnumerable<Dep> GetDepsForDepartments(IEnumerable<Department> departments)
        {
            return departments.SelectMany(dep => KadrController.Instance.Model.Deps.Where(departs => departs.id == dep.id));


            /*.Join(Model.Deps, department => department.id, dep => dep.id,
                (department, dep) => new Dep
                {
                    id = dep.id,
                    //idManagerDapartment = subDeps.idManagerDepartment,
                    idManagerPlanStaff = dep.idManagerPlanStaff,
                    idDepartmentType = dep.idDepartmentType,
                    KadrID = dep.KadrID,
                    dateExit = dep.dateExit,
                    idEndPrikaz = dep.idEndPrikaz,
                    SeverKoeff = dep.SeverKoeff,
                    RayonKoeff = dep.RayonKoeff,
                    DepartmentGUID = dep.DepartmentGUID
                });*/
        //}

        /*public void AddFactStaff(System.Windows.Forms.BindingSource factStaffBindingSource, PlanStaff planStaffCurrent, Dep department = null, WorkType workType = null)
        {
            if (workType == null)
                workType = NullWorkType.Instance;

            using (Kadr.UI.Common.PropertyGridDialogAdding<FactStaff> dlg =
                 new Kadr.UI.Common.PropertyGridDialogAdding<FactStaff>())
            {
                dlg.ObjectList = KadrController.Instance.Model.FactStaffs;
                dlg.BindingSource = factStaffBindingSource;
                dlg.UseInternalCommandManager = true;
                dlg.PrikazButtonVisible = true;
                dlg.InitializeNewObject = (x) =>
                {
                    FactStaffHistory fcStHistory = new FactStaffHistory();
                    dlg.CommandManager.Execute(new UIX.Commands.GenericPropertyCommand<FactStaff, PlanStaff>(x, "PlanStaff", planStaffCurrent, null), this);
                    //dlg.CommandManager.Execute(new UIX.Commands.GenericPropertyCommand<FactStaff, Dep>(x, "Dep", (planStaffBindingSource.Current as PlanStaff).Dep, null), this);
                    if ((dlg.SelectedObjects != null) && (dlg.SelectedObjects.Length == 1))
                    {
                        FactStaff prev = dlg.SelectedObjects[0] as FactStaff;
                        //dlg.CommandManager.Execute(new UIX.Commands.GenericPropertyCommand<FactStaffHistory, DateTime?>(fcStHistory, "DateBegin", prev.CurrentChange.DateBegin, null), this);
                        //dlg.CommandManager.Execute(new UIX.Commands.GenericPropertyCommand<FactStaffHistory, prikaz>(fcStHistory, "prikaz", prev.PrikazBegin, null), this);
                        //dlg.CommandManager.Execute(new UIX.Commands.GenericPropertyCommand<FactStaffHistory, WorkType>(fcStHistory, "WorkType", prev.WorkType, null), this);
                        //dlg.CommandManager.Execute(new UIX.Commands.GenericPropertyCommand<FactStaffHistory, decimal>(fcStHistory, "StaffCount", prev.StaffCount, null), this);
                        dlg.CommandManager.Execute(new UIX.Commands.GenericPropertyCommand<FactStaff, DateTime?>(x, "DateBegin", prev.DateBegin, null), this);
                        dlg.CommandManager.Execute(new UIX.Commands.GenericPropertyCommand<FactStaff, prikaz>(x, "PrikazBegin", prev.PrikazBegin, null), this);
                        dlg.CommandManager.Execute(new UIX.Commands.GenericPropertyCommand<FactStaff, WorkType>(x, "WorkType", prev.WorkType, null), this);
                        dlg.CommandManager.Execute(new UIX.Commands.GenericPropertyCommand<FactStaff, decimal>(x, "StaffCount", prev.StaffCount, null), this);

                        dlg.CommandManager.Execute(new UIX.Commands.GenericPropertyCommand<FactStaff, Employee>(x, "Employee", NullEmployee.Instance, null), this);

                    }
                    else
                    {
                        dlg.CommandManager.Execute(new UIX.Commands.GenericPropertyCommand<FactStaffHistory, prikaz>(fcStHistory, "prikaz", NullPrikaz.Instance, null), this);
                        dlg.CommandManager.Execute(new UIX.Commands.GenericPropertyCommand<FactStaffHistory, WorkType>(fcStHistory, "WorkType", workType, null), this);
                        //dlg.CommandManager.Execute(new UIX.Commands.GenericPropertyCommand<FactStaff, prikaz>(x, "PrikazBegin", NullPrikaz.Instance, null), this);
                        //dlg.CommandManager.Execute(new UIX.Commands.GenericPropertyCommand<FactStaff, WorkType>(x, "WorkType", NullWorkType.Instance, null), this);
                        dlg.CommandManager.Execute(new UIX.Commands.GenericPropertyCommand<FactStaff, Employee>(x, "Employee", NullEmployee.Instance, null), this);
                    }
                    dlg.CommandManager.Execute(new UIX.Commands.GenericPropertyCommand<FactStaff, bool>(x, "IsReplacement", false, null), this);
                    dlg.CommandManager.Execute(new UIX.Commands.GenericPropertyCommand<FactStaff, Dep>(x, "Dep", department, null), this);
                    dlg.CommandManager.Execute(new UIX.Commands.GenericPropertyCommand<FactStaff, FundingCenter>(x, "FundingCenter", NullFundingCenter.Instance, null), this);
                    //dlg.CommandManager.Execute(new UIX.Commands.GenericPropertyCommand<FactStaffHistory, decimal>(fcStHistory, "SalaryKoeff", 1, null), this);
                    dlg.CommandManager.Execute(new UIX.Commands.GenericPropertyCommand<FactStaffHistory, FactStaff>(fcStHistory, "FactStaff", x, null), this);
                };

                dlg.UpdateObjectList = () =>
                {
                    dlg.ObjectList = KadrController.Instance.Model.FactStaffs;
                };
                dlg.ShowDialog();
            }
        }*/



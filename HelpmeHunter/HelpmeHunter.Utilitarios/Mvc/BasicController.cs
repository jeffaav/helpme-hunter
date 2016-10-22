using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using HelpmeHunter.Utilitarios;

namespace HelpmeHunter.Utilitarios.Mvc
{
    public class BasicController : Controller
    {
        private const string VIEWMODEL = "VIEWMODEL";
        private const string MODEL_ERRORS = "MODEL_ERRORS";

        public void GuardarViewModel<T>(T viewModel) where T : class
        {
            var modelErrors = new Dictionary<string, List<string>>();
            var values = ModelState.Values.ToList();
            var keys = ModelState.Keys.ToList();

            for (int i = 0; i < values.Count; i++)
            {
                var errors = values[i].Errors;

                foreach (var item in errors)
                {
                    modelErrors.AddDuplicate(keys[i], item.ErrorMessage);
                }
            }
            TempData[VIEWMODEL] = viewModel;
            TempData[MODEL_ERRORS] = modelErrors;
        }

        public T ObtenerViewModel<T>() where T : class, new()
        {
            var modelErrors = TempData[MODEL_ERRORS] as Dictionary<string, List<string>>;
            var _viewModel = TempData[VIEWMODEL];
            var viewModel = new T();

            if (_viewModel != null && _viewModel.GetType() == typeof(T))
            {
                viewModel = _viewModel as T;
            }
            else
            {
                return null;
            }

            if (modelErrors != null)
            {
                foreach (var item in modelErrors)
                {
                    foreach (var error in item.Value)
                    {
                        ModelState.AddModelError(item.Key, error);
                    }
                }
            }

            return viewModel;
        }
    }
}

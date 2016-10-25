using HelpmeHunter.Presentacion.Landing.ViewModels.Cuenta;
using HelpmeHunter.Repositorios;
using HelpmeHunter.Utilitarios;
using HelpmeHunter.Utilitarios.Mvc;
using System.Web.Mvc;
using System.Linq;

namespace HelpmeHunter.Presentacion.Landing.Controllers
{
    public class CuentaController : BasicController
    {
        private readonly RepositorioSector repositorioSector;
        private readonly RepositorioPais repositorioPais;
        private readonly RepositorioPuesto repositorioPuesto;

        public CuentaController(RepositorioSector repositorioSector, RepositorioPais repositorioPais, RepositorioPuesto repositorioPuesto)
        {
            this.repositorioSector = repositorioSector;
            this.repositorioPais = repositorioPais;
            this.repositorioPuesto = repositorioPuesto;
        }

        public ActionResult Index()
        {
            return View(ObtenerViewModel<IndexVM>() ?? new IndexVM());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(IndexVM viewModel)
        {
            if (ModelState.IsValid)
            {

            }

            GuardarViewModel(viewModel);
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Empresa()
        {
            var viewModel = ObtenerViewModel<EmpresaVM>() ?? new EmpresaVM();
            viewModel.Sectores = repositorioSector.Listar().ToSelectList("IdSector", "Nombre");
            viewModel.Paises = repositorioPais.Listar().ToSelectList("IdPais", "Nombre");

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Empresa(EmpresaVM viewModel)
        {
            if (ModelState.IsValid)
            {
                var idPuesto = repositorioPuesto.Obtener(p => p.Nombre == viewModel.PuestoActual).IdPuesto;
            }

            GuardarViewModel(viewModel);
            return RedirectToAction(nameof(Empresa));
        }

        public ActionResult Profesional()
        {
            return View();
        }

        public ActionResult Consultor()
        {
            return View();
        }

        public JsonResult ListarPuestos(string query)
        {
            query = string.IsNullOrWhiteSpace(query) ? string.Empty : query.Trim();
            return Json(repositorioPuesto
                .Listar(p => query == "" || p.Nombre.Contains(query))
                .Select(p => p.Nombre)
                .ToList(), JsonRequestBehavior.AllowGet);
        }
    }
}
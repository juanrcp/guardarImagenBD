using EntityDAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace guardarImagenBD.Pages
{
    //Clase para extraer la imagenes de la BD
    public class VistaImagenesModel : PageModel
    {
        private EntityDAL.bD_ImagenDataContext _contexto;

        [BindProperty]
        public List<Imagen> ListaImagenes {  get; set; }

        public VistaImagenesModel(EntityDAL.bD_ImagenDataContext contexto)
        {
            _contexto = contexto;
        }

        //Para extraer la imagenes de la base de datos simplemente hacemos una lista de la entidad
        public void OnGet()
        {
            if (_contexto.Imagenes != null)
            {
                ListaImagenes = _contexto.Imagenes.ToList();

            }
        }
    }
}

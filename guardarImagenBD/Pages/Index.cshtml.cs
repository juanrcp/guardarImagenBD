using EntityDAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Drawing;

namespace guardarImagenBD.Pages
{
    public class IndexModel : PageModel
    {

        //Contexto
        private EntityDAL.bD_ImagenDataContext _contexto;

        //Tipo imagen de nuestra BD al que le insertaremos la foto y posteriormente la guardamos en la BD.
        [BindProperty]
        public Imagen Imagen { get; set; }

        //Mensaje de confirmacion
        public string Mensaje { get; set; }

        //Contructor del contexto 
        public IndexModel(EntityDAL.bD_ImagenDataContext contexto)
        {
            _contexto = contexto;
        }

        //Metodo post 
        public void OnPostSubmit()
        {
            if (Imagen.Datos_Imagen != null)
            {
                byte[] arrayBytes = null;

                //Aqui hacemos la tranformacion de imagen a bytes[]
                using (Stream st = Imagen.Datos_Imagen.OpenReadStream())
                {
                    using (BinaryReader br = new BinaryReader(st))
                    {
                        arrayBytes = br.ReadBytes((int)st.Length);
                    }
                }

                //Guardamos la traduccion de la imagen en bytes en el cod_Imagen
                Imagen.Cod_Imagen = Convert.ToBase64String(arrayBytes);

                _contexto.Imagenes.Add(Imagen);

                _contexto.SaveChangesAsync();

                Mensaje = "Imagen Guardada";

            }
        }
    }
}
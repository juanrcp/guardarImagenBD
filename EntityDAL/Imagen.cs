using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDAL
{
    public class Imagen
    {
        //Declaramos atributos con sus propiedades.
        [Key]
        public int Id { get; set; }

        //Aqui guardaremos la imagen en codigo byte
        [Column]
        public string Cod_Imagen { get; set; }

        //Esto nos ayudara a recibir directamente la imagen, aunque no se mapeara en la BD
        [NotMapped]
        public IFormFile Datos_Imagen { get; set; }
    }
}

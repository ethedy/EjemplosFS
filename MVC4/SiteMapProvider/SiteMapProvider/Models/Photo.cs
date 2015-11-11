using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SiteMapProvider.Models
{
  public class Photo
  {
    public int PhotoID { get; set; }

    [Required(ErrorMessage = "El campo de titulo debe estar completo")]
    public string Title { get; set; }

    [DisplayName("Foto")]
    public byte[] Photofile { get; set; }

    public string ImageMimeType { get; set; }

    [DataType(DataType.MultilineText)]
    public string Description { get; set; }

    [DataType(DataType.DateTime)]
    [DisplayName("Fecha de Creación")]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yy}")]
    public DateTime CreatedDate { get; set; }

    public string UserName { get; set; }
    //
    //  propiedades de navegacion
    public ICollection<Comment> Comments { get; set; }

    public Photo()
    {
      Comments = new List<Comment>();
    }
  }
}

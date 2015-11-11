using System.ComponentModel.DataAnnotations;

namespace SiteMapProvider.Models
{
  public class Comment
  {
    public int CommentID { get; set; }

    //  FK expuesta como propiedad... (redundante con la nav-prop Photo)
    public int PhotoID { get; set; }

    public string UserName { get; set; }

    [Required(ErrorMessage = "Debe completar el campo del asunto")]
    [StringLength(250, ErrorMessage = "El asunto no debe superar los 250 caracteres")]
    public string Subject { get; set; }

    [DataType(DataType.MultilineText)]
    public string Body { get; set; }
    //
    //  propiedades de navegacion
    public virtual Photo Photo { get; set; }
  }
}

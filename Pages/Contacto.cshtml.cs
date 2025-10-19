using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace netflix_de_libros_razor_pages.Pages;
public class ContactoModel : PageModel
{
    [BindProperty]
    [Required(ErrorMessage = "El campo Nombre es obligatorio.")]
    [StringLength(100, ErrorMessage = "El campo Nombre no puede exceder los 100 caracteres.")]
    public String Nombre { get; set; } = string.Empty;

    [BindProperty]
    [Required(ErrorMessage = "El campo Email es obligatorio.")]
    [EmailAddress(ErrorMessage = "El campo Email no es una dirección de correo electrónico válida.")]
    [StringLength(100, ErrorMessage = "El campo Email no puede exceder los 100 caracteres.")]
    public String Email { get; set; } = string.Empty;

    [BindProperty]
    [Required(ErrorMessage = "El mensaje es obligatorio")]
    [StringLength(1000, ErrorMessage = "El mensaje no puede tener más de 1000 caracteres")]
    public string Mensaje { get; set; } = string.Empty;

    public string? MensajeExito { get; set; }
    public bool MensajeEnviado { get; set; }

    public void OnGet()
    {
    }
}
using System.ComponentModel.DataAnnotations;

namespace SeuProjeto.Models
{
    public class ContactFormModel
    {
        [Required(ErrorMessage = "Por favor, insira seu nome.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Por favor, insira seu email.")]
        [EmailAddress(ErrorMessage = "Por favor, insira um email válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Por favor, insira sua mensagem.")]
        [MaxLength(500, ErrorMessage = "Sua mensagem não pode exceder 500 caracteres.")]
        public string Mensagem { get; set; }
    }
}

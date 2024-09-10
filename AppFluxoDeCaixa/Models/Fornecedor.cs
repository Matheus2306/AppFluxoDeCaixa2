using System.ComponentModel.DataAnnotations;

namespace AppFluxoDeCaixa.Models
{
    public class Fornecedor
    {
        public Guid Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O Campo Nome é Obrigatório!")]
        [MaxLength(100, ErrorMessage = "O Limite do campo é de 100 Caracteres!")]
        [MinLength(3, ErrorMessage = "O Campo Nome deve ter, no mínimo, 3 Caracters")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo CNPJ é obrigatório!")]
        [MinLength(14, ErrorMessage = "O campo deve ter 14 digitos numéricos")]
        [MaxLength(14, ErrorMessage = "O campo deve conter no maximo 14 digitos")]
        public string CNPJ { get; set; }
        [DataType(DataType.EmailAddress)]
        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "O Campo E-mail é Obrigatório!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "O campo Telefone é obrigatório")]
        [MinLength(11, ErrorMessage = "O campo deve Conter 11 digitos numéricos")]
        [MaxLength(11, ErrorMessage = "O campo deve conter no maximo 11 digitos")]
        public string Telefone { get; set; }
        [Display(Name = "Data de Cadastro")]
        [Required(ErrorMessage = "O Campo Data de Cadastro é Obrigatório!")]
        public DateTime DataCadastro { get; set; }
        [Display(Name = "Ativo?")]
        public bool Ativo { get; set; }
    }
}

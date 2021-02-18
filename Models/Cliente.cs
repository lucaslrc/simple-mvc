using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace simple_mvc.Models
{
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        [Required]
        [BindProperty]
        public string Nome { get; set; }

        [Required]
        [Range(1, 11)]
        public string Cpf { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }
        
        [Required]
        [DataType(DataType.Text)]
        public string Sexo { get; set; }
        
        [Required]
        [DataType(DataType.PostalCode), StringLength(8)]
        public string Cep { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Endereco { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Numero { get; set; }

        [DataType(DataType.Text)]
        public string Complemento { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Bairro { get; set; }

        [Required]
        [StringLength(2)]
        public string Estado { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Cidade { get; set; }
    }
}
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace CadastroCliente.Models
{
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        [BindProperty]
        public string Nome { get; set; }

        // [DataType(DataType.Date)]
        // public DateTime DataNascimento { get; set; }

        // [DataType(DataType.Text)]
        // public string Sexo { get; set; }

        // [StringLength(8)]
        // [DataType(DataType.PostalCode)]
        // public string Cep { get; set; }

        // [DataType(DataType.Text)]
        // public string Endereco { get; set; }

        // [DataType(DataType.Text)]
        // public string Numero { get; set; }

        // [DataType(DataType.Text)]
        // public string Complemento { get; set; }

        // [DataType(DataType.Text)]
        // public string Bairro { get; set; }

        // [StringLength(2)]
        // public string Estado { get; set; }

        // [DataType(DataType.Text)]
        // public string Cidade { get; set; }
    }
}
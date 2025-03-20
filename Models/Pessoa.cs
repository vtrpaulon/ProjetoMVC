using Sistem;
using Sistem.Linq;

namespace ProjetoMVC.Models
{

    public class Pessoa
    {
        public int Id { get; set; }
        private string nome { get; set; }
        private string CPF { get; set; }
        private string RG { get; set; }
        private Date DataNascimento { get; set; }
    }
}
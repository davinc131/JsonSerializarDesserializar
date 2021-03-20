using System;
using System.Collections.Generic;
using System.Text;

namespace SerializarJson.Model
{
  public class Usuario
  {
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public string Email { get; set; }
    public Endereco Endereco { get; set; }
  }
}

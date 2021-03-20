using System;
using System.Collections.Generic;
using System.Text;

namespace SerializarJson.Model
{
  public class RepositorioDeUsuario
  {
    public List<Usuario> Usuarios = new List<Usuario>();
    public RepositorioDeUsuario()
    {
      Usuarios.Add(new Usuario()
      {
        Nome = "Fabiana",
        Sobrenome = "Allana de Paula",
        Email = "ffabianaallanadepaula@runup.com.br",
        Endereco = new Endereco()
        {
          Logradouro = "Rua 3",
          Cidade = "Goiânia",
          Estado = "GO",
          Bairro = "Água Branca",
          Numero = "160",
          Cep = "74723-200"
        }
      });
      Usuarios.Add(new Usuario()
      {
        Nome = "Tiago",
        Sobrenome = "Carlos Pereira",
        Email = "tiagocarlospereira..tiagocarlospereira@petcamp.com.br",
        Endereco = new Endereco()
        {
          Logradouro = "Rua das Chácaras",
          Cidade = "Goiânia",
          Estado = "GO",
          Bairro = "Vila João Vaz",
          Numero = "572",
          Cep = "74445-060"
        }
      });
      Usuarios.Add(new Usuario()
      {
        Nome = "Manuel",
        Sobrenome = "Miguel Daniel Assunção",
        Email = "manuelmigueldanielassuncao__manuelmigueldanielassuncao@steadyoffice.com.br",
        Endereco = new Endereco()
        {
          Logradouro = "Rua Álvaro José Moraes",
          Cidade = "Goiânia",
          Estado = "GO",
          Bairro = "Residencial Buena Vista I",
          Numero = "699",
          Cep = "74394-205"
        }
      });
      Usuarios.Add(new Usuario()
      {
        Nome = "Laura",
        Sobrenome = "Fabiana Figueiredo",
        Email = "laurafabianafigueiredo..laurafabianafigueiredo@indaseg.com.br",
        Endereco = new Endereco()
        {
          Logradouro = "Rua Mármore",
          Cidade = "Goiânia",
          Estado = "GO",
          Bairro = "Setor Goiânia 2",
          Numero = "746",
          Cep = "74663-420"
        }
      });
      Usuarios.Add(new Usuario()
      {
        Nome = "Hadassa",
        Sobrenome = "Rafaela Ramos",
        Email = "hadassarafaelaramos_@akadnyx.com.br",
        Endereco = new Endereco()
        {
          Logradouro = "Rua Linda Vista",
          Cidade = "Goiânia",
          Estado = "GO",
          Bairro = "Setor Morada do Sol",
          Numero = "939",
          Cep = "74475-112"
        }
      });
      Usuarios.Add(new Usuario()
      {
        Nome = "Joana",
        Sobrenome = "Jennifer Monteiro",
        Email = "joanajennifermonteiro__joanajennifermonteiro@tirantea.com.br",
        Endereco = new Endereco()
        {
          Logradouro = "Rua 94A",
          Cidade = "Goiânia",
          Estado = "GO",
          Bairro = "Setor Sul",
          Numero = "449",
          Cep = "74083-070"
        }
      });
    }
  }
}

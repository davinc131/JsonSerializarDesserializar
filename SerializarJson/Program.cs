using System;
using System.Collections.Generic;
using System.IO;
using SerializarJson.Model;
using Newtonsoft;
using Newtonsoft.Json;

namespace SerializarJson
{
  class Program
  {
    static void Main(string[] args)
    {
      string nomeArquivo = DateTime.Now.ToString().Replace(@"/", "").Replace(" ", "").Replace(":", "") + ".json";
      DeserilizarListaDeObjetos();
    }

    #region Serialização

    private static void SerializarUmObjeto(string nomeArquivo)
    {
      Usuario usuario = new Usuario()
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
      };

      using (StreamWriter stream = new StreamWriter(Path.Combine(@"C:\Users\davin\Documents\Serializar", nomeArquivo)))
      {
        JsonSerializer serializer = new JsonSerializer();
        serializer.Serialize(stream, usuario);
      }
    }

    private static void SerializarListaDeObjetos(string nomeArquivo)
    {
      RepositorioDeUsuario repositorio = new RepositorioDeUsuario();

      using (StreamWriter stream = new StreamWriter(Path.Combine(@"C:\Users\davin\Documents\Serializar", nomeArquivo)))
      {
        JsonSerializer serializer = new JsonSerializer();
        serializer.Serialize(stream, repositorio);
      }
    }

    #endregion

    #region Desserialização

    private static void DeserilizarUmObjeto()
    {
      Usuario usuario = null;
      using (StreamReader stream = new StreamReader(@"C:\Users\davin\Documents\Serializar\19032021010427.json"))
      {
        string jsonString = stream.ReadToEnd();
        usuario = JsonConvert.DeserializeObject<Usuario>(jsonString);
      }
      Console.WriteLine(string.Format(" Nome: {0}, \n Sobrenome: {1}, \n Email: {2}, \n \n Endereço \n Logradouro: {3}, \n Bairro: {4}, \n Numero: {5}, \n Cep: {6}, \n Cidade: {7}, \n Estado: {8}",
                          usuario.Nome, usuario.Sobrenome, usuario.Email, usuario.Endereco.Logradouro, usuario.Endereco.Bairro, usuario.Endereco.Numero, usuario.Endereco.Cep, usuario.Endereco.Cidade, usuario.Endereco.Estado));
    }

    private static void DeserilizarListaDeObjetos()
    {
      List<Usuario> usuarios = null;
      using (StreamReader stream = new StreamReader(@"C:\Users\davin\Documents\Serializar\19032021010907.json"))
      {
        string jsonString = stream.ReadToEnd();
        usuarios = JsonConvert.DeserializeObject<List<Usuario>>(jsonString);
      }
      foreach(Usuario usuario in usuarios)
      {
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine(string.Format(" Nome: {0}, \n Sobrenome: {1}, \n Email: {2}, \n \n Endereço \n Logradouro: {3}, \n Bairro: {4}, \n Numero: {5}, \n Cep: {6}, \n Cidade: {7}, \n Estado: {8}",
                          usuario.Nome, usuario.Sobrenome, usuario.Email, usuario.Endereco.Logradouro, usuario.Endereco.Bairro, usuario.Endereco.Numero, usuario.Endereco.Cep, usuario.Endereco.Cidade, usuario.Endereco.Estado));
      }
    }

    #endregion
  }
}

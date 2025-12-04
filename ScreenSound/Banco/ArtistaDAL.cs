using Microsoft.Data.SqlClient;
using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Banco
{
    internal class ArtistaDAL
    {
        public IEnumerable<Artista> Listar()
        {
            using var context = new ScreenSoundContext();
            // LISTA
            return context.Artistas.ToList();
        }

 
        public void Adicionar(Artista artista)
        {
            using var context = new ScreenSoundContext();
            context.Artistas.Add(artista);
            context.SaveChanges();  
        }

        /*
 public void Atualizar(Artista artista)
 {
     using var connection = new ScreenSoundContext().ObterConexao();
     connection.Open();

     string sql = $"UPDATE Artistas SET Nome = @nome, Bio = @bio WHERE Id = @id";
     SqlCommand command = new SqlCommand(sql, connection);

     command.Parameters.AddWithValue("@nome", artista.Nome);
     command.Parameters.AddWithValue("@bio", artista.Bio);
     command.Parameters.AddWithValue("@id", artista.Id);

     int retorno = command.ExecuteNonQuery();

     Console.WriteLine($"Linhas afetadas: {retorno}");
 }

 public void Deletar(Artista artista)
 {
     using var connection = new ScreenSoundContext().ObterConexao();
     connection.Open();

     string sql = $"DELETE FROM Artistas WHERE Id = @id";
     SqlCommand command = new SqlCommand(sql, connection);

     command.Parameters.AddWithValue("@id", artista.Id);

     int retorno = command.ExecuteNonQuery();

     Console.WriteLine($"Linhas afetadas: {retorno}");
 }
 */


    }
}

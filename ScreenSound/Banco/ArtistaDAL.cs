using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Banco
{
    internal class ArtistaDAL : DAL<Artista>
    {
        // 1. Armazena a instância do contexto (DbContext)
        private readonly ScreenSoundContext context;

        // 2. Construtor: Recebe a instância do contexto (Injeção de Dependência)
        public ArtistaDAL(ScreenSoundContext context)
        {
            this.context = context;
        }


        public override IEnumerable<Artista> Listar()
        {
           // using var context = new ScreenSoundContext();
            // LISTA
            // Usa o contexto já existente
            return context.Artistas.ToList();
        }



        public override void Adicionar(Artista artista)
        {
            using var context = new ScreenSoundContext();
            context.Artistas.Add(artista);
            context.SaveChanges();  
        }

        public override void Atualizar(Artista artista)
        {
            // Usa o método Update do EF Core
            context.Artistas.Update(artista);
            context.SaveChanges();
        }

        public override void Deletar(Artista artista)
        {
            // Usa o método Remove do EF Core
            context.Artistas.Remove(artista);
            context.SaveChanges();
        }

        public Artista? RecuperarPeloNome(string nome)
        {
            // Método útil para buscar
            return context.Artistas.FirstOrDefault(a => a.Nome.Equals(nome));
        }


    }
}

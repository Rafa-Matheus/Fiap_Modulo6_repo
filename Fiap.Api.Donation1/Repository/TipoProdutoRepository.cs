using Fiap.Api.Donation1.Data;
using Fiap.Api.Donation1.Models;
using Fiap.Api.Donation1.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Api.Donation1.Repository
{
    public class TipoProdutoRepository : ITipoProdutoRepository
    {
        private readonly DataContext dataContext;

        public TipoProdutoRepository(DataContext ctx)
        {
            dataContext = ctx;
        }

        public async Task<IList<TipoProdutoModel>> FindAll()
        {
            var tipos = await dataContext.TipoProdutos.ToListAsync();
            return tipos == null ? new List<TipoProdutoModel>() : tipos;
        }


        public async Task<TipoProdutoModel> FindById(int id)
        {
            var tipo = await dataContext
                           .TipoProdutos
                           .AsNoTracking()
                           .FirstOrDefaultAsync(t => t.TipoProdutoId == id);

            return tipo;
        }

        public async Task<int> Insert(TipoProdutoModel tipoModel)
        {
            dataContext.TipoProdutos.Add(tipoModel);
            dataContext.SaveChanges();

            return tipoModel.TipoProdutoId;
        }


        public async void Update(TipoProdutoModel tipoModel)
        {
            dataContext.TipoProdutos.Update(tipoModel);
            dataContext.SaveChanges();
        }

        public async void Delete(TipoProdutoModel tipoModel)
        {
            dataContext.TipoProdutos.Remove(tipoModel);
            dataContext.SaveChanges();
        }

        public async void Delete(int id)
        {
            var tipoModel = new TipoProdutoModel()
            {
                TipoProdutoId = id,
            };

            Delete(tipoModel);
        }

    }
}
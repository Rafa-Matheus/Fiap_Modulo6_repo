using Fiap.Api.Donation1.Models;

namespace Fiap.Api.Donation1.Repository.Interface
{
    public interface IUsuarioRepository
    {
        public UsuarioModel FindByEmailAndSenha(string email, string senha);

        public UsuarioModel FindById(int id);

        public IList<UsuarioModel> FindAll();

        public void Delete(int id);

        public int Insert(UsuarioModel usuarioModel);

        public void Update(UsuarioModel usuarioModel);
    }
}

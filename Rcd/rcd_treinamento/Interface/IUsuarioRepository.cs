using rcd_treinamento.Domains;

namespace rcd_treinamento.Interface
{
    public interface IUsuarioRepository
    {
      
        void Cadastrar(Usuario usuarios);
        List<Usuario> Listar();

        Usuario BuscarPorId(Guid id);

        void Atualizar(Guid id, Usuario usuarios);

        void Deletar(Guid id);

        
    }
}

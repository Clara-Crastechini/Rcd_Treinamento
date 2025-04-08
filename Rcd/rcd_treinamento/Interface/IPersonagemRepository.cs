using rcd_treinamento.Domains;

namespace rcd_treinamento.Interface
{
    public interface IPersonagemRepository
    {
        void Cadastrar(Personagem personagem);
        List<Personagem> Listar();

        void Atualizar(Guid id, Personagem personagem);

        void Deletar(Guid id);

    }
    
}

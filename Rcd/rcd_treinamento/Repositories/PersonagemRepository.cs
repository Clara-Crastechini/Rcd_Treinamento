using rcd_treinamento.Contexts;
using rcd_treinamento.Domains;
using rcd_treinamento.Interface;

namespace rcd_treinamento.Repositories
{
    public class PersonagemRepository : IPersonagemRepository
    {

        private readonly Context _context;

        public PersonagemRepository(Context context)
        {
            _context = context;
        }



        public void Atualizar(Guid id, Personagem personagem)
        {
            try
            {
                Personagem personagemBuscado = _context.Personagem.Find(id)!;

                if (personagemBuscado != null)
                {
                    personagemBuscado.NomePersonagem = personagem.NomePersonagem;
                    personagemBuscado.Habilidade = personagem.Habilidade;
                }

                _context.Personagem.Update(personagemBuscado!);

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Cadastrar(Personagem personagem)
        {
            try
            {
                personagem.PersonagemId = Guid.NewGuid();
                _context.Personagem.Add(personagem);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Deletar(Guid id)
        {
            try
            {
                Personagem personagemBuscado = _context.Personagem.Find(id)!;

                if (personagemBuscado != null)
                {
                    _context.Personagem.Remove(personagemBuscado);
                }

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Personagem> Listar()
        {

            try
            {
                return _context.Personagem.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

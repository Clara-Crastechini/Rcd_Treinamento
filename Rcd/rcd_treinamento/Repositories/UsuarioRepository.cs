using rcd_treinamento.Contexts;
using rcd_treinamento.Domains;
using rcd_treinamento.Interface;

namespace rcd_treinamento.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {

        private readonly Context _context;

        public UsuarioRepository(Context context)
        {
            _context = context;
        }


        public void Atualizar(Guid id, Usuario usuarios)
        {
            try
            {
                Usuario usuarioBuscado = _context.Usuario.Find(id)!;

                if (usuarioBuscado != null)
                {
                    usuarioBuscado.NomeUsuario = usuarios.NomeUsuario;
                    usuarioBuscado.NickName = usuarios.NickName;
                }

                _context.Usuario.Update(usuarioBuscado!);

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Usuario BuscarPorId(Guid id)
        {

            try
            {
                return _context.Usuario.Find(id)!;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Cadastrar(Usuario usuario)
        {
            try
            {
                usuario.UsuarioId = Guid.NewGuid();
                _context.Usuario.Add(usuario);
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
                Usuario usuarioBuscado = _context.Usuario.Find(id)!;

                if (usuarioBuscado != null)
                {
                    _context.Usuario.Remove(usuarioBuscado);
                }

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Usuario> Listar()
        {

            try
            {
                return _context.Usuario.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

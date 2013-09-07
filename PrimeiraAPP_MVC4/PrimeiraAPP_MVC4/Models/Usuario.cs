using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrimeiraAPP_MVC4.Models
{
    public class Usuario
    {
        public List<UsuarioModel> listaUsuario = new List<UsuarioModel>();

        public Usuario()
        {
            listaUsuario.Add(new UsuarioModel
                {
                    nome = "Jose Carlos",
                    sobrenome = "Macoratt",
                    endereco = "Rua Projetada , 100",
                    email = "macoratti@yahoo.com",
                    nascimento = Convert.ToDateTime("05/09/1975")
                });
            listaUsuario.Add(new UsuarioModel
            {
                nome = "Jefferson Andre",
                sobrenome = "Ribeiro",
                endereco = "Rua Mirassol , 50",
                email = "jeffbol@bol.com.br",
                nascimento = Convert.ToDateTime("13/08/1992")
            });
            listaUsuario.Add(new UsuarioModel
            {
                nome = "Janice Lima",
                sobrenome = "Morais",
                endereco = "Rua Peru , 10",
                email = "janielima@hotmail.com",
                nascimento = Convert.ToDateTime("15/07/1990")
            });
        }

        public void CriarUsuario(UsuarioModel usuarioModelo)
        {
            listaUsuario.Add(usuarioModelo);
        }

        public void AtualizaUsuario(UsuarioModel usuarioModelo)
        {
            foreach (UsuarioModel usuario in listaUsuario)
            {
                if (usuario.email==usuarioModelo.email)
                {
                    listaUsuario.Remove(usuario);
                    listaUsuario.Add(usuarioModelo);
                    break;
                }
            }
        }

        public UsuarioModel GetUsuario(string Email)
        {
            UsuarioModel _usuarioModel = null;

            foreach (UsuarioModel _usuario in listaUsuario)
            {
                if(_usuario.email==Email)
                {
                    _usuarioModel = _usuario;
                }

            }
            return _usuarioModel;
        }

        public void DeletarUsuario (string Email)
        {
            foreach (UsuarioModel _usuarioitem in listaUsuario)
            {
                if (_usuarioitem.email == Email)
                {
                    listaUsuario.Remove(_usuarioitem);
                    break;
                }
            }
	
        }


    }
}
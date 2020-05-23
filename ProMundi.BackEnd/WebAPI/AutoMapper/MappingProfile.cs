using AutoMapper;
using Domain.Entidades;
using WebAPI.ViewModels.Categoria;
using WebAPI.ViewModels.Comentario;
using WebAPI.ViewModels.Conteudo;
using WebAPI.ViewModels.Tema;
using WebAPI.ViewModels.Usuario;

namespace API.AutoMapper
    {
        public class MappingProfile : Profile
        {
            public MappingProfile()
            {
                CreateMap<Usuario, UsuarioViewModel>();
                CreateMap<Conteudo, ConteudoViewModel>();
                CreateMap<Comentario, ComentarioViewModel>();
                CreateMap<Categoria, CategoriaViewModel>();
                CreateMap<Tema, TemaViewModel>();

                CreateMap<UsuarioViewModel, Usuario>();
                CreateMap<ConteudoViewModel, Conteudo>();
                CreateMap<ComentarioViewModel, Comentario>();
                CreateMap<CategoriaViewModel, Categoria>();
                CreateMap<TemaViewModel, Tema>();

                CreateMap<UsuarioViewModelCadastro, Usuario>();
                CreateMap<ConteudoViewModelCadastro, Conteudo>();
                CreateMap<ComentarioViewModelCadastro, Comentario>();
                CreateMap<CategoriaViewModelCadastro, Categoria>();
                CreateMap<TemaViewModelCadastro, Tema>();
        }
        }
    }


using Microsoft.AspNetCore.Mvc;
using ProvaSuficiencia.Extensions;
using System;

namespace ProvaSuficiencia.Controllers
{
    [ApiController]
    public abstract class MainController : ControllerBase
    {
        public readonly IAspNetUser AppUser;
        protected Guid UsuarioId { get; set; }
        protected bool UsuarioAutenticado { get; set; }

        protected MainController(IAspNetUser appUser)
        {
            AppUser = appUser;

            if (appUser.IsAuthenticated())
            {
                UsuarioId = appUser.GetUserId();
                UsuarioAutenticado = true;
            }
        }
    }
}

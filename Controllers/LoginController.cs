using FichaOnline.Data;
using FichaOnline.Helper;
using FichaOnline.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FichaOnline.Controllers
{
    public class LoginController : Controller
    {
        public readonly DataBaseContext _db;
        public readonly UserManager<IdentityUser> _userManager;
        public readonly SignInManager<IdentityUser> _signInManager;

        public LoginController(DataBaseContext db, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _db = db;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Entrar(LoginModel ModelLogin)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    //var user = await _userManager.FindByNameAsync(ModelLogin.Login);
                    TBUsuarios usuario = _db.TBUSUARIOS.First(x => x.UsuarioCpf == ModelLogin.Login);
                    if (usuario != null)
                    {
                        //var result = await _signInManager.PasswordSignInAsync(user, ModelLogin.Senha, ModelLogin.Relembrar, false);
                        //if (result.Succeeded)
                        //{
                        if (ModelLogin.Login == usuario.UsuarioCpf && ModelLogin.Senha.GerarHash() == usuario.UsuarioSenha)
                        {
                            return RedirectToAction("Index", "Home");
                        }
                        TempData["MessageErro"] = "Senha do usuário é invalida, tente novamente.";
                        //}
                    }
                    TempData["MessageErro"] = "Usuário e/ou senha inválido(a). Tente novamente.";
                }
                return RedirectToAction("Index", "Login");
            }
            catch (Exception error)
            {
                TempData["MessageErro"] = $"Ops, não conseguimos realizar o login, tente novamente? detalhe do erro? {error.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}

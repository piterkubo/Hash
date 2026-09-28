using Hash.Models;
using Hash.Helper;
using Microsoft.AspNetCore.Mvc;

namespace Hash.Controllers
{
    public class ConverterSenhaController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }


        [HttpPost]
        public IActionResult Converter(string senha)
        {
            HashViewModel hash = new HashViewModel();                       
       
            if (senha != null)
            {
                hash.SetNovaSenha(senha);

                hash.senhaConvertida = hash.senha;

                TempData["MensagemSucesso"] = "Senha Convertida Com Sucesso !!!! " + "(" + hash.senhaConvertida + ");";


            }

            else
            {
                TempData["MensagemError"] = "Error!";

            }



                return View("Index");
        }



    }
}

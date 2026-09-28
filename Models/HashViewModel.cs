using Hash.Helper;

namespace Hash.Models
{
    public class HashViewModel
    {
        public string senha { get; set; }

        public string? senhaConvertida {  get; set; }

        public string? senhaRegredida { get; set; }




        public bool SenhaValida(string senha)
        {
            return senha == senha.GerarHash();
        }





        public void SetSenhaHash()
        {
            senha = senha.GerarHash();            
            
        }





        public void SetNovaSenha(string novaSenha)
        {
            senha = novaSenha.GerarHash();           

        }



        public string GerarNovaSenha()
        {
            string novaSenha = Guid.NewGuid().ToString().Substring(0, 8);

            senha = novaSenha.GerarHash();            
            return novaSenha;

        }
    }
}

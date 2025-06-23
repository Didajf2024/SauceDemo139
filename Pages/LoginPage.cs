// Biblioteca

// Namespace
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V127.Browser;

namespace Pages
{
    // Classe 
    public class LoginPage : CommonPage
    {
        // Atributos
        // Mapeamento dos Elementos 
        private IWebElement txtUsuario => driver.FindElement(By.Id("user-name"));
        private IWebElement txtSenha => driver.FindElement(By.Id("password"));
        private IWebElement btnlogin => driver.FindElement(By.Id("login-button"));
        // Métodos e Funções
        // Construtor
        public LoginPage(IWebDriver driver) : base(driver) { }
        // Ações a serem usadas na automação
        public void PreencherUsuarioESenha(String usuario, String senha)
        {
            txtUsuario.SendKeys(usuario);
            txtSenha.SendKeys(senha);
        }

        public void ClicarNoBotaoLogin()
        {
            btnlogin.Click();
        }

        public void DarEnter()
        {
            txtSenha.SendKeys(Keys.Enter);
        }
    }
}
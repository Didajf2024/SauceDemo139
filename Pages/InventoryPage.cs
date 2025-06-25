
using OpenQA.Selenium;

namespace Pages
{
    public class InventoryPage : CommonPage
    {
        // Mapeamento dos Elementos
        // Como queremos mapear o botao "Add to Cart" e o id muda pro produto
        // Iremos mapear de forma dinamica pelo bloco de ações
        // Construtor
        public InventoryPage(IWebDriver driver) : base(driver) { }
        // Ações
        public void AdicionarAoCarrinho(String produto)
        {
            String seletorProduto = "add-to-cart-" + produto.ToLower().Replace("", "-");
            driver.FindElement(By.Id(seletorProduto)).Click();
        }
    }
}
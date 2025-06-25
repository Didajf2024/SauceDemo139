namespace MyNamespace
{
    public class SelectProductPO
    {
         [Given(@"que acesso a página inicial do site PO")]
         public void DadoQueAcessoAPaginaInicialDoSitePO()
         {
             _scenarioContext.Pending();
         }

         [When(@"preencho o usuário como ""(.*)"" PO")]
         public void QuandoPreenchoOUsuarioComoPO(string p0)
         {
             _scenarioContext.Pending();
         }

         [When(@"a senha ""(.*)"" e clico no botao Login PO")]
         public void QuandoASenhaEClicoNoBotaoLoginPO(string p0)
         {
             _scenarioContext.Pending();
         }

         [Then(@"exibe ""(.*)"" no titulo da secao PO")]
         public void EntaoExibeNoTituloDaSecaoPO(string products0)
         {
             _scenarioContext.Pending();
         }

         [When(@"adiciono o produto ""(.*)"" ao carrinho PO")]
         public void QuandoAdicionoOProdutoAoCarrinhoPO(string p0)
         {
             _scenarioContext.Pending();
         }

         [When(@"clico no icone do carrinho de compras PO")]
         public void QuandoClicoNoIconeDoCarrinhoDeComprasPO()
         {
             _scenarioContext.Pending();
         }

         [Then(@"exibe a pagina do carrinho com a quantidade ""(.*)"" PO")]
         public void EntaoExibeAPaginaDoCarrinhoComAQuantidadePO(string p0)
         {
             _scenarioContext.Pending();
         }

         [Then(@"nome do produto ""(.*)"" PO")]
         public void EntaoNomeDoProdutoPO(string p0)
         {
             _scenarioContext.Pending();
         }

         [Then(@"o preco como ""(.*)"" PO")]
         public void EntaoOPrecoComoPO(string p0)
         {
             _scenarioContext.Pending();
         }
    }
}
﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SauceDemo139.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Selecionar Produto na Loja PO")]
    public partial class SelecionarProdutoNaLojaPOFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "selectProductPO.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt"), "Features", "Selecionar Produto na Loja PO", null, ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Selecao de Produto com Sucesso PO")]
        [NUnit.Framework.CategoryAttribute("PO")]
        [NUnit.Framework.TestCaseAttribute("\"standard_user\"", "\"secret_sauce\"", "\"Products\"", "\"Sauce Labs Backpack\"", "\"1\"", "\"$29.99\"", null)]
        [NUnit.Framework.TestCaseAttribute("\"visual_user\"", "\"secret_sauce\"", "\"Products\"", "\"Sauce Labs Bike Light\"", "\"1\"", "\"$9.99\"", null)]
        public void SelecaoDeProdutoComSucessoPO(string usuario, string senha, string tituloSecao, string produto, string quantidade, string preco, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "PO"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("usuario", usuario);
            argumentsOfScenario.Add("senha", senha);
            argumentsOfScenario.Add("tituloSecao", tituloSecao);
            argumentsOfScenario.Add("produto", produto);
            argumentsOfScenario.Add("quantidade", quantidade);
            argumentsOfScenario.Add("preco", preco);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Selecao de Produto com Sucesso PO", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 4
    this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 5
        testRunner.Given("que acesso a página inicial do site PO", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line hidden
#line 6
        testRunner.When(string.Format("preencho o usuário como {0} PO", usuario), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line hidden
#line 7
        testRunner.And(string.Format("a senha {0} e clico no botao Login PO", senha), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
#line 8
        testRunner.Then(string.Format("exibe {0} no titulo da secao PO", tituloSecao), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
#line 9
        testRunner.When(string.Format("adiciono o produto {0} ao carrinho PO", produto), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line hidden
#line 10
        testRunner.And("clico no icone do carrinho de compras PO", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
#line 11
        testRunner.Then(string.Format("exibe a pagina do carrinho com a quantidade {0} PO", quantidade), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
#line 12
        testRunner.And(string.Format("nome do produto {0} PO", produto), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
#line 13
        testRunner.And(string.Format("o preco como {0} PO", preco), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

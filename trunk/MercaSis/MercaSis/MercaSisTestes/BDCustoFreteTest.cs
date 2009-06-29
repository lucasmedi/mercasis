using Microsoft.VisualStudio.TestTools.UnitTesting;
using MercaSisBDs;
using MercaSisTOs;

namespace MercaSisTestes
{
    
    
    /// <summary>
    ///This is a test class for BDCustoFreteTest and is intended
    ///to contain all BDCustoFreteTest Unit Tests
    ///</summary>
    [TestClass()]
    public class BDCustoFreteTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for InserirCustoFrete
        ///</summary>
        [TestMethod()]
        public void InserirCustoFreteTest()
        {
            BDCustoFrete target = new BDCustoFrete();
            TOCustoFrete cfr = new TOCustoFrete();
            cfr.Custo.Valor = (float)15; 
            target.InserirCustoFrete(cfr);
            Assert.IsNotNull(cfr.Custo.Valor);
        }

        /// <summary>
        ///A test for AlterarCustoFrete
        ///</summary>
        [TestMethod()]
        public void AlterarCustoFreteTest()
        {
            BDCustoFrete target = new BDCustoFrete();
            TOCustoFrete cfr = new TOCustoFrete();
            cfr.Codigo.Valor = 1;
            cfr.Custo.Valor = 10;
            target.AlterarCustoFrete(cfr);
            Assert.IsNotNull(cfr.Custo.Valor);
        }

        /// <summary>
        ///A test for ExcluirCustoFrete
        ///</summary>
        [TestMethod()]
        public void ExcluirCustoFreteTest()
        {
            BDCustoFrete target = new BDCustoFrete();
            TOCustoFrete cfr = new TOCustoFrete();
            cfr.Codigo.Valor = 1;
            target.ExcluirCustoFrete(cfr);
            Assert.IsNotNull(cfr.Codigo.Valor);            
        }        
    }
}

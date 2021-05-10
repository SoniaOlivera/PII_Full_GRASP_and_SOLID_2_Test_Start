using NUnit.Framework;
using Full_GRASP_And_SOLID.Library;

namespace Library.Test
{
    public class ConsolePrinterTests
    {
        private Recipe recipe;
        private ConsolePrinter console;
        [SetUp]
        public void Setup()
        {
            ConsolePrinter console = new ConsolePrinter();
            Recipe recipe = new Recipe();
        }

        [Test]

        public void Test1()
        {
            Assert.Pass();
        }
        [Test]

        public void TestImprimirunasolalinea()
        {
            //recipe.linea = "Hola";
           // string receta = console.PrintRecipe(recipe);
            //Assert.AreEqual("Hola", receta);
        }
    }
}
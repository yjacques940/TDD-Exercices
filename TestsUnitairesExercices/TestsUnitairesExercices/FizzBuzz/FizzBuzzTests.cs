using NUnit.Framework;

namespace TestsUnitairesExercices.FizzBuzz
{
	[TestFixture]
	public class FizzBuzzTests
	{
		[Test]
		public void RepondreFizzMultipleDeTroisValide()
		{
			var calculateurReponse = new CalculateurReponse();
			var reponse = calculateurReponse.ObtenirReponse(6);
			Assert.AreEqual("Fizz", reponse);
		}

		[Test]
		public void RepondreBuzzMultipleDeCinqValide()
		{
			var calculateurReponse = new CalculateurReponse();
			var reponse = calculateurReponse.ObtenirReponse(10);
			Assert.AreEqual("Buzz", reponse);
		}

		[Test]
		public void RepondreChiffreOrigine()
		{
			var calculateurReponse = new CalculateurReponse();
			var reponse = calculateurReponse.ObtenirReponse(7);
			Assert.AreEqual("7", reponse);
		}

		[Test]
		public void RepondreFizzBuzzSiMultipleDeTroisEtCinq()
		{
			var calculateurReponse = new CalculateurReponse();
			var reponse = calculateurReponse.ObtenirReponse(30);
			Assert.AreEqual("FizzBuzz", reponse);
		}

		[Test]
		public void WhenHasMaximumNumber_ShouldHaveSameQuantityOfRecordsInList()
		{
			var calculateurReponse = new CalculateurReponse();
			var valeurMaximum = 15;

			var list = calculateurReponse.ObtenirListe(valeurMaximum);

			Assert.AreEqual(valeurMaximum, list.Count);
		}
	}
}

using NUnit.Framework;

namespace TestsUnitairesExercices
{
	[TestFixture]
	class SayHelloTests
	{
		[Test]
		public void SayBonsoirBefore7H()
		{
			var textGenerator = new TextGenerator();
			var salutation = textGenerator.SayHello(6);
			Assert.AreEqual("Bonsoir", salutation);
		}

		[Test]
		public void SayBonjourAfter7H()
		{
			var textGenerator = new TextGenerator();
			var salutation = textGenerator.SayHello(8);
			Assert.AreEqual("Bonjour", salutation);
		}

		[Test]
		public void SayBonjourAt7H()
		{
			var textGenerator = new TextGenerator();
			var salutation = textGenerator.SayHello(7);
			Assert.AreEqual("Bonjour", salutation);
		}

		[Test]
		public void SayBonsoirAfter18H()
		{
			var textGenerator = new TextGenerator();
			var salutation = textGenerator.SayHello(19);
			Assert.AreEqual("Bonsoir", salutation);
		}

		[Test]
		public void SayBonsoirBefore6H()
		{
			var textGenerator = new TextGenerator();
			var salutation = textGenerator.SayHello(4);
			Assert.AreEqual("Bonsoir", salutation);
		}
	}
}

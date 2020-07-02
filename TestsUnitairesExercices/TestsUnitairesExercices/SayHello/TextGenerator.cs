namespace TestsUnitairesExercices
{
	public class TextGenerator
	{
		public string SayHello(int hour)
		{
			if (hour >= 18)
				return "Bonsoir";
			if (hour <= 6)
				return "Bonsoir";
			if (hour >= 7)
				return "Bonjour";
			if (hour <= 17)
				return "Bonjour";
			return "Bonjour";
		}
	}
}

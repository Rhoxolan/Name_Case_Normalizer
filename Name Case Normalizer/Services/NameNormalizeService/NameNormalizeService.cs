using System.Text.RegularExpressions;

namespace Name_Case_Normalizer.Services.NameNormalizeService
{
	public partial class NameNormalizeService : INameNormalizeService
	{
		private readonly string[] prefixes = { "ант", "ant", "бар", "bar", "бель",
			"bel", "бер", "ber", "блан", "blan", "бон", "bon", "вер", "ver", "виль",
			"vil", "гий", "gi", "де", "de", "дел", "del", "дер", "der", "дю", "du",
			"зю", "zu", "ко", "co", "ла", "la", "ле", "le", "лес", "les", "мак",
			"mac", "макк", "mack", "сен", "sen", "сент", "sent", "шарль", "charl",
			"этьен", "etien", "юбер", "uber", "юри", "uri", "юст", "ust", "фон",
			"von", "фондер", "fonder", "фондерс", "fonders", "фондерсс", "fonderss",
			"штайн", "shtain", "штейн", "shteyn", "штейнер", "shteyner", "фрид",
			"frit", "фридрих", "fritrikh", "фридрихс", "fritrikhs", "фридрихсс",
			"fritrikhss", "гер", "ger", "герц", "gerts", "герцог", "gertsog",
			"герцогс", "gertsogs", "франц", "frants", "францис", "frantsis",
			"францисс", "frantsiss", "хайнц", "khaynts", "хайнце", "khayntse",
			"хайнцес", "khayntsess", "хайнцесс", "khayntsess", "карл", "karl",
			"карле", "karle", "карлес", "karles", "карлесс", "karless", "ханс",
			"khanz", "хансе", "khanze", "хансес", "khanses", "хансесс", "khansess" };

		[GeneratedRegex("([-'.’( ),])|\\s")]
		private static partial Regex SeparatorSplitRegex();

		public string Normalize(string value)
		{
			string[] parts = SeparatorSplitRegex().Split(value.ToLower());
			for (int i = 0; i < parts.Length; i++)
			{
				if (i == 0 || !prefixes.Contains(parts[i]))
				{
					parts[i] = Normalizer(parts[i]);
				}
			}
			return string.Concat(parts);
		}

		private string Normalizer(string value)
		{
			if (!string.IsNullOrEmpty(value))
			{
				char[] chars = value.ToCharArray();
				chars[0] = char.ToUpper(chars[0]);
				return new string(chars);
			}
			return value;
		}
	}
}

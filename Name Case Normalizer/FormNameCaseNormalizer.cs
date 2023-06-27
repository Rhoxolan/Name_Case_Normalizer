using Name_Case_Normalizer.Services.NameNormalizeService;

namespace Name_Case_Normalizer
{
	public partial class FormNameCaseNormalizer : Form
	{
		private readonly char[] allowedChars = { '-', ' ', '.', '\'', '’', ',', '(', ')' };
		private readonly INameNormalizeService _nameNormalizeService;

		public FormNameCaseNormalizer(INameNormalizeService nameNormalizeService)
		{
			InitializeComponent();
			_nameNormalizeService = nameNormalizeService;
		}

		private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsNumber(e.KeyChar) || char.IsDigit(e.KeyChar) ||
				(!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !allowedChars.Contains(e.KeyChar)))
			{
				e.Handled = true;
			}
		}

		private void buttonPush_Click(object sender, EventArgs e)
		{
			textBoxNormalizedName.Text = _nameNormalizeService.Normalize(textBoxName.Text);
		}
	}
}
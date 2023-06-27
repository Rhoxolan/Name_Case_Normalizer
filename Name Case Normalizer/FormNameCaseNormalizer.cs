using Name_Case_Normalizer.Services.NameNormalizeService;

namespace Name_Case_Normalizer
{
	public partial class FormNameCaseNormalizer : Form
	{
		private readonly INameNormalizeService _nameNormalizeService;

		public FormNameCaseNormalizer(INameNormalizeService nameNormalizeService)
		{
			InitializeComponent();
			_nameNormalizeService = nameNormalizeService;
		}

		private void buttonPush_Click(object sender, EventArgs e)
		{
			MessageBox.Show(_nameNormalizeService.Normalize(""));
		}
	}
}
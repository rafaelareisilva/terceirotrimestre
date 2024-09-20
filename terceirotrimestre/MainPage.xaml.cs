namespace terceirotrimestre;

public partial class MainPage : ContentPage
{
	 Gerenciador Gerenciador;
	int count = 0;

	public MainPage()
	{
		InitializeComponent();

		Gerenciador=new Gerenciador(labelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		
	}
}


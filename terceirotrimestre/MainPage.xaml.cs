namespace terceirotrimestre;

public partial class MainPage : ContentPage
{
	 Gerenciador Gerenciador;
	int count = 0;

	public MainPage()
	{
		InitializeComponent();

		Gerenciador=new Gerenciador(labelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5, Pontuacao, Nivel);
	}
	 void ButtonResposta01(object sender, EventArgs args)
	{
		Gerenciador.VerificaCorreta(1);
	}
	void ButtonResposta02(object sender, EventArgs args)
	{
		Gerenciador.VerificaCorreta(2);
	}
	void ButtonResposta03(object sender, EventArgs args)
	{
		Gerenciador.VerificaCorreta(3);
	}
	void ButtonResposta04(object sender, EventArgs args)
	{
		Gerenciador.VerificaCorreta(4);
	}
	void ButtonResposta05(object sender, EventArgs args)
	{
		Gerenciador.VerificaCorreta(5);
	}
	 private void ButtonVoltarButtonClicked(object sender, EventArgs args)
        {

            Application.Current.MainPage = new Telainicial();

        }
	void OnAjudaRetirarClicked (object s, EventArgs e)
	{
		var ajuda = new RetiraErrada();
		ajuda.ConfiguraDesenho(ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5 );
		ajuda.RealizaAjuda(Gerenciador.GetQuestaoCorrente());
		(s as Button).IsVisible=false;
	}

	void OnAjudaPulaClicked (object s, EventArgs e)
	{
		Gerenciador.ProximaQuestao();
		(s as Button).IsVisible=false;
	}
}


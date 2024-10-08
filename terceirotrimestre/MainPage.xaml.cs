﻿namespace terceirotrimestre;

public partial class MainPage : ContentPage
{
	 Gerenciador Gerenciador;

	 private int Clickcount;
	 private int Clickedpular;
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
		Clickcount++;
		Clickedpular++;
		if (Clickcount >=3)
		{
			(s as Button).IsVisible=false;
		}
		else
		{
			(s as Button).IsVisible=true;
		}

	   if (Clickedpular==1)
	   {
		 pular3x.Text="PULAR 2x";
	   }
	   else if (Clickedpular==2)
       {
		 pular3x.Text="PULAR 1x";
	   }
	   else if (Clickedpular>=3)
	   {
		(s as Button).IsVisible=false;
	   }
	}
	 
	

	void OnAjudaUniversitariosClicked (object s, EventArgs e)
	{
		var ajuda = new Universitarios();
		ajuda.ConfiguraDesenho(ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5 );
		ajuda.RealizaAjuda(Gerenciador.GetQuestaoCorrente());
		(s as Button).IsVisible=false;
	}
}


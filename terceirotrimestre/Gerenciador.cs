using System.Security.Cryptography.X509Certificates;
using terceirotrimestre;

public class Gerenciador 
{
    List<Questao> ListaQuestoes=new List<Questao>();
    List<int> ListaQuestoesRespondidas=new List<int>();
    Questao QuestaoCorrente;
    public Gerenciador (Label labelPerg, Button btnResp01, Button btnResp02, Button btnResp03, Button btnResp04, Button btnResp05)
    {
        CriaPerguntas(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
    }

    void CriaPerguntas(Label labelPerg, Button  btnResp01,Button  btnResp02,Button  btnResp03,Button  btnResp04,Button  btnResp05)
    {
        var Q1= new Questao();
        Q1.ConfiguraDesenho (labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
        Q1.Pergunta="Qual país tem formato de uma bota?";
        Q1.Resposta01="Brasil";
        Q1.Resposta02="Itália";
        Q1.Resposta03="Japão";
        Q1.Resposta04="Russia";
        Q1.Resposta05="Africa";
        Q1.RespostaCorreta=2;
        ListaQuestoes.Add (Q1);
        ProximaQuestao();
    }
    
        public async void VerificaCorreta(int RR)
        {
            if (QuestaoCorrente.VerificaResposta (RR))
            {
                await Task.Delay(1000);
                ProximaQuestao();
            }
        }

       void ProximaQuestao()
       {
        var numAleat= Random.Shared.Next(0, ListaQuestoes.Count);
        while (ListaQuestoesRespondidas.Contains(numAleat))
         numAleat=Random.Shared.Next(0, ListaQuestoes.Count);
         ListaQuestoesRespondidas.Add(numAleat);
         QuestaoCorrente=ListaQuestoes[numAleat];
         QuestaoCorrente.Desenhar();    
       }
    }

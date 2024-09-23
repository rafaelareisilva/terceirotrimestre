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
        
var Q1 = new Questao();
Q1.ConfiguraDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q1.Pergunta = "Qual país tem formato de uma bota?";
Q1.Resposta1 = "Brasil";
Q1.Resposta2 = "Itália";
Q1.Resposta3 = "Japão";
Q1.Resposta4 = "Rússia";
Q1.Resposta5 = "África";
Q1.Respostacorreta = 2;
ListaQuestoes.Add(Q1);

 
var Q2 = new Questao();
Q2.ConfiguraDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q2.Pergunta = "Qual é o maior oceano do mundo?";
Q2.Resposta1 = "Atlântico";
Q2.Resposta2 = "Índico";
Q2.Resposta3 = "Pacífico";
Q2.Resposta4 = "Ártico";
Q2.Resposta5 = "Antártico";
Q2.Respostacorreta = 3;
ListaQuestoes.Add(Q2);

 
var Q3 = new Questao();
Q3.ConfiguraDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q3.Pergunta = "Quem pintou a Mona Lisa?";
Q3.Resposta1 = "Michelangelo";
Q3.Resposta2 = "Vincent van Gogh";
Q3.Resposta3 = "Pablo Picasso";
Q3.Resposta4 = "Leonardo da Vinci";
Q3.Resposta5 = "Salvador Dalí";
Q3.Respostacorreta = 4;
ListaQuestoes.Add(Q3);

 
var Q4 = new Questao();
Q4.ConfiguraDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q4.Pergunta = "Qual é o planeta mais próximo do Sol?";
Q4.Resposta1 = "Terra";
Q4.Resposta2 = "Vênus";
Q4.Resposta3 = "Mercúrio";
Q4.Resposta4 = "Júpiter";
Q4.Resposta5 = "Marte";
Q4.Respostacorreta = 3;
ListaQuestoes.Add(Q4);

 
var Q5 = new Questao();
Q5.ConfiguraDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q5.Pergunta = "Quantos continentes existem na Terra?";
Q5.Resposta1 = "4";
Q5.Resposta2 = "5";
Q5.Resposta3 = "6";
Q5.Resposta4 = "7";
Q5.Resposta5 = "8";
Q5.Respostacorreta = 4;
ListaQuestoes.Add(Q5);

 
var Q6 = new Questao();
Q6.ConfiguraDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q6.Pergunta = "Em qual país se localiza a Torre Eiffel?";
Q6.Resposta1 = "Itália";
Q6.Resposta2 = "Alemanha";
Q6.Resposta3 = "França";
Q6.Resposta4 = "Espanha";
Q6.Resposta5 = "Suíça";
Q6.Respostacorreta = 3;
ListaQuestoes.Add(Q6);

 
var Q7 = new Questao();
Q7.ConfiguraDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q7.Pergunta = "Quem escreveu 'Dom Quixote'?";
Q7.Resposta1 = "William Shakespeare";
Q7.Resposta2 = "Miguel de Cervantes";
Q7.Resposta3 = "Gabriel García Márquez";
Q7.Resposta4 = "Machado de Assis";
Q7.Resposta5 = "Jorge Amado";
Q7.Respostacorreta = 2;
ListaQuestoes.Add(Q7);

 
var Q8 = new Questao();
Q8.ConfiguraDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q8.Pergunta = "Qual elemento químico é representado pela letra 'O'?";
Q8.Resposta1 = "Ouro";
Q8.Resposta2 = "Oxigênio";
Q8.Resposta3 = "Ósmio";
Q8.Resposta4 = "Prata";
Q8.Resposta5 = "Hidrogênio";
Q8.Respostacorreta = 2;
ListaQuestoes.Add(Q8);

 
var Q9 = new Questao();
Q9.ConfiguraDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q9.Pergunta = "Qual animal é conhecido por mudar de cor?";
Q9.Resposta1 = "Elefante";
Q9.Resposta2 = "Golfinho";
Q9.Resposta3 = "Leão";
Q9.Resposta4 = "Camaleão";
Q9.Resposta5 = "Pinguim";
Q9.Respostacorreta = 4;
ListaQuestoes.Add(Q9);
 
var Q10 = new Questao();
Q10.ConfiguraDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q10.Pergunta = "Quantos segundos tem um minuto?";
Q10.Resposta1 = "50";
Q10.Resposta2 = "60";
Q10.Resposta3 = "70";
Q10.Resposta4 = "80";
Q10.Resposta5 = "90";
Q10.Respostacorreta = 2;
ListaQuestoes.Add(Q10);


var Q11 = new Questao();
Q11.ConfiguraDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q11.Pergunta = "Qual é o maior país em extensão territorial?";
Q11.Resposta1 = "China";
Q11.Resposta2 = "Estados Unidos";
Q11.Resposta3 = "Rússia";
Q11.Resposta4 = "Canadá";
Q11.Resposta5 = "Brasil";
Q11.Respostacorreta = 3;
ListaQuestoes.Add(Q11);


var Q12 = new Questao();
Q12.ConfiguraDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q12.Pergunta = "Quantos ossos tem o corpo humano adulto?";
Q12.Resposta1 = "206";
Q12.Resposta2 = "198";
Q12.Resposta3 = "213";
Q12.Resposta4 = "205";
Q12.Resposta5 = "208";
Q12.Respostacorreta = 1;
ListaQuestoes.Add(Q12);


var Q13 = new Questao();
Q13.ConfiguraDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q13.Pergunta = "Qual o nome do rio que atravessa o Egito?";
Q13.Resposta1 = "Rio Nilo";
Q13.Resposta2 = "Rio Amazonas";
Q13.Resposta3 = "Rio Ganges";
Q13.Resposta4 = "Rio Danúbio";
Q13.Resposta5 = "Rio Tigre";
Q13.Respostacorreta = 1;
ListaQuestoes.Add(Q13);


var Q14 = new Questao();
Q14.ConfiguraDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q14.Pergunta = "Qual é o país mais populoso do mundo?";
Q14.Resposta1 = "Índia";
Q14.Resposta2 = "Estados Unidos";
Q14.Resposta3 = "Rússia";
Q14.Resposta4 = "Brasil";
Q14.Resposta5 = "China";
Q14.Respostacorreta = 5;
ListaQuestoes.Add(Q14);


var Q15 = new Questao();
Q15.ConfiguraDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q15.Pergunta = "Quem foi o primeiro presidente do Brasil?";
Q15.Resposta1 = "Dom Pedro I";
Q15.Resposta2 = "Getúlio Vargas";
Q15.Resposta3 = "Deodoro da Fonseca";
Q15.Resposta4 = "Juscelino Kubitschek";
Q15.Resposta5 = "Floriano Peixoto";
Q15.Respostacorreta = 3;
ListaQuestoes.Add(Q15);


var Q16 = new Questao();
Q16.ConfiguraDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q16.Pergunta = "Qual é a moeda oficial do Japão?";
Q16.Resposta1 = "Dólar";
Q16.Resposta2 = "Euro";
Q16.Resposta3 = "Yuan";
Q16.Resposta4 = "Iene";
Q16.Resposta5 = "Libra";
Q16.Respostacorreta = 4;
ListaQuestoes.Add(Q16);


var Q17 = new Questao();
Q17.ConfiguraDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q17.Pergunta = "Quem foi o responsável pela teoria da relatividade?";
Q17.Resposta1 = "Isaac Newton";
Q17.Resposta2 = "Albert Einstein";
Q17.Resposta3 = "Nikola Tesla";
Q17.Resposta4 = "Galileu Galilei";
Q17.Resposta5 = "Stephen Hawking";
Q17.Respostacorreta = 2;
ListaQuestoes.Add(Q17);


var Q18 = new Questao();
Q18.ConfiguraDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q18.Pergunta = "Qual elemento tem o símbolo químico 'Fe'?";
Q18.Resposta1 = "Fósforo";
Q18.Resposta2 = "Flúor";
Q18.Resposta3 = "Ferro";
Q18.Resposta4 = "Frâncio";
Q18.Resposta5 = "Fermium";
Q18.Respostacorreta = 3;
ListaQuestoes.Add(Q18);


var Q19 = new Questao();
Q19.ConfiguraDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q19.Pergunta = "Qual país sediou os Jogos Olímpicos de 2016?";
Q19.Resposta1 = "Japão";
Q19.Resposta2 = "Brasil";
Q19.Resposta3 = "China";
Q19.Resposta4 = "Estados Unidos";
Q19.Resposta5 = "Rússia";
Q19.Respostacorreta = 2;
ListaQuestoes.Add(Q19);


var Q20 = new Questao();
Q20.ConfiguraDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q20.Pergunta = "Quem é conhecido como o 'pai da aviação'?";
Q20.Resposta1 = "Irmãos Wright";
Q20.Resposta2 = "Alberto Santos-Dumont";
Q20.Resposta3 = "Leonardo da Vinci";
Q20.Resposta4 = "Henry Ford";
Q20.Resposta5 = "Charles Lindbergh";
Q20.Respostacorreta = 2;
ListaQuestoes.Add(Q20);


var Q21 = new Questao();
Q21.ConfiguraDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q21.Pergunta = "Quantos vértices tem um cubo?";
Q21.Resposta1 = "6";
Q21.Resposta2 = "8";
Q21.Resposta3 = "12";
Q21.Resposta4 = "4";
Q21.Resposta5 = "10";
Q21.Respostacorreta = 2;
ListaQuestoes.Add(Q21);


var Q22 = new Questao();
Q22.ConfiguraDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q22.Pergunta = "Qual é a distância aproximada da Terra ao Sol?";
Q22.Resposta1 = "150 milhões de km";
Q22.Resposta2 = "93 milhões de km";
Q22.Resposta3 = "120 milhões de km";
Q22.Resposta4 = "200 milhões de km";
Q22.Resposta5 = "250 milhões de km";
Q22.Respostacorreta = 1;
ListaQuestoes.Add(Q22);

var Q23 = new Questao();
Q23.ConfiguraDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q23.Pergunta = "Qual foi o primeiro homem a pisar na Lua?";
Q23.Resposta1 = "Buzz Aldrin";
Q23.Resposta2 = "Yuri Gagarin";
Q23.Resposta3 = "Neil Armstrong";
Q23.Resposta4 = "John Glenn";
Q23.Resposta5 = "Michael Collins";
Q23.Respostacorreta = 3;
ListaQuestoes.Add(Q23);


var Q24 = new Questao();
Q24.ConfiguraDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q24.Pergunta = "Qual é o maior deserto do mundo?";
Q24.Resposta1 = "Saara";
Q24.Resposta2 = "Kalahari";
Q24.Resposta3 = "Atacama";
Q24.Resposta4 = "Deserto do Gobi";
Q24.Resposta5 = "Antártida";
Q24.Respostacorreta = 5;
ListaQuestoes.Add(Q24);


var Q25 = new Questao();
Q25.ConfiguraDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q25.Pergunta = "Qual é o metal mais abundante na Terra?";
Q25.Resposta1 = "Ferro";
Q25.Resposta2 = "Alumínio";
Q25.Resposta3 = "Cálcio";
Q25.Resposta4 = "Silício";
Q25.Resposta5 = "Zinco";
Q25.Respostacorreta = 2;
ListaQuestoes.Add(Q25);


var Q26 = new Questao();
Q26.ConfiguraDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q26.Pergunta = "Qual foi a primeira capital do Brasil?";
Q26.Resposta1 = "Rio de Janeiro";
Q26.Resposta2 = "São Paulo";
Q26.Resposta3 = "Brasília";
Q26.Resposta4 = "Salvador";
Q26.Resposta5 = "Pernambuco";
Q26.Respostacorreta = 4;
ListaQuestoes.Add(Q26);


var Q27 = new Questao();
Q27.ConfiguraDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q27.Pergunta = "Qual é o maior órgão do corpo humano?";
Q27.Resposta1 = "Coração";
Q27.Resposta2 = "Fígado";
Q27.Resposta3 = "Pulmão";
Q27.Resposta4 = "Pele";
Q27.Resposta5 = "Intestino";
Q27.Respostacorreta = 4;
ListaQuestoes.Add(Q27);


var Q28 = new Questao();
Q28.ConfiguraDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q28.Pergunta = "Qual é a principal função das hemácias no sangue?";
Q28.Resposta1 = "Combater infecções";
Q28.Resposta2 = "Transportar oxigênio";
Q28.Resposta3 = "Coagular o sangue";
Q28.Resposta4 = "Regular a temperatura";
Q28.Resposta5 = "Produzir anticorpos";
Q28.Respostacorreta = 2;
ListaQuestoes.Add(Q28);


var Q29 = new Questao();
Q29.ConfiguraDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q29.Pergunta = "Quem foi o responsável pela teoria da evolução?";
Q29.Resposta1 = "Charles Darwin";
Q29.Resposta2 = "Sigmund Freud";
Q29.Resposta3 = "Gregor Mendel";
Q29.Resposta4 = "Louis Pasteur";
Q29.Resposta5 = "Marie Curie";
Q29.Respostacorreta = 1;
ListaQuestoes.Add(Q29);


var Q30 = new Questao();
Q30.ConfiguraDesenho(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q30.Pergunta = "Qual país é o maior produtor de café do mundo?";
Q30.Resposta1 = "Colômbia";
Q30.Resposta2 = "Etiópia";
Q30.Resposta3 = "Vietnã";
Q30.Resposta4 = "Brasil";
Q30.Resposta5 = "Peru";
Q30.Respostacorreta = 4;
ListaQuestoes.Add(Q30);


ProximaQuestao();

    }
    
        public async void VerificaCorreta(int RR)
        {
            if (QuestaoCorrente.VerificaResposta (RR))
            {
                await Task.Delay(1000);
                AdicionaPontuacao(NivelAtual);
                NivelAtual++;
                ProximaQuestao();
            }
            else
            {
               await App.Current.MainPage.DisplayAlert("fim", "Você Errou", "Ok");
               Inicializar();  
                  
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

       public int Pontuacao { get; private set; }
       int NivelAtual=0;
       void Inicializar()
       {
        Pontuacao=0;
        NivelAtual=1;
        ProximaQuestao();
       }

    void AdicionaPontuacao(int n)
    {
      if (n==1)
      Pontuacao=1000;

      else if (n==2)
      Pontuacao=2000;

      else if (n==3)
      Pontuacao=5000;

      else if (n==4)
      Pontuacao=10000;

      else if (n==5)
      Pontuacao=20000;

      else if (n==6)
      Pontuacao=50000;

      else if (n==7)
      Pontuacao=100000;

      else if (n==8)
      Pontuacao=200000;

      else if (n==9)
      Pontuacao=500000;

      else 
      Pontuacao=1000000;
      
    }

      
    }

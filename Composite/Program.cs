using Composite.Model;

var grupoA = new Grupo("A) Português");
var questao1 = new Questao("Quando usamos a crase?");
var questao2 = new Questao("Quando usamos virgula?");

grupoA.Add(questao1);
grupoA.Add(questao2);

var grupoB = new Grupo("B) Física");
var grupoB1 = new Grupo("B1) Mecanica");
var questao3 = new Questao("O que é velocidade média?");
var questao4 = new Questao("O que é aceleração?");

grupoB1.Add(questao3);
grupoB1.Add(questao4);

var grupoB2 = new Grupo("B2) Ótica");
var questao5 = new Questao("O que é refração?");
var questao6 = new Questao("Qual a velocidade da luz?");

grupoB2.Add(questao5);
grupoB2.Add(questao6);

grupoB.Add(grupoB1);
grupoB.Add(grupoB2);

var grupoRaiz = new Grupo("Questionário");
grupoRaiz.Add(grupoA);
grupoRaiz.Add(grupoB);

grupoRaiz.Exibir();
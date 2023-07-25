using Aula12Classes;


Personagem guerreiro = new Personagem();
guerreiro.nome = "Luz";
guerreiro.raça = "humano";
guerreiro.poder = 1000;

guerreiro.mostra();
Console.ReadKey();


Personagem mago = new Personagem();
mago.nome = "Dark";
mago.raça = "Monge";
mago.poder = 1200;

mago.mostra();
Console.ReadKey();


Personagem bruxo = mago;
bruxo.nome = "Hermione";

bruxo.mostra();
Console.ReadKey();


Personagem Bardo = new Personagem();
Bardo.nome = "Bethoven";
Bardo.raça = "Alien";
Bardo.poder = 1770;

Bardo.mostra();
Console.ReadKey();

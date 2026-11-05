// string nome = "Samuel";

using ClassesObjetos;

Produto p1 = new Produto(); // Instanciando um objeto da classe Produto

p1.Nome = "Notebook";
p1.Preco = 3500m;

p1.Exibir();

Produto p2 = new Produto();
p2.Nome = "Mouse";
p2.Preco = 100m;

p2.Exibir();

Conta conta_corrente = new Conta();
Conta conta_poupanca = new Conta();
conta_corrente.Depositar(100);
conta_poupanca.Depositar(50);

Console.WriteLine(Math.Round(10.563, 2));
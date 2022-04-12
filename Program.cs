Conta c1 = new Conta(1); //1 é o código da conta
Conta c2 = new Conta(2);

c1.Depositar(1000.00); //passando o valor a ser depositado
c1.Sacar(200.00);
Console.WriteLine(c1.Saldo);

c1.Transferir(100.00, c2);
Console.WriteLine(c1.Saldo);

c2.Depositar(200.00);
c2.Sacar(150.00);
Console.WriteLine(c2.Saldo);

c2.Transferir(10.00, c1);
Console.WriteLine(c2.Saldo);
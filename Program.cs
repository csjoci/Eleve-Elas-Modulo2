using Eleve_Elas_Modulo2.Entidade;


//Pessoa pessoa = new Pessoa(); nao é possivel instanciar posi é abstrata

Adulto adulto = new Adulto();   
Crianca crianca = new Crianca();    
Bebe   bebe = new Bebe();

Console.WriteLine($"é assim que um adulto come: {adulto.Comer()}");
Console.WriteLine($"é assim que um crianca come: {crianca.Comer()}");
Console.WriteLine($"é assim que um bebe come: {bebe.Comer()}");
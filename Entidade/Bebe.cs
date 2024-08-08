namespace Eleve_Elas_Modulo2.Entidade;

public class Bebe : Pessoa
{
    public override string Comer()
    {
        return "tomar leite";
    }

    public override string Andar()//sobrescrita
    {
        return "engatinhar";
    }

    public string Andar(string pessoa) //sobrecarga, mesmo nome e parametros diferentes
    {
        return pessoa;
    }
}

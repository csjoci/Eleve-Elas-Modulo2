namespace Eleve_Elas_Modulo2.Entidade;

public abstract class Pessoa
{
    public string Nome{ get; set; }
    public DateTime DataNascimento { get; set; }
    public string Filicacao { get; set; }

    public abstract string Comer();
    public virtual string Andar()
    {
        return "levantou e caminhou";
    }
}

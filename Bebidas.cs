namespace WineBar;

public class Bebidas
{
    public string Nome { get; set; }
    public int Conteudo { get; set; }
    public double TeorAlcoolico { get; set; }
    public string TipoUva { get; set; }
    public double Preco { get; set; }
    public string Descricao { get; set; }
    public string Pais { get; set; }
    public List<Bebidas> CatalogoVinhos { get; set; }

    public override string ToString()
    {
        return $"{Nome} {Conteudo}ml, com teor alcoólico de {TeorAlcoolico}%, provindo de {Pais} por {Preco}BRL. Produzida principalmente pela(s) uva(s): {TipoUva}. {Descricao}.";
    }
}
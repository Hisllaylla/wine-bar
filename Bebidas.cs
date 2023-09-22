namespace WineBar;

public record Bebidas(string Nome, int Conteudo, double TeorAlcoolico, string TipoUva, double Preco, string Descricao, string Pais, List<Bebidas> CatalogoVinhos)
{
    public override string ToString()
    {
        return $"{Nome} {Conteudo}ml, com teor alcoólico de {TeorAlcoolico}%, provindo de {Pais} por {Preco}BRL. Produzida principalmente pela(s) uva(s): {TipoUva}. {Descricao}.";
    }
}
namespace WineBar;

public record Bebidas(string Nome, int Conteudo, double TeorAlcoolico, string TipoUva, double Preco, string Descricao, string Pais)
{
    public override string ToString()
    {
        return $"{Nome} por {Preco} BRL, {Conteudo}ml com teor alcoólico de {TeorAlcoolico}%, produzida principalmente pela(s) uva(s): {TipoUva}. {Descricao}.";
    }
}
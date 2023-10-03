namespace WineBar;

// record serve para que todos as propriedades sejam preenchidas, não aceitando valor nulo.
public record Bebidas(string Nome, int Conteudo, double TeorAlcoolico, string TipoUva, double Preco, string Descricao, string Pais)
{
    public override string ToString() // personalização do retorno
    {
        return $"{Nome} por {Preco} BRL, {Conteudo}ml com teor alcoólico de {TeorAlcoolico}%, produzida principalmente pela(s) uva(s): {TipoUva}. {Descricao}.";
    }
}
namespace WineBar;

public record Bebidas(string Nome, int Conteudo, double TeorAlcoolico, string TipoUva, double Preco, string Descricao, string Pais, List<Bebidas> CatalogoVinhos)
{
    public override string ToString()
    {
        return $"Nome: {Nome}, Contéudo: {Conteudo}ml, Teor Alcoólico: {TeorAlcoolico}%, produzida principalmente pela(s) uva(s): {TipoUva} por {Preco} BRL. {Descricao}. De {Pais}";
    }
}
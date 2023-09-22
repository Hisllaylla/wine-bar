List<Bebidas> catalogoVinhos = new List<Bebidas>
{
    new Bebidas { Nome = "VINHO BALLOON", Conteudo = 750, TeorAlcoolico = 13.8, TipoUva = "Malbec", Preco = 49.99, Descricao = "Harmonização: é um companheiro ideal carnes vermelhas, queijo maturados e alimentos condimentados", Pais = "Argentina"},
    new Bebidas { Nome = "VINHO CORDERO CON PIEL DE LOBO ROSE", Conteudo = 750, TeorAlcoolico = 12.5, TipoUva = "", Preco = 54.99, Descricao = "Harmonização: Carnes brancas, massas e queijos moles", Pais = "Argentina" },
    new Bebidas { Nome = "VINHO ROCIM MARIANA BRANCO", Conteudo = 750, TeorAlcoolico = 12.5, TipoUva = "60% Antão Vaz, 30% Arinto e 10% Alvarinho", Preco = 114.99, Descricao = "Harmonização: É ideal para acompanhar pratos leves, como saladas, peixes grelhados, frutos do mar e aves", Pais = "Portugal" },
    new Bebidas { Nome = "VINHO QUINTA DO PESSEGUEIRO ALUZÉ DOC", Conteudo = 750, TeorAlcoolico = 14.5, TipoUva = "Touriga Nacional", Preco = 189.99, Descricao = "Harmonização: Carnes vermelhas grelhadas e assadas com molhos à base de vinho, rosbife, bacalhau ao forno com batatas, pimentões e azeite, além de embutidos e queijos macios", Pais = "Portugal" },
    new Bebidas { Nome = "VINHO TORREVENTO INFINITUM PRIMITIVO IGT", Conteudo = 750, TeorAlcoolico = 12.5, TipoUva = "Primitivo", Preco = 94.99, Descricao = "Harmonização: Carnes vermelhas grelhadas e assadas com molhos de média intensidade, preparações a base de carne suína com molhos sutilmente doces, embutidos e queijos maduros", Pais = "Itália" },
    new Bebidas { Nome = "VINHO CASTELLO BANFI BRUNELLO DI MONTALCINO DOCG", Conteudo = 750, TeorAlcoolico = 15.0, TipoUva = "Sanglovese Grosso (Brunello)", Preco = 799.99, Descricao = "Harmonização: Carnes Vermelhas e de caça, massas com molhos intensos ou vermelho e queijos maturados", Pais = "Itália" },
    new Bebidas { Nome = "VINHO SANTA VITA RESERVA CARMENERE", Conteudo = 750, TeorAlcoolico = 13.0, TipoUva = "Carmenere", Preco = 39.99, Descricao = "Harmonização: Filet mignon ao molho de mostarda - Verduras salteadas na manteiga - Frutos do mar grelhados e bem condimentados", Pais = "Chile" },
    new Bebidas { Nome = "VINHO SANTA VITA RESERVA SAUVIGNON BLANC", Conteudo = 750, TeorAlcoolico = 12.5, TipoUva = "Sauvignon Blanc", Preco = 39.99, Descricao = "Harmonização: Saladas diversas, carnes brancas, frutos do mar", Pais = "Chile" },
    new Bebidas { Nome = "VINHO CHÂTEAU PAVIE 2016", Conteudo = 750, TeorAlcoolico = 13.5, TipoUva = "60% Merlot, 22% Cabernet Franc e 18% Cabernet Sauvignon", Preco = 8719.99, Descricao = "Harmonização: Carnes vermelhas grelhadas e assadas, churrasco, cordeiro, pratos com cogumelos, massas com ragu de carne, embutidos e queijos duros", Pais = "França" },
    new Bebidas { Nome = "VINHO RENDEZ VOUS SAUVIGNON BLANC", Conteudo = 750, TeorAlcoolico = 11.5, TipoUva = "Sauvignon Blanc", Preco = 109.99, Descricao = "Harmonização:  Entradas leves, como saladas, pescados e frutos do mar, como sashimi e ceviche, além de queijos de massa mole", Pais = "França" },
    new Bebidas { Nome = "VINHO ANGOVE FAMILY CREST MCLAREN VALE GSM", Conteudo = 750, TeorAlcoolico = 14.5, TipoUva = "42% Grenache, 34% Shiraz e 24% Mourvèdre", Preco = 239.99, Descricao = "Harmonização: Carnes vermelhas grelhadas e assadas, churrasco, carnes de caça, massas com molho de tomate e queijos duros", Pais = "Austrália" },
    new Bebidas { Nome = "VINHO TWO HANDS SAMANTHA'S GARDEN CLARE VALLEY SHIRAZ", Conteudo = 750, TeorAlcoolico = 13.5, TipoUva = "Shiraz", Preco = 769.99, Descricao = "Harmonização: Churrasco, carnes de caça, pratos à base de cogumelos, embutidos", Pais = "Austrália" },
};

// VALIDAÇÃO MAIORIDADE
Console.WriteLine("W I N E    B A R");
Console.WriteLine("");

Console.WriteLine("Bebidas álcóolicas são proíbidas para menores de 18 anos. Digite sua idade antes de prosseguir.");
string input = Console.ReadLine();

int idade;
if (int.TryParse(input, out idade) && idade >= 18)
{
    Console.WriteLine("Seja bem-vindo!");
}
else
{
    Console.WriteLine("Erro :/");
    return;
}


// FILTRO
Console.WriteLine("Digite um dos números a seguir para filtrar os vinhos por seus respectivos países: 0 [TODOS], 1 [ARGENTINA], 2 [PORTUGAL], 3 [ITÁLIA], 4 [CHILE], 5 [FRANÇA], 6 [AUSTRÁLIA]");
string filtro = Console.ReadLine();

var vinhoArgentina = catalogoVinhos.Where(x => x.Pais == "Argentina").ToList();
var vinhoPortugal = catalogoVinhos.Where(x => x.Pais == "Portugal").ToList();
var vinhoItalia = catalogoVinhos.Where(x => x.Pais == "Itália").ToList();
var vinhoChile = catalogoVinhos.Where(x => x.Pais == "Chile").ToList();
var vinhoFranca = catalogoVinhos.Where(x => x.Pais == "França").ToList();
var vinhoAustralia = catalogoVinhos.Where(x => x.Pais == "Austrália").ToList();

switch (filtro)
{
    case "0":
        foreach (var vinho in catalogoVinhos)
        {
            Console.WriteLine(vinho.ToString());
        }
        break;

    case "1":
        foreach (var vinho in vinhoArgentina)
        {
            Console.WriteLine(vinho.ToString());
        }
        break;

    case "2":
        foreach (var vinho in vinhoPortugal)
        {
            Console.WriteLine(vinho.ToString());
        }
        break;

    case "3":
        foreach (var vinho in vinhoItalia)
        {
            Console.WriteLine(vinho.ToString());
        }
        break;

    case "4":
        foreach (var vinho in vinhoChile)
        {
            Console.WriteLine(vinho.ToString());
        }
        break;

    case "5":
        foreach (var vinho in vinhoFranca)
        {
            Console.WriteLine(vinho.ToString());
        }
        break;

    case "6":
        foreach (var vinho in vinhoAustralia)
        {
            Console.WriteLine(vinho.ToString());
        }
        break;
    default:
        Console.WriteLine("Opção inválida.");
        break;
}

List<Bebidas> catalogoVinhos = new List<Bebidas>
{
    new("VINHO BALLOON", 750, 13.8, "Malbec", 49.99, "Harmonização: é um companheiro ideal carnes vermelhas, queijo maturados e alimentos condimentados", "Argentina"),
    new("VINHI CORDERO CON PIEL DE LOBO ROSE", 750, 12.5, "Malbec", 54.99, "Harmonização: Carnes brancas, massas e queijos moles", "Argentina"),
    new("VINHO ROCIM MARIANA BRANCO", 750, 12.5, "60% Antão Vaz, 30% Arinto e 10% Alvarinho", 114.99, "Harmonização: É ideal para acompanhar pratos leves, como saladas, peixes grelhados, frutos do mar e aves", "Portugal"),
    new("VINHO QUINTA DO PESSEGUEIRO ALUZÉ DOC", 750, 14.5, "Touriga Nacional", 189.99, "Harmonização: Carnes vermelhas grelhadas e assadas com molhos à base de vinho, rosbife, bacalhau ao forno com batatas, pimentões e azeite, além de embutidos e queijos macios", "Portugal"),
    new("VINHO TORREVENTO INFINITUM PRIMITIVO IGT", 750, 12.5, "Primitivo", 94.99, "Harmonização: Carnes vermelhas grelhadas e assadas com molhos de média intensidade, preparações a base de carne suína com molhos sutilmente doces, embutidos e queijos maduros", "Itália"),
    new("VINHO CASTELLO BANFI BRUNELLO DI MONTALCINO DOCG", 750, 15.0, "Sanglovese Grosso (Brunello)", 799.99, "Harmonização: Carnes Vermelhas e de caça, massas com molhos intensos ou vermelho e queijos maturados", "Itália"),
    new("VINHO SANTA VITA RESERVA CARMENERE", 750, 13.0, "Carmenere", 39.99, "Harmonização: Filet mignon ao molho de mostarda, verduras salteadas na manteiga, frutos do mar grelhados e bem condimentados", "Chile"),
    new("VINHO SANTA VITA RESERVA SAUVIGNON BLANC", 750, 12.5, "Sauvignon Blanc", 39.99, "Harmonização: Saladas diversas, carnes brancas, frutos do mar", "Chile"),
    new("VINHO CHÂTEAU PAVIE 2016", 750, 13.5, "60% Merlot, 22% Cabernet Franc e 18% Cabernet Sauvignon", 8719.99, "Harmonização: Carnes vermelhas grelhadas e assadas, churrasco, cordeiro, pratos com cogumelos, massas com ragu de carne, embutidos e queijos duros", "França"),
    new("VINHO RENDEZ VOUS SAUVIGNON BLANC", 750, 11.5, "Sauvignon Blanc", 109.99, "Harmonização:  Entradas leves, como saladas, pescados e frutos do mar, como sashimi e ceviche, além de queijos de massa mole", "França"),
    new("VINHO ANGOVE FAMILY CREST MCLAREN VALE GSM", 750, 14.5, "42% Grenache, 34% Shiraz e 24% Mourvèdre", 239.99, "Harmonização: Carnes vermelhas grelhadas e assadas, churrasco, carnes de caça, massas com molho de tomate e queijos duros", "Austrália"),
    new("INHO TWO HANDS SAMANTHA'S GARDEN CLARE VALLEY SHIRAZ", 750, 13.5, "Shiraz", 769.99, "Harmonização: Churrasco, carnes de caça, pratos à base de cogumelos, embutidos", "Austrália"),
};

// VALIDAÇÃO MAIORIDADE
Console.WriteLine("W I N E    B A R");
Console.WriteLine("");

Console.WriteLine("Bebidas álcóolicas são proíbidas para menores de 18 anos. Digite sua idade antes de prosseguir.");
string input = Console.ReadLine();
Console.WriteLine("");

int idade;
if (int.TryParse(input, out idade) && idade >= 18)
{
    Console.WriteLine("Seja bem-vindo!");
    Console.WriteLine("");
}
else
{
    Console.WriteLine("Permissão negada!");
    return;
}


// FILTRO
Console.WriteLine("Digite um dos números a seguir para filtrar os vinhos por seus respectivos países: 0 [TODOS], 1 [ARGENTINA], 2 [PORTUGAL], 3 [ITÁLIA], 4 [CHILE], 5 [FRANÇA], 6 [AUSTRÁLIA]");
string filtro = Console.ReadLine();
Console.WriteLine("");

switch (filtro)
{
    case "0":
        foreach (var vinho in catalogoVinhos)
        {
            Console.WriteLine(vinho.ToString());
            Console.WriteLine("");
        }
        break;

    case "1":
        var vinhoArgentina = catalogoVinhos.Where(x => x.Pais == "Argentina").ToList();
        foreach (var vinho in vinhoArgentina)
        {
            Console.WriteLine(vinho.ToString());
            Console.WriteLine("");
        }
        break;

    case "2":
        var vinhoPortugal = catalogoVinhos.Where(x => x.Pais == "Portugal").ToList();
        foreach (var vinho in vinhoPortugal)
        {
            Console.WriteLine(vinho.ToString());
            Console.WriteLine("");
        }
        break;

    case "3":
        var vinhoItalia = catalogoVinhos.Where(x => x.Pais == "Itália").ToList();
        foreach (var vinho in vinhoItalia)
        {
            Console.WriteLine(vinho.ToString());
            Console.WriteLine("");
        }
        break;

    case "4":
        var vinhoChile = catalogoVinhos.Where(x => x.Pais == "Chile").ToList();
        foreach (var vinho in vinhoChile)
        {
            Console.WriteLine(vinho.ToString());
            Console.WriteLine("");
        }
        break;

    case "5":
        var vinhoFranca = catalogoVinhos.Where(x => x.Pais == "França").ToList();
        foreach (var vinho in vinhoFranca)
        {
            Console.WriteLine(vinho.ToString());
            Console.WriteLine("");
        }
        break;

    case "6":
        foreach (var vinho in catalogoVinhos.Where(x => x.Pais == "Austrália").ToList()) // EXEMPLO
        {
            Console.WriteLine(vinho.ToString());
            Console.WriteLine("");
        }
        break;
    default:
        Console.WriteLine("Opção inválida.");
        break;
}

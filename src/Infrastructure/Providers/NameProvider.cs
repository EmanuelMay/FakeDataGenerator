using GeneratorFakeData.Domain.Interfaces.Providers;

namespace GeneratorFakeData.Infrastructure.Provider
{
    public class NameProvider : INameProvider
    {
        public string[] GetPrimaryNames()
        {
            string[] names = new string[]
            {
            "Ana","Maria","João","Pedro","Lucas","Mateus","Gabriel","Rafael","Daniel","Bruno",
            "Carla","Fernanda","Juliana","Patricia","Amanda","Larissa","Beatriz","Camila","Mariana","Aline",
            "Rodrigo","Felipe","Gustavo","Vinicius","Diego","André","Carlos","Eduardo","Leonardo","Marcelo",
            "Ricardo","Thiago","Renato","Paulo","Fábio","Alexandre","Vitor","Igor","Samuel","Nicolas",
            "Isabela","Leticia","Gabriela","Bianca","Natalia","Vanessa","Tatiane","Priscila","Rafaela","Débora",
            "Helena","Alice","Laura","Valentina","Heloisa","Sofia","Manuela","Luiza","Clara","Cecilia",
            "Arthur","Davi","Bernardo","Heitor","Enzo","Murilo","Lorenzo","Pietro","Caio","Otavio",
            "Yasmin","Evelyn","Bruna","Milena","Melissa","Agatha","Kauane","Geovana","Emanuelle","Mirela",
            "Jonathan","Leandro","Jorge","Claudio","Roberto","Sergio","Alberto","Francisco","Antonio","José",
            "Ruan","Wesley","Jean","Everton","Douglas","César","Adriano","Cristiano","Mauricio","Danilo",
            "Raquel","Elaine","Simone","Sandra","Monica","Rosana","Luciana","Eliane","Sueli","Regina",
            "Olivia","Aurora","Esther","Liz","Antonella","Isis","Maya","Zoe","Elisa","Rebeca",
            "Benicio","Noah","Theo","Gael","Breno","Cauã","Ian","Yuri","Kaique","Alan",
            "Karen","Nicole","Tamires","Jéssica","Daiane","Gisele","Sheila","Neide","Cintia","Ivone",
            "Emerson","Rogério","Valdir","Gilberto","Edson","Orlando","Naldo","Elias","Hugo","Ciro",
            "Denise","Cristina","Marcia","Lourdes","Irene","Tereza","Rita","Celia","Vera","Ines",
            "Tomás","Vicente","Augusto","Raul","Benjamim","Emanuel","Matheus","Kevin","Darlan","Jeferson",
            "Alana","Eduarda","Livia","Lorena","Samara","Paloma","Talita","Jaqueline","Marlene","Dalila",
            "Fabiana","Renata","Flavia","Patrícia","Silvana","Janaina","Katia","Luciane","Roseli","Nubia"
            };
    
            return names;
            
        }

        public string[] GetLastNames()
        {
            string[] names = new string[]
            {
            "Silva","Souza","Oliveira","Santos","Lima","Pereira","Ferreira","Alves","Costa","Rodrigues",
            "Martins","Jesus","Sousa","Gomes","Barbosa","Ribeiro","Carvalho","Almeida","Lopes","Soares",
            "Fernandes","Vieira","Barros","Rocha","Dias","Teixeira","Moreira","Correia","Melo","Araújo",
            "Cardoso","Reis","Castro","Nunes","Freitas","Mendes","Farias","Pinto","Azevedo","Cavalcante",
            "Monteiro","Campos","Batista","Assis","Vasconcelos","Moura","Rezende","Peixoto","Coelho","Sales",
            "Machado","Cunha","Macedo","Rangel","Queiroz","Andrade","Borges","Santana","Franco","Figueiredo",
            "Bezerra","Amaral","Leite","Neves","Aguiar","Bittencourt","Tavares","Braga","Siqueira","Lacerda",
            "Valente","Viana","Fonseca","Antunes","Guimarães","Lemos","Pacheco","Guerra","Moraes","Menezes",
            "Brandão","Toledo","Rezende","Duarte","Bastos","Severino","Magalhães","Drumond","Paiva","Portela",
            "Prado","Godoy","Camargo","Bandeira","Sarmento","Alencar","Xavier","Falcão","Marques","Diniz",
            "Cabral","Chaves","Veloso","Torres","Peçanha","Cordeiro","Bessa","Serra","Quintana","Lourenço",
            "Trindade","Mota","Rios","Barreto","Garcia","Navarro","Paz","Coutinho","Teles","Amorim",
            "Salazar","Galvão","Caldeira","Furtado","Ventura","Esteves","Arruda","Bulhões","Lins","Gonçalves",
            "Passos","Nóbrega","Meireles","Boaventura","Resende","Teodoro","Beltrão","Muniz","Leal","Medeiros"
            };
    
            return names;
            
        }

        public string[] GetMotherNames()
        {
            string[] names = new string[]
            {
            "Ana","Maria","Fernanda","Juliana","Camila","Patrícia","Aline","Carla","Bruna","Larissa",
            "Vanessa","Amanda","Jéssica","Letícia","Mariana","Beatriz","Gabriela","Natália","Rafaela","Isabela",
            "Renata","Tatiane","Priscila","Cristiane","Simone","Daniela","Adriana","Eliane","Sandra","Cláudia",
            "Paula","Luciana","Denise","Silvia","Fabiana","Rosana","Verônica","Sabrina","Monique","Mayara",
            "Dayane","Alessandra","Bianca","Tatiana","Cíntia","Elaine","Kelly","Daiane","Lorena","Milena",
            "Débora","Sueli","Irene","Márcia","Regina","Ivone","Neusa","Rita","Vera","Zilda",
            "Josefa","Francisca","Antônia","Sebastiana","Lourdes","Conceição","Terezinha","Helena","Cecília","Olívia",
            "Valéria","Andreia","Nádia","Michele","Gisele","Pâmela","Yasmin","Eduarda","Evelyn","Emanuelle",
            "Vitória","Giovana","Lívia","Heloísa","Alice","Sofia","Manuela","Laura","Clara","Aurora",
            "Melissa","Esther","Isadora","Elisa","Agatha","Mirela","Raquel","Karla","Jussara","Dalva",
            "Leila","Noemi","Samara","Tamara","Marlene","Marilene","Solange","Edna","Lúcia","Tânia",
            "Fátima","Glória","Carmem","Dalila","Jandira","Odete","Dirce","Alzira","Eunice","Hilda",
            "Elza","Zuleide","Nair","Celeste","Leda","Iolanda","Arlete","Sônia","Mônica","Geovana",
            "Brenda","Nicole","Marjorie","Luana","Tainá","Kátia","Rosângela","Janaina","Jéssica","Elisangela",
            "Raissa","Ester","Débora","Alana","Ariane","Bárbara","Caroline","Dandara","Eloá","Flávia",
            "Graziella","Ingrid","Jade","Késia","Laís","Malu","Nayara","Paloma","Queila","Rúbia",
            "Suzana","Taís","Úrsula","Viviane","Wanessa","Yara","Zenaide","Aparecida","Benilde","Cássia",
            "Doroteia","Efigênia","Franciele","Gilmara","Hosana","Iracema","Jocélia","Kellen","Lucélia","Maristela",
            "Nicolle","Odaléia","Pietra","Quitéria","Raimunda","Selma","Telma","Ubiraci","Vilmara","Waleska",
            "Yohana","Zoraide"
            };
    
            return names;
        }
    }
}

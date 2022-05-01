using Microsoft.EntityFrameworkCore.Migrations;
using System.Text;

#nullable disable

namespace MySocialNetwork.Infra.Data.Migrations
{
    public partial class DataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            Random random = new Random();
            List<string> emailDomains = new List<string>();
            List<string> names = new List<string>();
            List<string> surnames = new List<string>();
            List<string> subtitles = new List<string>();
            List<string> comments = new List<string>();
            List<string> images = new List<string>();
            List<string> genres = new List<string>();

            genres.Add("M");
            genres.Add("F");

            emailDomains.Add("@yahoo.com");
            emailDomains.Add("@gmail.com");
            emailDomains.Add("@hotmail.com");
            emailDomains.Add("@outlook.com");
            emailDomains.Add("@email.com");
            emailDomains.Add("@microsoft.com");

            names.Add("Miguel");
            names.Add("Davi");
            names.Add("Arthur");
            names.Add("Pedro");
            names.Add("Gabriel");
            names.Add("Bernardo");
            names.Add("Lucas");
            names.Add("Miguel");
            names.Add("Matheus");
            names.Add("Rafael");
            names.Add("Heitor");
            names.Add("Enzo");
            names.Add("Guilherme");
            names.Add("Nicolas");
            names.Add("Lorenzo");
            names.Add("Gustavo");
            names.Add("Felipe");
            names.Add("João Pedro");
            names.Add("Daniel");
            names.Add("Vitor");
            names.Add("Sophia");
            names.Add("Alice");
            names.Add("Julia");
            names.Add("Isabella");
            names.Add("Manuela");
            names.Add("Laura");
            names.Add("Luiza");
            names.Add("Valentina");
            names.Add("Giovanna");
            names.Add("Maria Eduarda");
            names.Add("Helena");
            names.Add("Beatriz");
            names.Add("Maria Luiza");
            names.Add("Lara");
            names.Add("Mariana");
            names.Add("Nicole");
            names.Add("Rafaela");
            names.Add("Heloísa");
            names.Add("Isadora");
            names.Add("Lívia");

            surnames.Add("Silva");
            surnames.Add("Santos");
            surnames.Add("Oliveira");
            surnames.Add("Souza");
            surnames.Add("Rodrigues");
            surnames.Add("Ferreira");
            surnames.Add("Alves");
            surnames.Add("Pereira");
            surnames.Add("Lima");
            surnames.Add("Gomes");
            surnames.Add("Costa");
            surnames.Add("Ribeiro");
            surnames.Add("Martins");
            surnames.Add("Carvalho");
            surnames.Add("Almeida");
            surnames.Add("Lopes");
            surnames.Add("Soares");
            surnames.Add("Fernandes");
            surnames.Add("Vieira");
            surnames.Add("Barbosa");
            surnames.Add("Rocha");

            subtitles.Add("Não deixe as incertezas atrapalharem a sua felicidade. Sorria e tenha um bom dia!");
            subtitles.Add("Bom dia! No lugar de olhar para as dificuldades, olhe hoje para todas as coisas boas que estão perto de você.");
            subtitles.Add("Bom dia! Dica para hoje: sorria para todos que puder! O pior que pode acontecer é ganhar uns belos sorrisos de volta.");
            subtitles.Add("Bom dia! Que o dia seja de sol dentro de você, mesmo que na rua seja chuva.");
            subtitles.Add("Sabe aquele dia especial e cheio de boas notícias? É o que quero para você hoje!");
            subtitles.Add("Bom dia! O conselho de hoje é: tome um café e pense positivo. Às vezes, estes dois itens são tudo o que um dia precisa.");
            subtitles.Add("Bom dia! Tente ser o arco-íris em todos os dias nublados.");
            subtitles.Add("Que o seu dia seja tão maravilhoso quanto o seu coração. Vista o seu melhor sorriso e espalhe motivação para todos ao seu redor. Bom dia!");
            subtitles.Add("Nunca se esqueça que qualquer coisa que você planta, a vida floresce com graça.");
            subtitles.Add("Bom dia, amigos! Que Deus acompanhe vocês neste dia de hoje, iluminando cada passo.");
            subtitles.Add("Bom dia! Hoje vamos fazer diferente: no lugar de sonhar pelo amanhã, vamos agradecer pelo ontem.");
            subtitles.Add("Para boas recompensas, não há atalhos! Boa noite.");
            subtitles.Add("Encontramos a verdadeira felicidade quando somos felizes sem motivos. Boa noite!");
            subtitles.Add("Direcione o seu rosto sempre na direção do sol, para que as sombras fiquem para trás. Boa noite!");
            subtitles.Add("Vencedores não são pessoas que nunca falham, são pessoas que nunca desistem. Boa noite!");
            subtitles.Add("A cada noite temos uma nova oportunidade de recarregar as nossas energias e refletir sobre a nossa evolução espiritual. Bom descanso.");
            subtitles.Add("Cerque-se de pessoas que acreditam e lutam por você. Este é o primeiro passo para o sucesso. Boa noite!");
            subtitles.Add("Deus mostra em suas palavras que a força dos bons deve ser usada para benefício de todos. Tenha uma boa noite.");
            subtitles.Add("Einstein disse que a imaginação é mais importante que o conhecimento. Aflore a sua imaginação em seus sonhos. Boa noite!");
            subtitles.Add("Esteja presente em cada momento da sua vida, antes que estes momentos se tornem apenas lembranças. Bons sonhos!");
            subtitles.Add("Os limites que impomos podem se tornar verdadeiras prisões. Sonhe alto e tenha uma boa noite!");

            comments.Add("A vida e uma caixa preta nunca saberemos o seu real significado.⁠");
            comments.Add("Faça a pessoa que você gosta se sentir especial ao invés de só mais uma.⁠");
            comments.Add("⁠não deveríamos temer a morte, mais sim a vida.⁠");
            comments.Add("Teu abraço eras confortante⁠.");
            comments.Add("Seja estranho. Seja aleatório. Seja quem você é. Porque você nunca sabe quem amaria a pessoa que você esconde.");
            comments.Add("A vida é um caos aleatório,ordenada pelo tempo.⁠");
            comments.Add("A verdade, é que dói lembrar dela.⁠");
            comments.Add("Cada instante é sempre.⁠");
            comments.Add("O aleatório não existe, nosso cérebro sempre toma decisões mesmo que ocultas.⁠");
            comments.Add("Um ato aleatório de bondade, por menor que seja, pode ter um tremendo impacto na vida de outra pessoa.");
            comments.Add("No mundo do aleatório a ordem é não se preocupar.⁠");
            comments.Add("⁠Cuide de si mesmo como cuidaria de alguém que você ama.⁠");
            comments.Add("Sinto falta daquelas risadas, mas lembro como você fazia me sentir sozinho.⁠");
            comments.Add("As vezes me sinto como não fosse deste mundo, acho que a maioria se sente assim desse modo.");
            comments.Add("Fico pensando o quanto te amei, e muitas das vezes deixei - me de lado. Fui tão sua que tinha esquecido de me, mas as pessoas mudam e esse dia chegou, e hoje sou só minha e de mais ninguém.");
            comments.Add("Você não precisa de platéia cheia para reconhecer que você é o melhor.⁠");
            comments.Add("Não venha tirar - me a paciência, já estou exausta demais com os meus próprios pensamentos.⁠");
            comments.Add("Crescer dói, e dói muito.⁠");
            comments.Add("E é nas madrugada onde todos os meus pensamentos ocultos acordam, onde uns tentam falar mais alto que outros.");
            comments.Add("Seja a mudança que você quer ver no mundo.⁠");
            comments.Add("O dinheiro faz homens ricos, o conhecimento faz homens sábios e a humildade faz grandes homens.⁠");
            comments.Add("Bons amigos são como estrelas: nem sempre podemos ver, mas temos certeza que estão sempre lá.⁠");
            comments.Add("Se for pra desistir, desista de ser fraco.⁠");
            comments.Add("Que todo mal vire amor, que toda dor vire flor.⁠");

            for (int i = 1; i <= 30; i++)
            {
                int idxRandomName = random.Next(0, names.Count);
                var name = names[idxRandomName];
                char genre = idxRandomName <= names.Count / 2 - 1 ? 'M' : 'F';

                var surname = surnames[random.Next(0, surnames.Count)];
                var email = name + random.Next(0, 99999) + emailDomains[random.Next(0, emailDomains.Count)];
                email = email.Replace(" ", "").ToLower();
                if (i % 3 == 0)
                {
                    surname += " " + surnames[random.Next(0, surnames.Count)];
                }

                var completeName = name + " " + surname;

                migrationBuilder.Sql($"INSERT INTO aspnetusers (Id, UserName, NormalizedUserName, Email, NormalizedEmail, PasswordHash, SecurityStamp, EmailConfirmed, PhoneNumberConfirmed, TwoFactorEnabled, LockoutEnabled, AccessFailedCount) VALUES ('{RandomId()}', '{email}', '{email.ToUpper()}', '{email}', '{email.ToUpper()}', 'AQAAAAEAACcQAAAAEF7ZPYJAAEbq5mbWR/oV8nDW7Rxmw8Mz7002nLqMQmSeI7EtW+iCN7mKiXUycbDkCQ==','GLYT2WREALAQEOIAS7KCELYGFW6HSR2S', 0, 0, 0, 0, 0)");
                migrationBuilder.Sql($"INSERT INTO users (Id, `Name`, Email, BirthDate, Genre, ProfilePicture, CreatedAt, UpdatedAt) VALUES ({i},'{completeName}', '{email}', '{RamdomDate()}', '{genre}', NULL, '{RamdomDate(DateTime.Now.Year, DateTime.Now.Year + 1)}', '{RamdomDate(DateTime.Now.Year, DateTime.Now.Year + 1)}')");
            }


            for (int i = 1; i <= 100; i++)
            {
                var createdAt = RamdomDate(DateTime.Now.Year - 2, DateTime.Now.Year);
                migrationBuilder.Sql($"INSERT INTO posts (Id, UserId, Subtitle, CreatedAt, UpdatedAt) VALUES ({i}, {random.Next(1, 6)}, '{subtitles[random.Next(0, subtitles.Count)]}', '{createdAt}', '{createdAt}')");
            }

            for (int i = 1; i <= 500; i++)
            {
                var createdAt = RamdomDate(DateTime.Now.Year - 2, DateTime.Now.Year);
                migrationBuilder.Sql($"INSERT INTO likes (Id, PostId, UserId,IsLiked, CreatedAt, UpdatedAt) VALUES ({i}, {random.Next(1, 100)}, {random.Next(1, 30)}, {random.Next(0, 1)}, '{createdAt}', '{createdAt}')");
            }

            for (int i = 1; i <= 100; i++)
            {
                var createdAt = RamdomDate(DateTime.Now.Year - 2, DateTime.Now.Year);
                migrationBuilder.Sql($"INSERT INTO comments (Id, PostId, Text ,UserId, CreatedAt, UpdatedAt) VALUES ({i}, {random.Next(1, 100)}, '{comments[random.Next(0, comments.Count)]}', {random.Next(1, 30)}, '{createdAt}', '{createdAt}')");
            }


            for (int i = 0; i <= 5; i++)
            {
                /*
                var path = $@"C:\Users\Daniel\Documents\Estudos\CSharp\MySocialNetwork\MySocialNetwork.WebUI\uploads\users\publications\{i}.jpg";
                var fileInfo = new FileInfo(path);
                byte[] data = new byte[fileInfo.Length];
                string file = Encoding.Default.GetString(data);

                var createdAt = random.Next(2010, DateTime.Now.Year) + "/" + random.Next(1, 12) + "/" + random.Next(1, 28);
                migrationBuilder.Sql($"INSERT INTO images (Id, PostId, File, CreatedAt, UpdatedAt) VALUES ({i + 1}, {random.Next(1, 100)}, '{file}', '{createdAt}', '{createdAt}')");
                */
            }

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }

        private static string RandomId(int size = 36)
        {
            Random random = new Random();
            var chars = "1234567890abcdefghijklmnopqrstuvwxyz";
            var hashId = new String(
                    Enumerable.Repeat(chars, size)
                    .Select(s => s[random.Next(s.Length)]).ToArray()
                );

            return hashId.ToLower();
        }

        private static string RamdomDate(int minYear = 1960, int maxYear = 2010)
        {
            var random = new Random();

            var year = random.Next(minYear, maxYear);
            var mounth = random.Next(1, 12);
            var day = random.Next(1, 31);

            string strDay = day <= 9 ? "0" + day : day.ToString();
            string strMounth = mounth <= 9 ? "0" + mounth : mounth.ToString();


            if (mounth % 2 != 0 && day == 31)
            {
                strDay = "30";
            }

            if (mounth == 2 && day >= 30)
            {
                if (DateTime.IsLeapYear(year))
                {
                    strDay = "29";
                }
                else
                {
                    strDay = "28";
                }
            }

            return year + "/" + strMounth + "/" + strDay;

        }
    }
}

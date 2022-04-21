using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Globalization;

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

            for (int i = 1; i <= 30; i++)
            {
                var name = names[random.Next(0, names.Count)];
                var surname = surnames[random.Next(0, surnames.Count)];
                var email = name + random.Next(0, 9999) + emailDomains[random.Next(0, emailDomains.Count)];
                email = email.Replace(" ", "").ToLower();
                if (i % 3 == 0)
                {
                    surname += " " + surnames[random.Next(0, surnames.Count)];
                }

                var completeName = name + " " + surname;

                migrationBuilder.Sql($"INSERT INTO aspnetusers (Id, UserName, NormalizedUserName, Email, NormalizedEmail, PasswordHash, SecurityStamp, EmailConfirmed, PhoneNumberConfirmed, TwoFactorEnabled, LockoutEnabled, AccessFailedCount) VALUES ('{RandomId()}', '{email}', '{email.ToUpper()}', '{email}', '{email.ToUpper()}', 'AQAAAAEAACcQAAAAEF7ZPYJAAEbq5mbWR/oV8nDW7Rxmw8Mz7002nLqMQmSeI7EtW+iCN7mKiXUycbDkCQ==','GLYT2WREALAQEOIAS7KCELYGFW6HSR2S', 0, 0, 0, 0, 0)");
                migrationBuilder.Sql($"INSERT INTO users (Id, `Name`, Email, BirthDate, Genre, ProfilePicture, CreatedAt, UpdatedAt) VALUES ({i},'{completeName}', '{email}', '{random.Next(1960, 2005)}/{random.Next(1, 12)}/{random.Next(1, 28)}', '{genres[random.Next(0, 1)]}', NULL, '1959/01/01', '1959/01/01')");
            }


            for (int i = 1; i <= 100; i++)
            {
                var createdAt = random.Next(2010, 2022) + "/" + random.Next(1, 12) + "/" + random.Next(1, 28);
                migrationBuilder.Sql($"INSERT INTO posts (Id, UserId, Subtitle, CreatedAt, UpdatedAt) VALUES ({i}, {random.Next(1, 6)}, '{subtitles[random.Next(0, subtitles.Count)]}', '{createdAt}', '{createdAt}')");
            }

            for (int i = 1; i <= 1000; i++)
            {
                var createdAt = random.Next(2010, 2022) + "/" + random.Next(1, 12) + "/" + random.Next(1, 28);
                migrationBuilder.Sql($"INSERT INTO likes (Id, PostId, UserId,IsLiked, CreatedAt, UpdatedAt) VALUES ({i}, {random.Next(1, 100)}, {random.Next(1, 30)}, {random.Next(0,1)}, '{createdAt}', '{createdAt}')");
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
    }
}

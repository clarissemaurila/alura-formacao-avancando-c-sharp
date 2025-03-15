using ScreenSound_API.Modelos;
using System.Text.Json;
using ScreenSound_API.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        LinqFilter.FiltrarMusicasEmCSharp(musicas);

        //musicas[1].ExibirDetalhesDaMusica();
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "U2");


        //var musicasPreferidasDoDaniel = new MusicasPreferidas("daniel");
        //musicasPreferidasDoDaniel.AdicionarmusicasFavoritas(musicas[1]);
        //musicasPreferidasDoDaniel.AdicionarmusicasFavoritas(musicas[377]);
        //musicasPreferidasDoDaniel.AdicionarmusicasFavoritas(musicas[4]);
        //musicasPreferidasDoDaniel.AdicionarmusicasFavoritas(musicas[6]);
        //musicasPreferidasDoDaniel.AdicionarmusicasFavoritas(musicas[1467]);


        //var musicasPreferidasDoGuilherme = new MusicasPreferidas("Guilherme");

        //musicasPreferidasDoGuilherme.AdicionarmusicasFavoritas(musicas[500]);
        //musicasPreferidasDoGuilherme.AdicionarmusicasFavoritas(musicas[637]);
        //musicasPreferidasDoGuilherme.AdicionarmusicasFavoritas(musicas[428]);
        //musicasPreferidasDoGuilherme.AdicionarmusicasFavoritas(musicas[17]);
        //musicasPreferidasDoGuilherme.AdicionarmusicasFavoritas(musicas[71]);

        //musicasPreferidasDoGuilherme.ExibirMusicasFavoritas();

        //musicasPreferidasDoGuilherme.GerarArquivoJson();


    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}
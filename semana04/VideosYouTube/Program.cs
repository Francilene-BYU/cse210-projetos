
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // VÍDEO 1
        Video video1 = new Video(
            "Aprendendo C#",
            "Canal Programação",
            600
        );

        video1.AdicionarComentario(new Comentario(
            "Ana", "Excelente explicação!"
        ));

        video1.AdicionarComentario(new Comentario(
            "Pedro", "Aprendi bastante."
        ));

        video1.AdicionarComentario(new Comentario(
            "Maria", "Aguardando o próximo vídeo."
        ));


        // VÍDEO 2
        Video video2 = new Video(
            "Introdução à Programação",
            "Mundo Tech",
            900
        );

        video2.AdicionarComentario(new Comentario(
            "João", "Muito interessante!"
        ));

        video2.AdicionarComentario(new Comentario(
            "Carla", "Conteúdo muito útil."
        ));

        video2.AdicionarComentario(new Comentario(
            "Lucas", "Gostei dos exemplos."
        ));


        // VÍDEO 3
        Video video3 = new Video(
            "Como funciona a Internet",
            "Tecnologia Fácil",
            750
        );

        video3.AdicionarComentario(new Comentario(
            "Beatriz", "Agora entendi!"
        ));

        video3.AdicionarComentario(new Comentario(
            "Rafael", "Ótimo conteúdo."
        ));

        video3.AdicionarComentario(new Comentario(
            "Fernanda", "Explicação clara."
        ));


        // LISTA DE VÍDEOS
        List<Video> videos = new List<Video>
        {
            video1,
            video2,
            video3
        };


        // EXIBIÇÃO DOS VÍDEOS
        foreach (Video video in videos)
        {
            Console.WriteLine("==================================");
            Console.WriteLine($"Título: {video.Titulo}");
            Console.WriteLine($"Autor: {video.Autor}");
            Console.WriteLine($"Duração: {video.Duracao} segundos");
            Console.WriteLine(
                $"Quantidade de comentários: {video.ObterQuantidadeComentarios()}"
            );

            Console.WriteLine("\nComentários:");

            foreach (Comentario comentario in video.ObterComentarios())
            {
                Console.WriteLine(
                    $"{comentario.NomePessoa}: {comentario.Texto}"
                );
            }

            Console.WriteLine();
        }
    }
}

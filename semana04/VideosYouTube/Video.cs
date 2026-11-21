
using System.Collections.Generic;

class Video
{
    private string _titulo;
    private string _autor;
    private int _duracao;
    private List<Comentario> _comentarios;

    public Video(string titulo, string autor, int duracao)
    {
        _titulo = titulo;
        _autor = autor;
        _duracao = duracao;
        _comentarios = new List<Comentario>();
    }

    public string Titulo
    {
        get { return _titulo; }
    }

    public string Autor
    {
        get { return _autor; }
    }

    public int Duracao
    {
        get { return _duracao; }
    }

    public void AdicionarComentario(Comentario comentario)
    {
        _comentarios.Add(comentario);
    }

    public int ObterQuantidadeComentarios()
    {
        return _comentarios.Count;
    }

    public List<Comentario> ObterComentarios()
    {
        return _comentarios;
    }
}

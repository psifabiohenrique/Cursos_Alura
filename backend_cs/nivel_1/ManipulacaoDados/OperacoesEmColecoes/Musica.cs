using System;
using System.Collections.Generic;
using System.Text;

namespace OperacoesEmColecoes
{
    internal class Musica : IComparable<Musica>
    {
        public string Titulo { get; set; }
        public string Artista { get; set; }
        public int Duracao { get; set; }

        public int CompareTo(Musica? other)
        {
            if (other == null) return -1;
            if (other is Musica outraMusica) return this.Duracao.CompareTo(outraMusica.Duracao);
            return -1;
        }
        public override bool Equals(object? obj)
        {
            if (obj is null) return false;
            if (obj is Musica outraMusica) 
                return this.Titulo.Equals(outraMusica.Titulo) && 
                    this.Artista.Equals(outraMusica.Artista) && 
                    this.Duracao.Equals(outraMusica.Duracao);
            return false;
        }
        public override int GetHashCode()
        {
            return this.Titulo.GetHashCode() ^ this.Artista.GetHashCode() ^ this.Duracao.GetHashCode();
        }
    }

    internal class PorArtista : IComparer<Musica>
    {
        public int Compare(Musica? x, Musica? y)
        {
            if (x is null || y is null) return 0;
            if (x is null) return 1;
            if (y is null) return -1;
            return x.Artista.CompareTo(y.Artista);
        }
    }

    internal class PorTitulo : IComparer<Musica>
    {
        public int Compare(Musica? x, Musica? y)
        {
            if (x is null || y is null) return 0;
            if (x is null) return 1;
            if (y is null) return -1;
            return x.Titulo.CompareTo(y.Titulo);
        }
    }

    class PorContagem : IComparer<KeyValuePair<Musica, int>>
    {
        public int Compare(KeyValuePair<Musica, int> x, KeyValuePair<Musica, int> y)
        {
            return y.Value.CompareTo(x.Value);
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace OperacoesEmColecoes
{
    internal class Playlist : ICollection<Musica>
    {
        private HashSet<Musica> set = [];
        private List<Musica> lista = [];
        public string Nome { get; set; }

        public int Count => lista.Count;

        public bool IsReadOnly => false;

        public void Add(Musica musica)
        {
            if (set.Add(musica))
            {
                lista.Add(musica);
            }
        }

        public void Clear()
        {
            lista.Clear();
        }

        public bool Contains(Musica item)
        {
            return lista.Contains(item);
        }

        public Musica? ObterPeloTitulo(string titulo)
        {
            foreach (var musica in lista)
            {
                if (musica.Titulo == titulo) return musica;
            }
            return null;
        }
        public Musica? ObterAleatoria()
        {
            if (lista.Count == 0) return null;
            Random random = new Random();
            int indiceAleatorio = random.Next(0, lista.Count - 1);
            return lista[indiceAleatorio];
        }
        public void OrdenarPorDuracao()
        {
            lista.Sort();
        }
        public void OrdenaPorArtista()
        {
            lista.Sort(new PorArtista());
        }
        public void OrdenaPorTitulo()
        {
            lista.Sort(new PorTitulo());
        }
        public void CopyTo(Musica[] array, int arrayIndex)
        {
            lista.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Musica> GetEnumerator()
        {
            return lista.GetEnumerator();
        }

        public bool Remove(Musica item)
        {
            return lista.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

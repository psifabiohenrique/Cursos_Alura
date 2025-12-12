using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IntroAColecao
{
    // Com o yield return, não é necessário implementar uma classe com IEnumerator
    class DiasDaSemanaEnumarator : IEnumerator<string>
    {
        private int posicao = -1;
        private string[] diasDaSemana = { "Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado" };
        public string Current => diasDaSemana[posicao];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            posicao++;
            return posicao < diasDaSemana.Length;
        }

        public void Reset()
        {
            posicao = -1;
        }
    }
    internal class DiasDaSemana : IEnumerable<string>
    {
        

        public IEnumerator<string> GetEnumerator()
        {
            yield return "Domingo";
            yield return "Segunda";
            yield return "Terça";
            yield return "Quarta";
            yield return "Quinta";
            yield return "Sexta";
            yield return "Sábado";
            
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

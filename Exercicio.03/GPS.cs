using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Exercicio.Tres
{
    /// <summary>
    /// Aplicado conceito do algoritmo Busca em largura (Breadth - first search)
    /// </summary>
    public class GPS
    {
        public List<int> GpsFitSolution(string filePath)
        {
            var totalCasosTeste = 0;
            var totalEstradas = 0;
            var totalCidades = 0;
            var dados = new List<string>();
            var hashtable = new Hashtable();
            var cidades = new List<string>();
            var cidadeOrigem = string.Empty;
            var rotas = new List<Rota>();
            var viagens = new List<int>();


            foreach (string linha in File.ReadLines(filePath))
            {
                dados = linha.Trim().Split(' ').ToList();

                if (totalCasosTeste == 0)
                {
                    int.TryParse(dados.FirstOrDefault(), out totalCasosTeste);
                    continue;
                }

                if (dados.Count == 1 && totalCidades == 0 && int.TryParse(dados.FirstOrDefault(), out totalCidades))
                    continue;

                if (dados.Count == totalCidades && !cidades.Any())
                {
                    cidades.Clear();
                    cidades.AddRange(dados);

                    continue;
                }

                if (dados.Count == 1 && totalEstradas == 0 && int.TryParse(dados.FirstOrDefault(), out totalEstradas))
                    continue;

                if (cidadeOrigem != dados[0])
                {
                    if (!string.IsNullOrEmpty(cidadeOrigem))
                    {
                        hashtable.Add(cidadeOrigem, rotas);
                    }

                    cidadeOrigem = dados[0];
                    rotas = new List<Rota>();
                }

                if (totalEstradas <= 0)
                {
                    viagens.Add(PesquisaEmLargura(hashtable, dados[0].ToString(), dados[1].ToString()));
                    totalCidades = 0;
                    totalEstradas = 0;
                    cidades.Clear();
                    hashtable.Clear();

                    continue;
                }

                rotas.Add(new Rota(dados[0].ToString(), dados[1].ToString(), int.Parse(dados[2].ToString())));
                totalEstradas--;
            }

            if (totalCasosTeste != viagens.Count)
                throw new Exception("Total de casos de teste não estão em conformidade! Verifique.");

            return viagens;
        }

        private int PesquisaEmLargura(Hashtable hashtable, string origem, string destino)
        {
            var fila = new Queue();
            var verificados = new List<Rota>();

            Enfileirar(ref fila, hashtable[origem] as List<Rota>);

            while (fila.Count > 0)
            {
                var vertice = fila.Dequeue() as Rota;

                if (vertice.CidadeDestino.Equals(destino))
                    return verificados
                        .Where(x => x.CidadeOrigem == origem && x.CidadeDestino == vertice.CidadeOrigem)
                        .Sum(x => x.Tempo) + vertice.Tempo;

                if (verificados.Contains(vertice))
                    continue;

                Enfileirar(ref fila, hashtable[vertice.CidadeDestino] as List<Rota>);
                verificados.Add(vertice);
            }

            throw new Exception("Rota não localizada!");
        }

        private void Enfileirar(ref Queue fila, List<Rota> lista)
        {
            if (lista == null)
                return;

            foreach (var item in lista)
                fila.Enqueue(item);
        }
    }
}
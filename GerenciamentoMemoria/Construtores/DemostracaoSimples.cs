﻿using Construtores.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores
{
    public class DemostracaoSimples
    {

        public void InicializandoListasComSize()
        {
            var lista1 = GetData(size: 1);

            Console.WriteLine($"Tamanho da lista {lista1.Count}");

            var lista2 = GetData(size: 10);

            Console.WriteLine($"Tamanho da lista {lista2.Count}");


            var lista3 = GetData(size: 1000);

            Console.WriteLine($"Tamanho da lista {lista3.Count}");



            var lista4 = GetData(size: 10000);

            Console.WriteLine($"Tamanho da lista {lista4.Count}");



            var lista5 = GetData(size: 100000);

            Console.WriteLine($"Tamanho da lista {lista5.Count}");



            var lista6 = GetData(size: 1000000);

            Console.WriteLine($"Tamanho da lista {lista6.Count}");
           
        }


        public void InicializandoComContrutor()
        {
            var lista1 = GetDataForeach(size: 1);

            Console.WriteLine($"Tamanho da lista {lista1.Count}");

            var lista2 = GetDataForeach(size: 10);

            Console.WriteLine($"Tamanho da lista {lista2.Count}");


            var lista3 = GetDataForeach(size: 1000);

            Console.WriteLine($"Tamanho da lista {lista3.Count}");



            var lista4 = GetDataForeach(size: 10000);

            Console.WriteLine($"Tamanho da lista {lista4.Count}");



            var lista5 = GetDataForeach(size: 100000);

            Console.WriteLine($"Tamanho da lista {lista5.Count}");



            var lista6 = GetDataForeach(size: 1000000);

            Console.WriteLine($"Tamanho da lista {lista6.Count}");

        }

        List<PessoasEntity> GetData(int size)
        {


            var retorno = new List<PessoasEntity>(size);


            return retorno;
        }


        List<PessoasEntity> GetDataForeach(int size)
        {

            var retorno = new List<PessoasEntity>();

            for (int iterador = 0; iterador < size; iterador++)
            {

             // 200 MB
                var pessoa = new PessoasEntity();


                retorno.Add(pessoa);
            }



            return retorno;
        }
    }


}

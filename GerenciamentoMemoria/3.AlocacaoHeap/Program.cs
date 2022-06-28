


//Aqui tenho apenas uma instancia alocada na Heap

using System;
using _3.AlocacaoHeap;


Demostracao demo = new Demostracao();


//demo.Demo1();
//demo.Demo2();

var retorno = demo.Demo3();

demo.Demo3Parte1(retorno);

Console.ReadKey();
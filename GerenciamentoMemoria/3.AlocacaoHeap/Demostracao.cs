namespace _3.AlocacaoHeap
{
    public class Demostracao
    {

        public void Demo1()
        {
            for (int i = 0; i < 1; i++)
            {
                var f = new FooOne { A = 1 };
            }

            //Aqui tenho apenas uma instancia alocada na Heap
            for (int i = 0; i < 1; i++)
            {
                var f = new FooTwo { A = 1, B = 2 };
            }


            //Aqui tenho apenas uma instancia alocada na Heap
            for (int i = 0; i < 1; i++)
            {
                var f = new FooTree { A = 1, B = 2, C = 3 };
            }

            //Aqui tenho apenas uma instancia alocada na Heap
            for (int i = 0; i < 1; i++)
            {
                var f = new FooFour { A = 1, B = 2, Id = Guid.NewGuid() };
            }

            //Aqui tenho apenas uma instancia alocada na Heap
            for (int i = 0; i < 1; i++)
            {
                var f = new FooFourFive { A = Guid.Empty, B = Guid.Empty, C = Guid.Empty, Id = Guid.Empty };
            }

            //Aqui tenho apenas uma instancia alocada na Heap
            for (int i = 0; i < 1; i++)
            {
                var f = new FooFourFive { A = Guid.Empty, B = Guid.Empty, C = Guid.Empty, Id = Guid.Empty };
            }

            //Aqui tenho apenas uma instancia alocada na Heap
            for (int i = 0; i < 1; i++)
            {
                var f = new FooFourSix { A = Guid.NewGuid(), B = Guid.NewGuid(), C = Guid.NewGuid(), Id = Guid.NewGuid() };
            }
        }

        public void Demo2()
        {

            var lista = new List<FooOne>();


            for (int iterador = 0; iterador < 100; iterador++)
            {
                lista.Add(new FooOne { A = iterador });
            }
        }

        public List<FooOne> Demo3()
        {

            var lista = new List<FooOne>();


            for (int iterador = 0; iterador < 100; iterador++)
            {
                lista.Add(new FooOne { A = iterador });
            }

            return lista;
        }

        public List<FooOne> Demo3Parte1(List<FooOne> lista)
        {


            foreach (var item in lista)
            {

                item.A = item.A * 2;
            }

            return lista;
        }


        public List<FooSeven> DemoStringsEConstantes()
        {
            var lista = new List<FooSeven>();


            for (int iterador = 0; iterador < 1000; iterador++)
            {
                lista.Add(new FooSeven
                {
                    A = "Compra.OrdensComprasPagamentosAutorizados 1",
                    B = "Compra.OrdensComprasPagamentosAutorizados 2",
                    C = "Compra.OrdensComprasPagamentosAutorizados 3",
                    D = "Compra.OrdensComprasPagamentosAutorizados 4",


                });
            }

            return lista;
        }

        public List<FooSeven> DemoStringsEConstantesStringInter()
        {
            var lista = new List<FooSeven>();


            for (int iterador = 0; iterador < 1000; iterador++)
            {
                lista.Add(new FooSeven
                {
                    A = "Compra.OrdensComprasPagamentosAutorizados 1".Intern(),
                    B = "Compra.OrdensComprasPagamentosAutorizados 2".Intern(),
                    C = "Compra.OrdensComprasPagamentosAutorizados 3".Intern(),
                    D = "Compra.OrdensComprasPagamentosAutorizados 4".Intern(),


                });
            }

            return lista;
        }

    }



    public class FooOne
    {
        public int A { get; set; }


    }
    public class FooTwo
    {
        public int A { get; set; }

        public int B { get; set; }

    }

    public class FooTree
    {
        public int A { get; set; }

        public int B { get; set; }

        public int C { get; set; }

    }
    //Reference Type

    public class FooFour
    {

        public Guid Id { get; set; }

        public int A { get; set; }

        public int B { get; set; }

    }

    /// <summary>
    /// Value Type
    /// </summary>
    public class FooFourFive
    {

        public Guid A { get; set; }

        public Guid B { get; set; }

        public Guid C { get; set; }

        public Guid Id { get; set; }
    }
    public class FooFourSix
    {

        public Guid A { get; set; }

        public Guid B { get; set; }

        public Guid C { get; set; }

        public Guid Id { get; set; }



    }

    public class FooSeven
    {

        public string A { get; set; }

        public string B { get; set; }

        public string C { get; set; }

        public string D { get; set; }



    }

}


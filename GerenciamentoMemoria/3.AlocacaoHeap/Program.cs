// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Aqui tenho apenas uma instancia alocada na Heap
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
    var f = new FooTree { A = 1, B = 2, C =3 };
}

//Aqui tenho apenas uma instancia alocada na Heap
for (int i = 0; i < 1; i++)
{
    var f = new FooFour { A = 1, B = 2 , Id = Guid.NewGuid()};
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

public class FooFour
{

    public Guid Id { get; set; }

    public int A { get; set; }

    public int B { get; set; }

}
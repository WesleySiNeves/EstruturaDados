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
    var f = new FooFourStruct { A = Guid.Empty, B = Guid.Empty, C = Guid.Empty, Id = Guid.Empty };
}



public struct FooOne
{
    public int A { get; set; }


}
public struct FooTwo
{
    public int A { get; set; }

    public int B { get; set; }

}

public struct FooTree
{
    public int A { get; set; }

    public int B { get; set; }

    public int C { get; set; }

}
//Reference Type

public struct FooFour
{

    public Guid Id { get; set; }

    public int A { get; set; }

    public int B { get; set; }

}

/// <summary>
/// Value Type
/// </summary>
public struct FooFourStruct
{

    public Guid A { get; set; }

    public Guid B { get; set; }

    public Guid C { get; set; }

    public Guid Id { get; set; }

   

}


int ladoA = 10;
int ladoB = 20;


int areaQuadrado = AreaQuadrado(ladoA);

Console.WriteLine($"Area de  sem ref {areaQuadrado}");


///Values Types
int areaQuadrado2 = AreaQuadrado2(ref ladoA);

Console.WriteLine($"Area quadrado ref {areaQuadrado2}");

/// é criada uma nova variavel na Stak com 4 bytes para alocar (valor)
int AreaQuadrado(int valor)
{
    valor = valor * valor;
    return valor;

}

int AreaQuadrado2(ref int valor)
{
    valor = valor * valor;
    return valor;

}
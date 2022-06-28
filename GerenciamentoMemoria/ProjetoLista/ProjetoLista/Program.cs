
using System.Collections;
using ProjetoLista;


List<Cliente> list = new List<Cliente>();


var novoCliente = new Cliente();
novoCliente.Id = 1;
novoCliente.Nome = "Wendel";

var novoCliente1 = new Cliente();
novoCliente1.Id = 2;
novoCliente1.Nome = "Wendel 2";
Inserir(novoCliente);
Inserir(novoCliente1);
BuscarCliente(1);
BuscarCliente(2);
ExcluirCliente(2);
BuscarCliente(2);


var novoClienteAlterado = new Cliente();
novoClienteAlterado.Id = 1;
novoClienteAlterado.Nome = "Wendel Alterado";
AlterarCliente(novoClienteAlterado);
BuscarCliente(1);

Console.ReadKey();


void ExcluirCliente(int id)
{
    var clienteARemover = list.FirstOrDefault(s => s.Id == id);


    if (clienteARemover == null)
    {
        Console.WriteLine($"O Cliente com o id {id} não existe");
    }
    else
    {
        list.Remove(clienteARemover);
    }

    
}


void BuscarCliente(int id)
{
    var cliente = list.FirstOrDefault(x => x.Id == id);

    if (cliente == null)
    {
        Console.WriteLine($"O Cliente com o id {id} não existe");
    }
    else
    {
        Console.WriteLine($"Cliente Id: {cliente.Id} Cliente Nome {cliente.Nome}");
    }
}


void OrdernarPorNome()
{
    list = list.OrderBy(x => x.Nome).ToList();

    foreach (var cliente in list)
    {
        Console.WriteLine($"Cliente Id: {cliente.Id} Cliente Nome {cliente.Nome}");
    }
}



void Inserir(Cliente cliente)
{

    if (list.Exists(x=>x.Id == cliente.Id))
    {
        Console.WriteLine($"O Cliente com o id já existe na lista");
    }
    else
    {
        list.Add(cliente);
    }
    



}



void AlterarCliente(Cliente cliente)
{

    var clienteAlterar = list.FindIndex(c=>c.Id == cliente.Id);

    if (clienteAlterar == -1)
    {
        Console.WriteLine($"O Cliente com o id {cliente.Id} não existe");
    }
    else
    {
        list[clienteAlterar].Nome = cliente.Nome;
    }
}





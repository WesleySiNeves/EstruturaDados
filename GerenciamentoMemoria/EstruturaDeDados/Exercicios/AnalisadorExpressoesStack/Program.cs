namespace AnalisadorExpressao
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Stack<double> numeros = new Stack<double>();
            Stack<char> operadores = new Stack<char>();
            String s;
            double resp = 0;
            Console.Write("Expressao: ");
            s = Console.ReadLine();
            int n = s.Length;
            if (testaExpressao(s))
            {
                for (int i = 0; i < n; i++)
                {
                    if (s[i] == '(')
                    {
                        continue;
                    }
                    if (StrChr("0123456789", s[i]))
                    {
                        char ch = s[i];
                        double t = (double)ch - 48;
                        numeros.Push(t);
                        exibePilhaDouble(numeros);
                        exibePilhaChar(operadores);
                        Console.WriteLine();
                    }
                    else
                    {
                        if (StrChr("+-*/", s[i]))
                        {
                            char op = s[i];
                            operadores.Push(op);
                        }
                    }
                    if (s[i] == ')')
                    {
                        Object nodo = numeros.Pop();
                        String st = nodo.ToString();
                        double y = Convert.ToDouble(st);
                        nodo = numeros.Pop();
                        st = nodo.ToString();
                        double x = Convert.ToDouble(st);
                        nodo = operadores.Pop();
                        String temp = nodo.ToString();
                        char op = temp[0];
                        resp = calculaOperacao(x, y, op);
                        numeros.Push(resp);
                        exibePilhaDouble(numeros);
                        exibePilhaChar(operadores);
                    }
                }
                Console.WriteLine();
                if (operadores.Count == 0)
                {
                    Object nodo = numeros.Pop();
                    String st = nodo.ToString();
                    resp = Convert.ToDouble(st);
                }
                else
                {
                    resp = 0;
                    while (operadores.Count != 0)
                    {

                        Object nodo = numeros.Pop();
                        String st = nodo.ToString();
                        double y = Convert.ToDouble(st);
                        nodo = numeros.Pop();
                        st = nodo.ToString();
                        double x = Convert.ToDouble(st);
                        nodo = operadores.Pop();
                        String temp = nodo.ToString();
                        char op = temp[0];
                        resp = calculaOperacao(x, y, op);
                        numeros.Push(resp);
                        exibePilhaDouble(numeros);
                        exibePilhaChar(operadores);
                    }
                }
                Console.WriteLine("Resposta: " + resp);
            }
            else
            {
                Console.WriteLine("Erro: Expressao Invalida");
            }
        }
        // ---------------------------------------- calculaOperacao
        static double calculaOperacao(double x, double y, char op)
        {
            double resp = 0;
            switch (op)
            {
                case '+':
                    resp = x + y;
                    break;
                case '-':
                    resp = x - y;
                    break;
                case '*':
                    resp = x * y;
                    break;
                case '/':
                    if (y != 0)
                    {
                        resp = x / y;
                    }
                    else
                    {
                        Console.WriteLine("Erro Fatal: Divisão por Zero");
                        Environment.Exit(0);
                    }
                    break;
            }
            return (resp);
        }
        // ---------------------------------------- testaExpressao
        static bool testaExpressao(String exp)
        {
            int abre = 0, fecha = 0;
            for (int i = 0; i < exp.Length; i++)
            {
                if (exp[i] == '(')
                {
                    abre++;
                }
                if (exp[i] == ')')
                {
                    fecha++;
                }
            }
            if (abre == fecha)
            {
                return (true);
            }
            else
                return (false);
        }
        // ---------------------------------------- exibePilhaInt
        static void exibePilhaDouble(Stack<double> pilha)
        {

            double[] nodo = pilha.ToArray();
            Console.Write("Pilha: ");
            for (int i = 0; i < nodo.Length; i++)
            {
                Console.Write(nodo[i] + " ");
            }
            Console.WriteLine();
        }
        // ---------------------------------------- exibePilhaChar
        static void exibePilhaChar(Stack<char> pilha)
        {
            char[] nodo = pilha.ToArray();
            Console.Write("Pilha: ");
            for (int i = 0; i < nodo.Length; i++)
            {
                Console.Write(nodo[i] + " ");
            }
            Console.WriteLine();
        }
        // --------------------------------------- StrChr
        static bool StrChr(string s, char ch)
        {
            int n = s.Length;
            for (int i = 0; i < n; i++)
            {
                if (s[i] == ch)
                {
                    return (true);
                }
            }
            return (false);
        }
    }
}
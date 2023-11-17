//QUESTÃO 1 
using System;

class Circulo
{
    // Atributo para armazenar o raio
    private double raio;

    // Propriedade para acessar e definir o valor do raio
    public double Raio
    {
        get { return raio; }
        set
        {
            if (value >= 0)
            {
                raio = value;
            }
            else
            {
                Console.WriteLine("O raio não pode ser negativo. Definindo o raio como zero.");
                raio = 0;
            }
        }
    }

    // Método para calcular a área do círculo
    public double CalcularArea()
    {
        return Math.PI * Math.Pow(raio, 2);
    }

    // Método para calcular o perímetro do círculo (ou circunferência)
    public double CalcularPerimetro()
    {
        return 2 * Math.PI * raio;
    }
}

class Program
{
    static void Main()
    {
        // Criando uma instância da classe Círculo
        Circulo meuCirculo = new Circulo();

        // Definindo o raio do círculo
        Console.Write("Digite o raio do círculo: ");
        string inputRaio = Console.ReadLine();

        // Convertendo a entrada para um número e definindo o raio
        if (double.TryParse(inputRaio, out double raio))
        {
            meuCirculo.Raio = raio;

            // Calculando e exibindo a área e o perímetro do círculo
            Console.WriteLine($"Área do círculo: {meuCirculo.CalcularArea():F2}");
            Console.WriteLine($"Perímetro do círculo: {meuCirculo.CalcularPerimetro():F2}");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Certifique-se de digitar um número válido para o raio.");
        }
    }
} 
/*
//QUESTÂO 2
using System;

class Retangulo
{
    // Atributos para armazenar largura e altura
    private double largura;
    private double altura;

    // Propriedades para acessar e definir os valores de largura e altura
    public double Largura
    {
        get { return largura; }
        set
        {
            if (value >= 0)
            {
                largura = value;
            }
            else
            {
                Console.WriteLine("A largura não pode ser negativa. Definindo a largura como zero.");
                largura = 0;
            }
        }
    }

    public double Altura
    {
        get { return altura; }
        set
        {
            if (value >= 0)
            {
                altura = value;
            }
            else
            {
                Console.WriteLine("A altura não pode ser negativa. Definindo a altura como zero.");
                altura = 0;
            }
        }
    }

    // Método para calcular a área do retângulo
    public double CalcularArea()
    {
        return largura * altura;
    }

    // Método para calcular o perímetro do retângulo
    public double CalcularPerimetro()
    {
        return 2 * (largura + altura);
    }
}

class Program
{
    static void Main()
    {
        // Criando uma instância da classe Retangulo
        Retangulo meuRetangulo = new Retangulo();

        // Definindo a largura e altura do retângulo
        Console.Write("Digite a largura do retângulo: ");
        string inputLargura = Console.ReadLine();

        Console.Write("Digite a altura do retângulo: ");
        string inputAltura = Console.ReadLine();

        // Convertendo as entradas para números e definindo a largura e altura
        if (double.TryParse(inputLargura, out double largura) && double.TryParse(inputAltura, out double altura))
        {
            meuRetangulo.Largura = largura;
            meuRetangulo.Altura = altura;

            // Calculando e exibindo a área e o perímetro do retângulo
            Console.WriteLine($"Área do retângulo: {meuRetangulo.CalcularArea():F2}");
            Console.WriteLine($"Perímetro do retângulo: {meuRetangulo.CalcularPerimetro():F2}");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Certifique-se de digitar números válidos para largura e altura.");
        }
    }
}
QUESTÃO 3
using System;

class Aluno
{
    // Atributos para armazenar nome, matrícula e notas
    private string nome;
    private int matricula;
    private double[] notas;

    // Propriedades para acessar e definir os valores de nome, matrícula e notas
    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public int Matricula
    {
        get { return matricula; }
        set { matricula = value; }
    }

    // Construtor para inicializar a matriz de notas
    public Aluno(int quantidadeNotas)
    {
        notas = new double[quantidadeNotas];
    }

    // Método para definir as notas do aluno
    public void DefinirNotas()
    {
        for (int i = 0; i < notas.Length; i++)
        {
            Console.Write($"Digite a nota {i + 1}: ");
            string inputNota = Console.ReadLine();

            if (double.TryParse(inputNota, out double nota))
            {
                notas[i] = nota;
            }
            else
            {
                Console.WriteLine("Entrada inválida. Digite um número válido para a nota.");
                i--; // Decrementa i para que a iteração seja repetida para a mesma nota.
            }
        }
    }

    // Método para calcular a média das notas
    public double CalcularMedia()
    {
        if (notas.Length == 0)
        {
            return 0; // Retorna 0 se não houver notas para evitar divisão por zero.
        }

        double soma = 0;
        foreach (var nota in notas)
        {
            soma += nota;
        }

        return soma / notas.Length;
    }

    // Método para verificar a situação do aluno
    public string VerificarSituacao()
    {
        double media = CalcularMedia();

        if (media >= 7.0)
        {
            return "Aprovado";
        }
        else
        {
            return "Reprovado";
        }
    }
}

class Program
{
    static void Main()
    {
        // Criando uma instância da classe Aluno
        Aluno meuAluno = new Aluno(3); // Supondo 3 notas para o exemplo

        // Definindo o nome e a matrícula do aluno
        Console.Write("Digite o nome do aluno: ");
        meuAluno.Nome = Console.ReadLine();

        Console.Write("Digite a matrícula do aluno: ");
        string inputMatricula = Console.ReadLine();

        if (int.TryParse(inputMatricula, out int matricula))
        {
            meuAluno.Matricula = matricula;

            // Definindo as notas do aluno
            meuAluno.DefinirNotas();

            // Exibindo a média e a situação do aluno
            Console.WriteLine($"Média do aluno {meuAluno.Nome}: {meuAluno.CalcularMedia():F2}");
            Console.WriteLine($"Situação do aluno {meuAluno.Nome}: {meuAluno.VerificarSituacao()}");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Certifique-se de digitar um número válido para a matrícula.");
        }
    }
}
//QUESTÂO 4
using System;

class CalculadoraFatorial
{
    // Atributo para armazenar o número
    private int numero;

    // Propriedade para acessar e definir o valor do número
    public int Numero
    {
        get { return numero; }
        set
        {
            if (value >= 0)
            {
                numero = value;
            }
            else
            {
                Console.WriteLine("O número não pode ser negativo. Definindo o número como zero.");
                numero = 0;
            }
        }
    }

    // Método para calcular o fatorial do número
    public long CalcularFatorial()
    {
        if (numero == 0 || numero == 1)
        {
            return 1; // O fatorial de 0 e 1 é 1
        }

        long resultado = 1;
        for (int i = 2; i <= numero; i++)
        {
            resultado *= i;
        }

        return resultado;
    }
}

class Program
{
    static void Main()
    {
        // Criando uma instância da classe CalculadoraFatorial
        CalculadoraFatorial calculadora = new CalculadoraFatorial();

        // Definindo o número para calcular o fatorial
        Console.Write("Digite um número para calcular o fatorial: ");
        string inputNumero = Console.ReadLine();

        // Convertendo a entrada para um número e definindo o número
        if (int.TryParse(inputNumero, out int numero))
        {
            calculadora.Numero = numero;

            // Calculando e exibindo o fatorial
            Console.WriteLine($"O fatorial de {numero} é: {calculadora.CalcularFatorial()}");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Certifique-se de digitar um número inteiro válido.");
        }
    }
}

//QUESTÃO 5
using System;

class CalculadoraFatorial
{
    // Atributo para armazenar o número
    private int numero;

    // Propriedade para acessar e definir o valor do número
    public int Numero
    {
        get { return numero; }
        set
        {
            if (value >= 0)
            {
                numero = value;
            }
            else
            {
                Console.WriteLine("O número não pode ser negativo. Definindo o número como zero.");
                numero = 0;
            }
        }
    }

    // Método para calcular o fatorial do número
    public long CalcularFatorial()
    {
        if (numero == 0 || numero == 1)
        {
            return 1; // O fatorial de 0 e 1 é 1
        }

        long resultado = 1;
        for (int i = 2; i <= numero; i++)
        {
            resultado *= i;
        }

        return resultado;
    }
}

class Program
{
    static void Main()
    {
        // Criando uma instância da classe CalculadoraFatorial
        CalculadoraFatorial calculadora = new CalculadoraFatorial();

        // Definindo o número para calcular o fatorial
        Console.Write("Digite um número para calcular o fatorial: ");
        string inputNumero = Console.ReadLine();

        // Convertendo a entrada para um número e definindo o número
        if (int.TryParse(inputNumero, out int numero))
        {
            calculadora.Numero = numero;

            // Calculando e exibindo o fatorial
            Console.WriteLine($"O fatorial de {numero} é: {calculadora.CalcularFatorial()}");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Certifique-se de digitar um número inteiro válido.");
        }
    }
}
*/
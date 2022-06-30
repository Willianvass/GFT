using System;

namespace IMC
{
    public class Calculo_IMC
    {
        static void Main(string[] args)
        {
            int nascimento, idade;
            double IMC, altura, peso;
            string sair, opcoes;
            System.Console.Write("Qual ano de nascimento: ");
            nascimento = Int32.Parse(Console.ReadLine());
            System.Console.Write("Qual sua altura: ");
            altura = double.Parse(Console.ReadLine());
            System.Console.Write("Qual seu peso: ");
            peso = double.Parse(Console.ReadLine()); 

            idade = 2022 - nascimento;
            IMC = peso / (altura * altura);

            do
            {  
                System.Console.WriteLine("Digite a opção desejada: \n1 - Idade; \n2 - IMC; \n3 - Sair!");
                opcoes = Console.ReadLine();

                switch (opcoes)
                {
                    case "1":
                        System.Console.WriteLine("Sua idade é: " + idade);
                        break;
                    case "2":
                        System.Console.WriteLine(("Seu IMC é: " + IMC.ToString("0.00")));
                        break;
                    case "3":
                        System.Console.WriteLine("Até logo");
                        break;
                }
            } while (opcoes != "3");
        }
    }
}

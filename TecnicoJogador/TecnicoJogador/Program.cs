using System;

namespace PrjTecnicoJogador
{
    class Program
    {
        static void Main(string[] args)
        {
            // declarar as variaveis
            double salarioBase;
            double bonus;
            int horasExtras;
            int anoAtual = DateTime.Now.Year;
            // instanciar a classe Tecnico - criar os objetos
            Tecnico tecnico1 = new Tecnico();
            Tecnico tecnico2 = new Tecnico("Rogerio Ceni",1980,1.95,110,"ceni",8,2);
            try
            {
                tecnico1.LerDados();
                Console.Write("Salario Base R$: ");
                salarioBase = Convert.ToDouble(Console.ReadLine());
                Console.Write("Qde de horas extras: ");
                horasExtras = Convert.ToInt32(Console.ReadLine());
                tecnico1.CalcularIdade(anoAtual);
                tecnico1.CalcularSalario(salarioBase, horasExtras);

                Console.Write("Salario Base R$: ");
                salarioBase = Convert.ToDouble(Console.ReadLine());
                Console.Write("Qde de horas extras: ");
                horasExtras = Convert.ToInt32(Console.ReadLine());
                tecnico2.CalcularIdade(anoAtual);
                tecnico2.CalcularSalario(salarioBase, horasExtras);

                Console.Clear(); //limpar a tela
                Console.WriteLine(tecnico1.MostrarDados());
                Console.WriteLine(tecnico2.MostrarDados());
            }
            catch(Exception ex)
            {
                Console.WriteLine("Erro" + ex);
            }
            //instanciar a classe Tecnico - criar os objetos
            Jogador jogador1 = new Jogador();
            Jogador jogador2 = new Jogador("Menino Ney", 1992, 1.75, 68, "ney", "atacante", 1000);
            try
            {
                jogador1.LerDados();
                Console.Write("Salario Base R$: ");
                salarioBase = Convert.ToDouble(Console.ReadLine());
                Console.Write("Bonus do jogador: ");
                bonus = Convert.ToDouble(Console.ReadLine());
                jogador1.CalcularIdade(anoAtual);
                jogador1.CalcularSalario(salarioBase,bonus);

                Console.Write("Salario Base R$: ");
                salarioBase = Convert.ToDouble(Console.ReadLine());
                Console.Write("Bonus do jogador: ");
                bonus = Convert.ToDouble(Console.ReadLine());
                jogador2.CalcularIdade(anoAtual);
                jogador2.CalcularSalario(salarioBase, bonus);

                Console.WriteLine(jogador1.MostrarDados());
                Console.WriteLine(jogador2.MostrarDados());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro" + ex);
            }
        }
    }
}

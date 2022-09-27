using System;
using System.Collections.Generic;
using System.Text;

namespace PrjTecnicoJogador
{
    class Jogador : Pessoa
    {
        // declaração de atributos
        private string nomeCami;
        private string posiJoga;
        private int golCarre;
        // construtor sem parâmetro
        public Jogador() : base() // chamar o construtor sem parâmetro da classe Pessoa
        {
            nomeCami = null;
            posiJoga = null;
            golCarre = 0;
        }
        // construtor com parâmetro - (overload)
        public Jogador(string nome, int anoNasc, double altura, double peso,
            string nomeCami, string posiJoga, int golCarre) :
            base(nome, anoNasc, altura, peso) // chamar o construtor com parâmetro da classe Pessoa
        {
            this.nomeCami = nomeCami;
            this.posiJoga = posiJoga;
            this.golCarre = golCarre;
        }
        //propriedades
        public string NomeCami
        {
            get { return nomeCami; }
            set { nomeCami = value; }
        }
        public string PosiJoga
        {
            get { return posiJoga; }
            set { posiJoga = value; }
        }
        public int GolCarre
        {
            get { return golCarre; }
            set { golCarre = value; }
        }
        //metodos sobrescritos - (override)
        public override void LerDados()
        {
            base.LerDados();
            try
            {
                Console.Write("Nome da camisa: ");
                NomeCami = Console.ReadLine();
                Console.Write("Posicao que joga: ");
                PosiJoga = Console.ReadLine();
                Console.Write("Gols na carreira: ");
                GolCarre = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro de cadastros" + ex);
            }
        }
        public override string MostrarDados()
        {
            return base.MostrarDados() +
                "\n Nome da camisa: " + NomeCami +
                "\n posicao que joga: " + PosiJoga +
                "\n Gols na carreira: " + GolCarre;
        }
        public void CalcularSalario(double salarioBase, double bonus)
        {
            Salario = salarioBase + 5 * bonus;
        }
    }
}

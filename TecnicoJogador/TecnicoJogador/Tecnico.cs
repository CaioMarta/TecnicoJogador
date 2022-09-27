using System;
using System.Collections.Generic;
using System.Text;

namespace PrjTecnicoJogador
{
    class Tecnico : Pessoa
    {
        //declaração dos atributos
        private string apelido;
        private int anoExpe;
        private int tempCont;

        //construtor sem parâmetro
        public Tecnico() : base() //chamar o construtor sem parâmetro da classe Pessoa
        {
            apelido = null;
            anoExpe = 0;
            tempCont = 0;
        }
        //construtor com parametro-(overload)
        public Tecnico(string nome, int anoNasc, double altura, double peso, 
            string apelido, int anoExpe, int tempCont) : 
            base(nome, anoNasc, altura,peso) //chamar o construtor com parâmetro da classe Pessoa
        {
            this.apelido = apelido;
            this.anoExpe = anoExpe;
            this.tempCont = tempCont;
        }
        //propriedades
        public string Apelido
        {
            get { return apelido; }
            set { apelido = value; }
        }
        public int AnoExpe
        {
            get { return anoExpe; }
            set { anoExpe = value; }
        }
        public int TempCont
        {
            get { return tempCont; }
            set { tempCont = value; }
        }
        //metodos sobrescritos(override)
        public override void LerDados()
        {
            base.LerDados();
            try
            {
                Console.Write("Apelido: ");
                Apelido = Console.ReadLine();
                Console.Write("Ano de experiencia: ");
                AnoExpe = Convert.ToInt32(Console.ReadLine());
                Console.Write("Tempo de contrato: ");
                TempCont = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine("Erro de cadastros" + ex);
            }
        }
        public override string MostrarDados()
        {
            return base.MostrarDados()+
                "\n Apelido: "+ Apelido+
                "\n Anos de experiencia: " + AnoExpe+ " anos" +
                "\n Tempo de contrato: " + TempCont+ " anos";
        }
        //metodo da classe
        public void CalcularSalario(double salarioBase, int horasExtras)
        {
            Salario = salarioBase + 350.00 * horasExtras;
        }
    }

}

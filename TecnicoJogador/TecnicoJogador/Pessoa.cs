using System;
using System.Collections.Generic;
using System.Text;

namespace PrjTecnicoJogador
{
    class Pessoa
    {
        //declaração de atributos
        private string nome;
        private int anoNasc;
        private int idade;
        private double altura;
        private double peso;
        protected double salario;

        //construtor sem parametro
        public Pessoa()
        {
            nome = null;
            anoNasc = 0;
            idade = 0;
            altura = 0;
            peso = 0;
            salario = 0;
        }
        //construtor com parametro sobrecarga(overload)
        public Pessoa(string nome, int anoNasc, double altura, double peso)
        {
            this.nome = nome;
            this.anoNasc = anoNasc;
            this.altura = altura;
            this.peso = peso;
        }
        //propriedades
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public int AnoNasc
        {
            get { return anoNasc; }
            set { anoNasc = value; }
        }
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }
        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }
        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        //metodos
        public virtual void LerDados()
        {
            string msg = " ";
            try
            {
                Console.WriteLine("Nome: ");
                nome = Console.ReadLine();
                Console.WriteLine("Ano de nascimento: ");
                anoNasc = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Peso: ");
                peso = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Altura: ");
                altura = Convert.ToDouble(Console.ReadLine());
                msg = "Dados cadastrados com sucesso!";
            }
            catch(Exception ex)
            {
                msg = "Erro no cadastro" + ex;
            }
            finally
            {
                Console.WriteLine(msg);
            }
        }

        public virtual string MostrarDados()
        {
            return "\n\n Dados das Pessoas " +
                "\n Nome: " + Nome +
                "\n Ano de nascimento: " + AnoNasc +
                "\n Idade: " + Idade +
                "\n Peso: " + Peso + "kg" +
                "\n Altura: " + Altura + "m" +
                "\n Salario R$: " + Salario;
        }
        public void CalcularIdade(int anoAtual)
        {
            Idade = anoAtual - AnoNasc;
        }
    }
}

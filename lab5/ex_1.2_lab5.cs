using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace lab_5._1_ex12
{
    class Menu
    {

        static void Main(string[] args)
        {
            const int MAXCONTRIBUINTES = 100; // n�mero m�ximo de contas suportado
            Contribuinte[] lst = new Contribuinte[MAXCONTRIBUINTES]; //vetor de contribuintes
            PFisica[] ctbfisica = new PFisica[MAXCONTRIBUINTES];
            PJuridica[] ctbjuricida = new PJuridica[MAXCONTRIBUINTES];
            string[] lstCont = new string[MAXCONTRIBUINTES];
            int j = 0, k = 0, h = 0, b = 0;
            string opcao, nomeArq, linha;

            Console.WriteLine("\t\tPONTIFICIA UNIVERSIDADE CATOLICA DE MINAS GERAIS");
            Console.WriteLine("\t\t\t\tSistemas De Informa��o");
            Console.WriteLine("\t\t\tAtividade 1.2 - Ex12_Lab1_s117p");
            Console.WriteLine("\t\tMatr�cula: 478443 - Nome: Alaene Rufino de Sousa");
            Console.WriteLine("\t\tMatr�cula: 573831 - Nome: Alessandra Faria Abreu");
            Console.WriteLine("\t\tMatr�cula: 421769 - Nome: Gustavo de Paula Ferreira");
            Console.WriteLine("\t\tMatr�cula: 578919 - Nome: Igor Santana");
            Console.WriteLine("\t\tMatr�cula: 574116 - Nome: Victor de Souza Rezende");
            Console.WriteLine("\t\t--------------------------------------------------");
            Console.WriteLine("Menu");
            Console.WriteLine("1. Incluir um contribuinte.");
            Console.WriteLine("2. Excluir um contribuinte.");
            Console.WriteLine("3. Exibir os dados de um contribuinte: CPF/CNPJ, nome, endere�o e salario/faturamento");
            Console.WriteLine("4. Calcular e exibir o imposto a ser pago por um contribuinte.");
            Console.WriteLine("5. Imprimir uma rela��o dos contribuintes Pessoa F�sica cadastrados, mostrando os dados:CPF, nome e endere�o.");
            Console.WriteLine("6. Imprimir uma rela��o dos contribuintes Pessoa Jur�dica cadastrados, mostrando os dados: CNPJ, nome e endere�o.");
            Console.WriteLine("7. Sair do programa.");
            opcao = Console.ReadLine();
            Console.Clear();

            while (opcao != "7")
            {
                switch (opcao)
                {
                    case "1":

                        Console.WriteLine("Digite o nome do contrinuite");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Digite o Endere�o do contrinuite");
                        string endere�o = Console.ReadLine();
                        Console.WriteLine("O contribuite � pessoa fisica(1) ou juridica (2)?");
                        string op2 = Console.ReadLine();
                        switch (op2)
                        {
                            case "1":
                                Console.WriteLine("pessoa fisica");
                                Console.WriteLine("qual o valor do salario do contribuinte");
                                double salario = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("qual o numero do cpf  do contribuinte");
                                string cpf = Console.ReadLine();
                                ctbfisica[k] = new PFisica(nome, endere�o, salario, cpf);
                                lstCont[b] = "pf";
                                lstCont[b++] = nome;
                                lstCont[b++] = endere�o;
                                lstCont[b++] = Convert.ToString(salario);
                                lstCont[b++] = cpf;
                                b++;
                                k++;
                                break;

                            case "2":
                                Console.WriteLine("pessoa juridica");
                                Console.WriteLine("qual o valor do faturamento do contribuinte");
                                double faturamento = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("qual o numero do cnpj do contribuinte");
                                string cnpj = Console.ReadLine();
                                ctbjuricida[h] = new PJuridica(nome, endere�o, faturamento, cnpj);
                                lstCont[b] = "pj";
                                lstCont[b++] = nome;
                                lstCont[b++] = endere�o;
                                lstCont[b++] = Convert.ToString(faturamento);
                                lstCont[b++] = cnpj;
                                b++;
                                h++;

                                break;
                        }
                        break;
                    case "2":
                        Console.WriteLine("PF(1) ou PJ (2) ?");
                        string op3 = Console.ReadLine();
                        switch (op3)
                        {
                            case "1":
                                Console.WriteLine("Dite o Nome ");
                                string nome3 = Console.ReadLine();
                                for (int y = 0; y < lst.Length; y++)
                                {
                                    if (ctbfisica[y].getNome() == nome3)
                                    {
                                        ctbfisica[y] = new PFisica(null, null, 0, null);
                                    }
                                }
                                break;
                            case "2":
                                Console.WriteLine("Dite o Nome ");
                                string nome4 = Console.ReadLine();
                                for (int y = 0; y < lst.Length; y++)
                                {
                                    if (ctbjuricida[y].getNome() == nome4)
                                    {
                                        ctbjuricida[y] = new PJuridica(null, null, 0, null);
                                    }
                                }
                                break;
                        }
                        break;
                    case "3":
                        Console.WriteLine("PF(1) ou PJ (2) ?");
                        string op4 = Console.ReadLine();
                        switch (op4)
                        {
                            case "1":
                                Console.WriteLine("Dite o Nome ");
                                string nome5 = Console.ReadLine();
                                for (int o = 0; o < ctbfisica.Length; o++)
                                {

                                    if (ctbfisica[o].getNome() == nome5)
                                    {
                                        Console.WriteLine(ctbfisica[o].getNome() + " " + ctbfisica[o].getCpf() + " " + ctbfisica[o].getEnd() + " " + ctbfisica[o].getSal());
                                    }
                                }
                                break;
                            case "2":
                                Console.WriteLine("Dite o Nome ");
                                string nome6 = Console.ReadLine();
                                for (int o = 0; o < ctbjuricida.Length; o++)
                                {

                                    if (ctbjuricida[o].getNome() == nome6)
                                    {
                                        Console.WriteLine(ctbjuricida[o].getNome() + " " + ctbjuricida[o].getCnpj() + " " + ctbjuricida[o].getEnd() + " " + ctbjuricida[o].getFat());
                                    }
                                }
                                break;
                        }
                        break;
                    case "4":
                        Console.WriteLine("PF(1) ou PJ (2) ?");
                        string op5 = Console.ReadLine();
                        switch (op5)
                        {
                            case "1":
                                Console.WriteLine("Dite o Nome ");
                                string nome5 = Console.ReadLine();
                                for (int o = 0; o < ctbfisica.Length; o++)
                                {

                                    if (ctbfisica[o].getNome() == nome5)
                                    {
                                        Console.WriteLine(ctbfisica[o].calcImposto());
                                    }
                                }
                                break;
                            case "2":
                                Console.WriteLine("Dite o Nome ");
                                string nome6 = Console.ReadLine();
                                for (int o = 0; o < ctbjuricida.Length; o++)
                                {

                                    if (ctbjuricida[o].getNome() == nome6)
                                    {
                                        Console.WriteLine(ctbjuricida[o].getFat());
                                    }
                                }
                                break;
                        }
                        break;
                    case "5":

                        for (int o = 0; o < ctbfisica.Length; o++)
                        {
                            Console.WriteLine(ctbfisica[o].getCpf() + " " + ctbfisica[o].getNome() + " " + ctbfisica[o].getEnd());

                        }
                        break;
                    case "6":

                        for (int p = 0; p < ctbjuricida.Length; p++)
                        {
                            Console.WriteLine(ctbjuricida[p].getCnpj() + " " + ctbjuricida[p].getNome() + " " + ctbjuricida[p].getEnd());

                        }
                        break;

                }
                Console.WriteLine("Alessandra Faria 573831");
                Console.WriteLine("Menu");
                Console.WriteLine("1. Incluir um contribuinte.");
                Console.WriteLine("2. Excluir um contribuinte.");
                Console.WriteLine("3. Exibir os dados de um contribuinte: CPF/CNPJ, nome, endere�o e salario/faturamento");
                Console.WriteLine("4. Calcular e exibir o imposto a ser pago por um contribuinte.");
                Console.WriteLine("5. Imprimir uma rela��o dos contribuintes Pessoa F�sica cadastrados, mostrando os dados:CPF, nome e endere�o.");
                Console.WriteLine("6. Imprimir uma rela��o dos contribuintes Pessoa Jur�dica cadastrados, mostrando os dados: CNPJ, nome e endere�o.");
                Console.WriteLine("7. Sair do programa.");
                opcao = Console.ReadLine();
                Console.Clear();
            }
            Console.WriteLine("digite o nome do arquivo para salvar os dados da opera��o");
            nomeArq = Console.ReadLine();
            // nomeArq = "C:/Users/Marcos/Desktop/poo/lab5/teste.txt";
            FileInfo fi = new FileInfo(nomeArq);
            StreamWriter saida = new StreamWriter(nomeArq); //abrir o arquivo para Escrita
            for (int s = 0; s < lstCont.Length; s++)
            {
                saida.WriteLine(lstCont[s]);
            }
            saida.Close();
        }

    }

    public abstract class Contribuinte
    {
        protected string nome;
        protected string endereco;
        public string getNome()
        {
            return nome;
        }
        public string getEnd()
        {
            return endereco;
        }
        abstract public double calcImposto();

    }
    public class PFisica : Contribuinte
    {
        protected String cpf;
        protected double salario;
        public PFisica(String n, string end, double sal, String c)
        {
            cpf = c;
            salario = sal;
            base.nome = n;
            base.endereco = end;
        }
        public string getCpf()
        {
            return cpf;
        }
        public double getSal()
        {
            return salario;
        }
        public override double calcImposto()
        {
            double percentual = 0;
            if ((salario > 0) && (salario <= 1400))
            {
                percentual = 0;
            }
            else if ((salario > 1400) && (salario <= 2100))
            {
                percentual = (salario * 0.1) - 100;
            }
            else if ((salario > 2100) && (salario <= 2800))
            {
                percentual = (salario * 0.15) - 270;
            }
            else if ((salario > 2800) && (salario <= 3600))
            {
                percentual = (salario * 0.25) - 500;
            }
            else
            {
                percentual = (salario * 0.3) - 700;
            }
            return percentual;
        }
    }
    public class PJuridica : Contribuinte
    {
        protected String cnpj;
        protected double faturamento;
        public PJuridica(String n, string end, double f, String c)
        {
            cnpj = c;
            faturamento = f;
            base.nome = n;
            base.endereco = end;
        }
        public string getCnpj()
        {
            return cnpj;
        }
        public double getFat()
        {
            return faturamento;
        }
        public override double calcImposto()
        {
            double percentual = 0.1 * faturamento;
            return percentual;
        }
    }


}
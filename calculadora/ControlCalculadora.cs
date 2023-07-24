using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static calculadora.ModelCalculadora;

namespace calculadora
{
    class ControlCalculadora
    {
        //Criando um objeto calculadora na memória
        ModelCalculadora calculadora;

        public ControlCalculadora()
        {
            this.calculadora = new ModelCalculadora();
        }//fim do construtor

        public void Coletar()
        {
            Console.WriteLine("Informe um número: ");
            this.calculadora.GetSetNum1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe outro número: ");
            this.calculadora.GetSetNum2 = Convert.ToDouble(Console.ReadLine());
        }//fim do coletar

        public int Menu()
        {
            Console.WriteLine("------ Menu -------"                                     +
                              "\n0. Sair"                                               +
                              "\n1. Somar"                                              +
                              "\n2. Subtrair"                                           +
                              "\n3. Dividir"                                            +
                              "\n4. Multiplicar"                                        +
                              "\n5. Potência"                                           +
                              "\n6. Raiz"                                               +
                              "\n7. Tabuada"                                            +
                              "\n8. Conversão de binário para decimal"                  +
                              "\n9. Conversão de decimal para binário"                  +
                              "\n10. Hexadecimal para decimal "                         +
                              "\n11. Decimal para Hexadecimal"                          +
                              "\n12. Bhaskara"                                          +
                              "\n13. Exc1"                                              +
                              "\n14. Exc2"                                              +
                              "\n15. Exc3"                                              +
                              "\n16. Exc5"                                              +
                              "\n17. Exc6"                                              +
                              "\n\nEscolha uma das opções acima: ");
            int opcao = Convert.ToInt32(Console.ReadLine());
            return opcao;
        }//fim do método Menu

        public void Operacao()
        {
            int opcao = 0;
            do
            {
                opcao = Menu();
                Console.Clear();//Limpa a tela
                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;

                    case 1:
                        Coletar();
                        Console.WriteLine("Soma: " + this.calculadora.Somar());
                        break;

                    case 2:
                        Coletar();
                        Console.WriteLine("Subtração: " + this.calculadora.Subtrair());
                        break;

                    case 3:
                        Coletar();
                        if (this.calculadora.Dividir() == -1)
                        {
                            Console.WriteLine("Impossível dividir!");
                        }
                        else
                        {
                            Console.WriteLine("Divisão: " + this.calculadora.Dividir());
                        }
                        break;

                    case 4:
                        Coletar();
                        Console.WriteLine("Multiplicar: " + this.calculadora.Multiplicar());
                        break;

                    case 5:
                        Coletar();
                        Console.WriteLine("Potência: " + this.calculadora.Potencia());
                        break;

                    case 6:
                        Coletar();
                        Console.WriteLine(this.calculadora.Raiz());
                        break;

                    case 7:
                        Console.WriteLine("Informe um número: ");
                        this.calculadora.GetSetNum1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(this.calculadora.TabuadaNum1());
                        break;

                    case 8:
                        Console.WriteLine("Informe um valor em binário: ");
                        Console.WriteLine(this.calculadora.ConverterDecimal(Console.ReadLine()));
                        break;

                    case 9:
                        Console.WriteLine("Informe um valor em decimal: ");
                        Console.WriteLine(this.calculadora.ConverterBinario(Convert.ToInt32(Console.ReadLine())));
                        break;

                    case 10:
                        Console.WriteLine("Informe um valor em Hexadecimal: ");
                        Console.WriteLine(this.calculadora.ConverterHexaDecimal(Console.ReadLine()));
                        break;

                    case 11:
                        Console.WriteLine("Informe um valor em Decimal: ");
                        Console.WriteLine(this.calculadora.ConverterDecimalHexa(Convert.ToInt32(Console.ReadLine())));
                        break;

                    case 12:
                        Console.WriteLine("Informe A: ");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe B: ");
                        double b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe C: ");
                        double c = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(this.calculadora.bhaskara(a, b, c));
                        break;
                    default:
                        Console.WriteLine("Opção escolhida não é valida");
                        break;

                    case 13:
                        Console.Write("Digite um número: ");
                        int num = int.Parse(Console.ReadLine());
                        ModelCalculadora calculadora = new ModelCalculadora();
                        (int doubleNum, int tripleNum) = calculadora.Exc1(num);
                        Console.WriteLine($"O dobro de {num} é: {doubleNum}");
                        Console.WriteLine($"O triplo de {num} é: {tripleNum}");
                        break;

                    case 14:
                        ModelCalculadora.Ex2();
                        break;

                    case 15:
                        Console.Write("Digite um número: ");
                        int number = int.Parse(Console.ReadLine());
                        ModelCalculadora numberHelper = new ModelCalculadora();
                        string result = numberHelper.VerificarNumero(number);
                        Console.WriteLine(result);
                        break;

                    case 16:
                        ModelCalculadora modelCalculadora  = new ModelCalculadora();
                        int start = 1;
                        int end = 100;
                        int sum = modelCalculadora.CalcularSoma(start, end);
                        Console.WriteLine($"A soma dos números de {start} a {end} é: {sum}");

                        break;

                    case 17:
                        Console.Write("Digite o número da tabuada (N): ");
                        int n = int.Parse(Console.ReadLine());
                        Console.Write("Digite o limite da tabuada: ");
                        int limit = int.Parse(Console.ReadLine());
                        TabelaDeMulti tabela = new TabelaDeMulti();
                        string table = tabela.Multi(n, limit);
                        Console.WriteLine(table);

                        break;

                }//fim do switch

            } while (opcao != 0);//fim do Do...while
        }//fim do operacao
    }//fim da classe
}//fim do projeto
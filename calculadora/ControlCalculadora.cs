using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using static calculadora.modelCalculadora;
using static calculadora.modelCalculadora.BinarioParaDecimal;

namespace calculadora
{
    class ControlCalculadora
    {
        //criando um objeto calculadora na memoria 
        modelCalculadora calculadora;

        public ControlCalculadora() 
        {
            calculadora = new modelCalculadora();
        }// fim do construtor 

        public void coletar()
        {
            Console.WriteLine("Informe um numero: ");
            this.calculadora.GetSetNum1 = Convert.ToDouble (Console.ReadLine());

            Console.WriteLine("Informe outro numero: ");
            this.calculadora.GetSetNum2= Convert.ToDouble (Console.ReadLine());
        }//fim do coletar

        //Método Coletar Bhaskara
        public void ColetaBhaskara()
        {
            Console.WriteLine("Informe o A");
            this.calculadora.GetsetA = Convert.ToDouble(Console.ReadLine());



            Console.WriteLine("Informe o B");
            this.calculadora.GetsetB = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o C");
            this.calculadora.GetsetC = Convert.ToDouble(Console.ReadLine());
        }//Fim do método coleta A, B e C


        public int Menu()
        {
            Console.WriteLine("---------Menu---------"          +
                              "\n0. Sair"                       +
                              "\n1. Somar"                      +
                              "\n2. Subtrair"                   +
                              "\n3. Dividir"                    +
                              "\n4. Multiplicar"                +
                              "\n5. Potencia"                   +
                              "\n6. Raiz do primeiro numero"    +
                              "\n7. Tabuada"       +
                              "\n8. Binario Para Decimal"       +
                              "\n9. Decimal Para Binario"       +
                              "\n10. Decimal Para Hexadecimal"   +
                              "\n11. Hexadecimal Para Decimal"  +
                              "\n12. Equação de 2° Grau"        +  
                              "\n\nEscolha uma das opções acima");
            int opcao = Convert.ToInt32(Console.ReadLine());
            return opcao;
        }//fim do metodo menu

        public void Operacao()
        {
            int opcao = 0;
            do
            {

                opcao = Menu();
                Console.Clear();

                switch (opcao)
                {


                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;
                    case 1:
                        coletar();
                        Console.WriteLine("Soma: " + this.calculadora.somar());
                        break;
                    case 2:
                        coletar();
                        Console.WriteLine("Subtração: " + this.calculadora.subtrair());
                        break;
                    case 3:
                        coletar();
                        if (this.calculadora.dividir() == -1)
                        {
                            Console.WriteLine("Impossivel dividir!");
                        }
                        else
                        {
                            Console.WriteLine("Divisão: " + this.calculadora.dividir());
                        }
                        break;
                    case 4:
                        coletar();
                        Console.WriteLine("Multiplicar: " + this.calculadora.multiplicar());
                        break;
                    case 5:
                        coletar();
                        Console.WriteLine("Potencia: " + this.calculadora.potencia());
                        break;
                    case 6:
                        coletar();
                        Console.WriteLine("Raiz: " + this.calculadora.Raiz());
                        break;
                    case 7:
                        Console.WriteLine("Informar um numero: ");
                        this.calculadora.GetSetNum1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(this.calculadora.TabuadaNum1());
                        break;
                    case 8:
                        Console.WriteLine("Digite um número binário:");
                        string binaryInput = Console.ReadLine();

                        // Controller logic - interaction with Model
                        BinaryToDecimalModel model = new BinaryToDecimalModel();
                        int decimalNumber = model.ConvertBinaryToDecimal(binaryInput);

                        // View logic - displaying the result
                        Console.WriteLine($"O número decimal equivalente é: {decimalNumber}");
                

                break;

                    case 9:
                        Console.WriteLine("Digite um número decimal:");
                        int decimalInput;
                        if (int.TryParse(Console.ReadLine(), out decimalInput))
                        {
                            DecimalParaBinario model2 = new DecimalParaBinario();
                            string binaryNumber = model2.ConvertDecimalToBinary(decimalInput);
                            Console.WriteLine($"O número binário equivalente é: {binaryNumber}");
                        }
                        else
                            Console.WriteLine("Entrada inválida. Certifique-se de digitar um número decimal válido.");

                        break;
                    case 10:

                        Console.WriteLine("Digite um número decimal:");
                        int decimalInput2;
                        if (int.TryParse(Console.ReadLine(), out decimalInput2))
                        {
                            modelCalculadora model4 = new modelCalculadora();
                            string hexNumber = model4.ConverterDecimalParaHexa(decimalInput2);
                            Console.WriteLine($"O número hexadecimal equivalente é: {hexNumber}");
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida. Certifique-se de digitar um número decimal válido.");
                        }

                        break;


                    case 11:

                        Console.WriteLine("Digite um número hexadecimal:");
                        string hexInput = Console.ReadLine();
                        modelCalculadora model3 = new modelCalculadora();
                        try
                        {
                            int decimalNumber1 = model3.ConverterHexparaDecimal (hexInput);
                            Console.WriteLine($"O número decimal equivalente é: {decimalNumber1}");
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        break;


                    case 12:
                        ColetaBhaskara();
                        if (this.calculadora.X1() == -1)
                        {
                            Console.WriteLine("Delta Negativo!");
                        }
                        else
                        {
                            Console.WriteLine("Delta: " + this.calculadora.Delta());
                            Console.WriteLine("X1: " + this.calculadora.X1());
                            Console.WriteLine("X2: " + this.calculadora.X2());
                        }
                        break;

                }//fim do switch
            } while (opcao != 0);

            
        }// fim do metodo operacao
    }//fim da classe
}//fim do projeto 

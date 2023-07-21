using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace calculadora
{
     class modelCalculadora
     {
        private double num1; 
        private double num2;
        private double A;
        private double B;
        private double C;


        public modelCalculadora()
        {
            GetSetNum1 = 0;
            GetSetNum2 = 0;
            GetsetA = 0;
            GetsetB = 0;
            GetsetC = 0;
        }// fim do construtor

        //metodos Gets e Sets

        public double GetSetNum1
        {
            get { return this.num1; } 
            set { this.num1 = value; }
        }// fim do getsetnum1

        public double GetSetNum2
        {
            get { return this.num2; }
            set { this.num2 = value; }
        }// fim do GetSetNum2

        public double GetsetA
        {
            get { return this.A; }
            set { this.A = value; }
        }//Fim do GetSetNum2



        public double GetsetB
        {
            get { return this.B; }
            set { this.B = value; }
        }//Fim do GetSetNum2



        public double GetsetC
        {
            get { return this.C; }
            set { this.C = value; }
        }//Fim do GetSetNum2

        //Metodos
        public double somar()
        {
            return GetSetNum1 + GetSetNum2;
        }//fim do metodo somar

        
        public double subtrair()
        {
            return GetSetNum1 - GetSetNum2;
        }// fim do metodo subtrair
        
        public double dividir()
        {
            if (GetSetNum2 <= 0)
            {
                return -1;
            }
            else
            {
                return GetSetNum1 / GetSetNum2;
            }
                
            
        }//fim do metodo dividir
        
        public double multiplicar()
        {
            return GetSetNum1 * GetSetNum2;

        }// fim do metodo multiplicar

        public double potencia()
        {
            return Math.Pow(GetSetNum1, GetSetNum2);
        }//fim da potencia 

        public string Raiz()
        {
            string msg = "Raiz do primeiro numero " + Math.Sqrt(GetSetNum1) +
                         "\nRaiz do segundo numero " + Math.Sqrt(GetSetNum2);
            return msg;
        }//fim do metodo raiz

        public string TabuadaNum1()
        {
            string resultado = "";
            
            for(int i = 0;i <= 10; i++)
            {
                resultado += "\n" + GetSetNum1 + " * " + i + " = " + (GetSetNum1 * i);
            }//fim do for 

            return resultado;
        }

        public string TabuadaNum2()
        {
            string resultado = "";

            for (int i = 0; i <= 10; i++)
            {
                resultado += "\n" + GetSetNum2 + " * " + i + " = " + (GetSetNum2 * i);
            }//fim do for 

            return resultado;
        }

        public class BinarioParaDecimal
        {
            public class BinaryToDecimalModel
            {
                public int ConvertBinaryToDecimal(string binaryNumber)
                {
                    int decimalNumber = Convert.ToInt32(binaryNumber, 2);
                    return decimalNumber;
                }
            }
        }
        public class DecimalParaBinario
        {
            public string ConvertDecimalToBinary(int decimalNumber)
            {
                string binaryNumber = Convert.ToString(decimalNumber, 2);
                return binaryNumber;
            }
        }
        public int ConverterHexparaDecimal(string hexNumber)
        {
            int decimalNumber1;
            try
            {
                decimalNumber1 = Convert.ToInt32(hexNumber, 16);
            }
            catch (FormatException)
            {
                throw new ArgumentException("O número hexadecimal inserido é inválido.");
            }
            return decimalNumber1;
        }

        public string ConverterDecimalParaHexa(int decimalNumber)
        {
            string hexNumber = decimalNumber.ToString("X");
            return hexNumber;
        }

        public double Delta()
        {
            return (GetsetB * GetsetB) - (4) * (GetsetA * GetsetC);
        }//Fim do método Delta



        //Método X1
        public double X1()
        {
            if (Delta() <= 0)
            {
                return -1;
            }
            else
            {
                return (-GetsetB + Math.Sqrt(Delta())) / (2 * GetsetA);
            }
        }//Fim do método X1



        //Método X2
        public double X2()
        {
            return (-GetsetB - Math.Sqrt(Delta())) / (2 * GetsetA);
        }//Fim do método X2

    }//fim da class
}//fim do projeto 
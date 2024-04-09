
using System;

public class Program{
    public static void Main(){
    //declarando as variaveis
    double salario_minimo, quant_klw, valor_klw, valor_total, valor_desconto, desconto, set_Salario;
    Console.WriteLine ("Digite o valor do salario minimio: ");
    salario_minimo = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Digite a quantidade gasta de kilowatt: ");
    quant_klw = Convert.ToDouble(Console.ReadLine());

    //Cálculos 

    set_Salario = salario_minimo / 7;

    valor_klw =  set_Salario / 100;

    valor_total = quant_klw * valor_klw;

    desconto = valor_total * 0.10;

    valor_desconto = valor_total - desconto;

    //Saída de dados 

    Console.WriteLine("\nO valor de cada kilowatt é de: R${0:f2}", valor_klw);
    Console.WriteLine("O valor a ser pago é de: R${0:f2}", valor_total);
    Console.WriteLine("O valor a ser pago com desconto de 10% é de: R${0:f2}", valor_desconto);
  }
}

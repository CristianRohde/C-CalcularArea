using System;
using System.Collections.Generic;

namespace Dever05Cristian
{
    class Program
    {
        static void Main(string[] args)
        {

            List<FiguraGeometrica> areas = new List<FiguraGeometrica>();

            Console.WriteLine("Seja Bem-Vindo/a!!!" +
                "\n Digite 1 para calcular area de Quadrado/Retangulo" +
                "\n Didite 2 para calcular area de Triangulo" +
                "\n Digite 3 paracalcular  area de Circulo");
            string op = Console.ReadLine();

            switch (op)
            {
                case "1":
                    Quadrado qua = new Quadrado();
                    Console.WriteLine("Digite a base do Quadrado");
                    qua.basse = float.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a altura do Quadrado");
                    qua.altura = float.Parse(Console.ReadLine());
                    areas.Add(qua);
                    break;

                case "2":
                    Triangulo tri = new Triangulo();
                    Console.WriteLine("Digite a Base do Triangulo");
                    tri.basse = float.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a altura do Triangulo");
                    tri.altura = float.Parse(Console.ReadLine());
                    areas.Add(tri);
                    break;

                case "3":
                    Circulo cir = new Circulo();
                    Console.WriteLine("Digite o Radio do Circulo");
                    cir.radio = double.Parse(Console.ReadLine());
                    areas.Add(cir);
                    break;
            }

            for(int a = 0; a < areas.Count; a++){
                areas[a].CalcularArea();
            }
        }
    }
    abstract class FiguraGeometrica
    {
        public abstract void CalcularArea();
    }
    class Quadrado : FiguraGeometrica
    {
        public float basse, altura;
        public override void CalcularArea()
        {
            Console.WriteLine("A area do Quadrado/Rectangulo é: "+ (basse * altura) + " cm²");          
        }
    }
    class Triangulo : FiguraGeometrica
    {
        public float basse, altura;
        public override void CalcularArea()
        {
            Console.WriteLine("A area do Triangulo é: "+ ((basse*altura)/2)+ " cm²"); 
        }
    }
    class Circulo : FiguraGeometrica
    {
        public double radio, pi = 3.14;
        public override void CalcularArea()
        {
            Console.WriteLine("a area do Circulo é: "+(pi * (radio*radio))+ " cm²"); 
        }
    }
}

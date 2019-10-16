using System;

namespace Module2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int choiceOfFigure;
            int choiceOfCalculation = 0;
            bool resultOfParse;

            do
            {
                resultOfParse = TryIntParse("Выберите фигуру:\n1 - круг\n2 - четырёхугольник\n3 - треугольник", out choiceOfFigure);
            }
            while ((!resultOfParse) || (choiceOfFigure <= 0) || (choiceOfFigure > 3));

            if (choiceOfFigure == 1)
            {
                double radius;

                do
                {
                    resultOfParse = TryDoubleParse("Введите радиус круга: ", out radius);
                    if (!resultOfParse) 
                    {
                        continue;
                    }
                
                    resultOfParse = TryIntParse("Выберите, что хотите вычислить:\n1 - периметр круга\n2 - площадь круга", out choiceOfCalculation);
                    if (!resultOfParse)
                    {
                        continue;
                    }
                }
                while ((!resultOfParse) || (radius <= 0) || (choiceOfCalculation < 1) || (choiceOfCalculation > 2));

                Circle circle = new Circle(radius);
                if (choiceOfCalculation == 1)
                {
                    double figurePerimeter = circle.GetPerimeter();
                    Console.WriteLine("Периметр круга: " + figurePerimeter);

                    double squareArea = GetSquareArea(figurePerimeter);

                    double triangleArea = GetTriangleArea(figurePerimeter);

                    Console.WriteLine($"Площадь четырёхугольника: {squareArea}\nПлощадь треугольника: {triangleArea}");
                }
                else if (choiceOfCalculation == 2)
                {
                    double figureArea = circle.GetSquare();
                    Console.WriteLine("Площадь круга: " + figureArea);

                    double squarePerimeter = GetSquarePerimeter(figureArea);

                    double trianglePerimeter = GetTrianglePerimeter(figureArea);

                    Console.WriteLine($"Периметр четырёхугольника: {squarePerimeter}\nПериметр треугольника: {trianglePerimeter}");
                }
            }
            else if (choiceOfFigure == 2)
            {
                double side;

                do
                {
                    resultOfParse = TryDoubleParse("Введите длину стороны четырехугольника: ", out side);
                    if (!resultOfParse)
                    {
                        continue;
                    }

                    resultOfParse = TryIntParse("Выберите, что хотите вычислить:\n1 - периметр четырехугольника\n2 - площадь четырехугольника", out choiceOfCalculation);
                    if (!resultOfParse)
                    {
                        continue;
                    }
                }
                while ((!resultOfParse) || (side <= 0) || (choiceOfCalculation < 1) || (choiceOfCalculation > 2));

                Square rectangle = new Square(side);
                if (choiceOfCalculation == 1)
                {
                    double figurePerimeter = rectangle.GetPerimeter();
                    Console.WriteLine("Периметр четырехугольника: " + figurePerimeter);

                    double circleArea = GetCircleArea(figurePerimeter);

                    double triangleArea = GetTriangleArea(figurePerimeter);

                    Console.WriteLine($"Площадь круга: {circleArea}\nПлощадь треугольника: {triangleArea}");
                }
                else if (choiceOfCalculation == 2)
                {
                    double figureArea = rectangle.GetSquare();
                    Console.WriteLine("Площадь четырёхугольника: " + figureArea);

                    double circlePerimeter = GetCirclePerimeter(figureArea);

                    double trianglePerimeter = GetTrianglePerimeter(figureArea);

                    Console.WriteLine($"Периметр круга: {circlePerimeter}\nПериметр треугольника: {trianglePerimeter}");
                }
            }
            else if (choiceOfFigure == 3)
            {
                double side;
                do
                {
                    resultOfParse = TryDoubleParse("Введите длину стороны треугольника: ", out side);
                    if (!resultOfParse)
                    {
                        continue;
                    }
                    
                    resultOfParse = TryIntParse("Выберите, что хотите вычислить:\n1 - периметр треугольника\n2 - площадь треугольника", out choiceOfCalculation);
                    if (!resultOfParse)
                    {
                        continue;
                    }
                }
                while ((!resultOfParse) || (side <= 0) || (choiceOfCalculation < 1) || (choiceOfCalculation > 2));

                Triangle triangle = new Triangle(side);
                if (choiceOfCalculation == 1)
                {
                    double figurePerimeter = triangle.GetPerimeter();
                    Console.WriteLine("Периметр треугольника: " + figurePerimeter);

                    double squareArea = GetSquareArea(figurePerimeter);

                    double circleArea = GetCircleArea(figurePerimeter);

                    Console.WriteLine($"Площадь круга: {circleArea}\nПлощадь квадрата: {squareArea}");
                }
                else if (choiceOfCalculation == 2)
                {
                    double figureArea = triangle.GetSquare();
                    Console.WriteLine("Площадь треугольника: " + figureArea);

                    double squarePerimeter = GetSquarePerimeter(figureArea);

                    double circlePerimeter = GetCirclePerimeter(figureArea);

                    Console.WriteLine($"Периметр квадрата: {squarePerimeter}\nПериметр круга: {circlePerimeter}");
                }
            }
        }

        public static bool TryIntParse(string message, out int value)
        {
            bool resultOfParse;

            Console.WriteLine(message);

            resultOfParse = int.TryParse(Console.ReadLine(), out value);

            if (resultOfParse == false)
            {
                Console.WriteLine("Ошибка ввода.");
                return false;
            }
            else return true;
        }

        public static bool TryDoubleParse(string message, out double value)
        {
            bool resultOfParse;

            Console.WriteLine(message);

            resultOfParse = double.TryParse(Console.ReadLine(), out value);

            if (resultOfParse == false)
            {
                Console.WriteLine("Ошибка ввода.");
                return false;
            }
            else return true;
        }

        public static double GetCirclePerimeter(double area)
        {
            double radius = Math.Sqrt(area / Math.PI);

            return 2 * Math.PI * radius;
        }

        public static double GetCircleArea(double perimeter)
        {
            double radius = perimeter / (2 * Math.PI);

            return Math.PI * Math.Pow(radius, 2);
        }

        public static double GetTriangleArea(double perimeter)
        {
            double side = perimeter / 3;
            double halfPerimeter = perimeter / 2;

            return Math.Sqrt(perimeter / 2 * (halfPerimeter - side) * (halfPerimeter - side) * (halfPerimeter - side));
        }

        public static double GetTrianglePerimeter(double area)
        {
            double side = Math.Sqrt(4 * area / Math.Sqrt(3));

            return 3 * side;
        }

        public static double GetSquarePerimeter(double area)
        {
            double side = Math.Sqrt(area);

            return 4 * side;
        }

        public static double GetSquareArea(double perimeter)
        {
            double side = perimeter / 4;

            return Math.Pow(side, 2);
        }
    }

    interface IGeometricalFigure
    {
        double GetPerimeter();
        double GetSquare();
    }
    
    class Circle : IGeometricalFigure
    {
        public double Radius { get; private set; }
        
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double GetSquare()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        public double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
        
    }

    class Square : IGeometricalFigure
    {
        public double Side { get; private set; }
        
        public Square(double side)
        {
            Side = side;
        }

        public double GetSquare()
        {
            return Math.Pow(Side, 2);
        }
        public double GetPerimeter()
        {
            return Side * 4;
        }
    }

    class Triangle : IGeometricalFigure
    {
        public double Side { get; private set; }
        
        public Triangle(double side)
        {
            Side = side;
        }

        public double GetSquare()
        {
            double halfPerimeter = GetPerimeter() / 2;
            return Math.Sqrt(halfPerimeter * Math.Pow((halfPerimeter - Side), 3));
        }
        public double GetPerimeter()
        {
            return Side * 3;
        }
    }
}
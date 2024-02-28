

namespace Circle_Objects_Lab
{
    public class Circle
    {
        private double Radius {  get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public static double CalculateDiameter(double radius)
        {
            return radius *2;
        }

        public static double CalculateCircumference(double radius)
        {
            return radius * 2 * double.Pi;
        }

        public static double CalculateArea(double radius)
        {
            return radius * radius * double.Pi;
        }

        public static void Grow(double radius)
        {
            radius = radius * 2;
        }

        public static double GetRadius(double radius)
        {
            return radius;
        }
    }


}

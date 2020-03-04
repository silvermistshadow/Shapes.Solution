
namespace Shapes.Models
{
    public class Circle
    {
        public const double Pi = 3.14159;
        public int Radius { get; set; }
        
        public Circle(int circleRadius)
        {
            Radius = circleRadius;
        }

        public int getDiameter()
        {
            return Radius * 2;
        }

    }
}
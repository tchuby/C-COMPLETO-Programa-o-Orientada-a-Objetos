using HerancaPolimorfismo_Ex2.Entities.Enums;

namespace HerancaPolimorfismo_Ex2.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}

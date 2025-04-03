namespace BetterColorSpheres   
{
    public class Sphere
    {
        private readonly Color _color;
        private float _radius;
        private int _timesThrown;

        public Sphere(Color color, float radius)
        {
            _color = color;
            _radius = radius;
            _timesThrown = 0;
        }
    }
}
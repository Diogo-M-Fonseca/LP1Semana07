namespace ColorSpheres
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

        public void Pop()
        {
            _radius = 0;
        }

        public void Throw()
        {
           if (_radius > 0)
            {
                _timesThrown++;
            }
        }

        public int GetTimesThrown()
        {
            return _timesThrown;
        }


    }
}
using System;

namespace ColorSpheres
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Color color1 = new Color(255,50,50);
            Color color2 = new Color(50,50,50);
            Color color3 = new Color(55,5,150);
            Color color4 = new Color(10,255,50);

            Sphere sphere = new Sphere(color1,5);
            Sphere sphere2 = new Sphere(color2,3);
            Sphere sphere3 = new Sphere(color3,2);
            Sphere sphere4 = new Sphere(color4,10);


            sphere2.Throw();
            sphere3.Pop();
            sphere4.Throw();
            sphere.Throw();
            sphere2.Pop();
            sphere3.Throw();
            sphere4.Throw();
            sphere.Pop();
            sphere2.Throw();
            sphere3.Throw();
            sphere4.Pop();
            sphere.Throw();
            

        }
    }
}

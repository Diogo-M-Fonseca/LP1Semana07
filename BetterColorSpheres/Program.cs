﻿namespace BetterColorSpheres
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Color sphereColor = new Color(125, 244, 255);
            Sphere sphere = new Sphere(sphereColor, 5);

            sphere.Throw();
            sphere.Throw();
            sphere.Throw();
            sphere.Pop();

            System.Console.WriteLine($"The sphere has bounced {sphere.GetTimesThrown()} times,its color is {sphereColor.GetGrey()}");
        }

    }
}

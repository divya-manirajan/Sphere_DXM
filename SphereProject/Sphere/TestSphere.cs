/**
 * This class tests the methods of the sphere class
 * @author Divya Manirajan
 * @version 1.0
 * Proj1-TestSphere
 * SP20
 */
using System;

namespace Sphere
{
    class TestSphere
    {
        public static void Main(string[] args)
        {
            //creates sphere with no set diameter
            Sphere s1 = new Sphere();
            //creates sphere with diameter of 2.5
            Sphere s2 = new Sphere(2.5);

            //prints out the volume of sphere 1
            Console.WriteLine("The volume of sphere 1 is " + s1.getVolume());
            //prints out the volume of sphere 2
            Console.WriteLine("The volume of sphere 2 is " + s2.getVolume());

            //prints out the surface area of sphere 1
            Console.WriteLine("The surface area of sphere 1 is " + s1.getSurfaceArea());
            //prints out the surface area of sphere 2
            Console.WriteLine("The surface area of sphere 2 is " + s2.getSurfaceArea());

            //sets the diameter of sphere 1 to 3
            s1.setDiameter(3);

            //prints out volume, surface area, and
            //diameter of sphere 1 with the new diameter
            Console.WriteLine("The diameter of sphere 1 is " + s1.getDiameter());
            Console.WriteLine("The volume of sphere 1 is " + s1.getVolume());
            Console.WriteLine("The surface area of sphere 1 is " + s1.getSurfaceArea());

            //prints out information for both spheres using toString
            Console.WriteLine(s1.toString());
            Console.WriteLine(s2.toString());


        }//end Main
    }//end class
}//end namespace

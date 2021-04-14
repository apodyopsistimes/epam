/*using System;
using System.Collections.Generic;
using System.Text;

namespace LAB4VECTOR3D
{
    class Vector3d
    {
        double x;
        double y;
        double z;
        

        public Vector3d(double x, double y, double z) 
        {                                              
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public Vector3d((double x, double y, double z) values) : this(values.x, values.y, values.z)
        {                                              
        }
       
        public static Vector3d Sum(Vector3d a, Vector3d b) // сложение 
        {
            return new Vector3d(a.x + b.x, a.y + b.y, a.z + b.z);
        }
        public static Vector3d operator+(Vector3d a, Vector3d b)
        {
            return Vector3d.Sum(a, b);
        }

        public static Vector3d Minus(Vector3d a, Vector3d b) // вычитание  
        {
            return new Vector3d(a.x - b.x, a.y - b.y, a.z - b.z);
        }
        public static Vector3d operator -(Vector3d a, Vector3d b)
        {
            return Vector3d.Minus(a, b);
        }

        public static Vector3d multiplication (Vector3d a, Vector3d b) // умножение
        {
            return new Vector3d(a.x * b.x, a.y * b.y, a.z * b.z);
        }
        public static Vector3d operator *(Vector3d a, Vector3d b)
        {
            return Vector3d.multiplication(a, b);
        }
       

        
    }
}
*/
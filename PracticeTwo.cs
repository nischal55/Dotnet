using System;
namespace PracticeTwo{
    abstract class Shape{
        public abstract double area();
    }

    class Rectangle:Shape{
        double length;
        double breadth;
        public Rectangle(double length,double breadth){
            this.length=length;
            this.breadth=breadth;
        }
        public override double area(){
            double areaRect = length*breadth;
            return areaRect;
        }
    }
    class Circle:Shape{
        double radius;
        public Circle(double radius){
            this.radius=radius;
        }
        public override double area(){
            double areaCircle = 3.14*radius*radius;
            return areaCircle;
        }
    }
    class Triangle:Shape{
        double baseTri;
        double heightTri;

        public Triangle(double baseTri,double heightTri){
            this.baseTri=baseTri;
            this.heightTri=heightTri;
        }
        public override double area(){
            double areaTri= 0.5*(baseTri*heightTri);
            return areaTri;
        }
    }

    class PracticeTwo{
        static void Main(){
            Rectangle objRec=new Rectangle(2.0,2.0);
            System.Console.WriteLine(objRec.area());
            Circle objCircle = new Circle(2.0);
            System.Console.WriteLine(objCircle.area());
            Triangle objTri = new Triangle(2.0,2.0);
            System.Console.WriteLine(objTri.area());
        }
    }
}
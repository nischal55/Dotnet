using System;
namespace Matrix{
    class MatrixA{
        public int[,] values {get;}

       
        public MatrixA (int[,] values){
            this.values = values;
        }
        public static MatrixA operator +(MatrixA m1,MatrixA m2){
            for(int i=0;i<2;i++){
                for(int j=0;j<2;j++){
                    m1.values[i,j] =m1.values[i,j]+m2.values[i,j];
                    
                }
        }
return m1;


    }
    public void display(){
        for(int i=0;i<2;i++){
                for(int j=0;j<2;j++){
                    System.Console.WriteLine(values[i,j]);
                    
                }
        }
    }
    }

    public class Matrix{
        static void Main(){
            int[,] value1= {{1,2},{1,2}};
            int[,] value2= {{1,2},{1,2}};

            MatrixA m1 = new MatrixA(value1);
            MatrixA m2=new MatrixA(value2);
            MatrixA m3=m1+m2;

            m1.display();
            



        

        }
    }
}
using System;
namespace DelegateNotify{
   
    public delegate void Notify();
    public class ProcessBysinessLogic{
            public event Notify ProcessCompleted;
            public void StartProcess(){
                System.Console.WriteLine("Process Started!");
                onProcessCompleted();
            }
            protected virtual void onProcessCompleted(){
                ProcessCompleted?.Invoke();
            }
        }
    class DelegateNotify{
        static  void Main(){
            ProcessBysinessLogic bl=new ProcessBysinessLogic();
            bl.ProcessCompleted += bl_ProcessCompleted;
            bl.StartProcess();
        }
        public static void bl_ProcessCompleted(){
            System.Console.WriteLine("Process Completed");
        }
    }
}
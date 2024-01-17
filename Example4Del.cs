using System;
namespace Example4Del{
    public delegate void NotificationDelegate(string message);
      public class NotificationService{
          public void SendEmail(String message)=>Console.WriteLine($"Email Notification :{message}");
          public void SendSMS(String message)=>Console.WriteLine($"SMS Notification:{message}");
          public void SendPushNotification(String message)=>Console.WriteLine($"Push Noti:{message}");
      } 
      public class User{
        public string Name{get;set;}
        public User (string name){
            Name=name;

        } 
        public void Subscribe(NotificationDelegate notificationMethod){
            notificationMethod($"Hello{Name}, you have a notification");

        }
      }
        class Example4Del{
            static void Main(){
                NotificationService notificationService = new NotificationService();
                User alice = new User("Alice");
                User bob = new User("Bob");

                alice.Subscribe(notificationService.SendEmail);
                bob.Subscribe(notificationService.SendSMS);
            }
        }
      
    }

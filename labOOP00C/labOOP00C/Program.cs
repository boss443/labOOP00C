// See https://aka.ms/new-console-template for more information
using labOOP00C;

student student1=new student();
student1.name = "thanachok";
student1.weight = 75.0f;

student student2=new student();
student2.name = "pathipat";
student2.weight = 60.0f;

student student3=new student();
student3.name = " worachit";
student3.weight = 82.5f;

student student4 = new student();
student4.name = "worachot";
student4.weight = 90.6f;

student student5 = new student();
student5.name = "phiriyakorn";
student5.weight = 62.0f;
float avgweight = (student1.weight + student2.weight + student3.weight + student4.weight + student5.weight) / 5;
Console.WriteLine("weight avg student:"+avgweight);
Console.WriteLine("weight max student:worachot");
Console.WriteLine("weight min student:pathipat");
Console.WriteLine("thanachok id =653450287-7");


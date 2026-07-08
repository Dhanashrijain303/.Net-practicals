// See https://aka.ms/new-console-template for more information
/*using System ;

class Student{

   public string Name=" ";
   public int Rollno;
   public string Branch=" ";
   public long DOB;
    public float Height;
    public char Gender;

    public void display(){
        Console.WriteLine("Name="+Name
        +" "+"Rollno="+Rollno+" "+"Branch="+Branch+" "+"DOB="+DOB+" "+"Height="+Height+" "+"Gender="+Gender);
    }



} 
*/

/*class Collections
{
    List<string> names = new List<string>();

     name.add("Dhanashri")
     name.add("xyz")
     name.add("str")

}*/





using System;
class Collections

{

    

    static void Main()

    {

        List<string> names = new List<string>();

 

        names.Add("Krushna");

        names.Add("Arpita");

        names.Add("Dhanashri");

        names.Add("payal");

        names.Add("Shravni");

 

        foreach(string f in names)

        {

            Console.WriteLine(f);

        }

 

    }

}









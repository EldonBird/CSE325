// See https://aka.ms/new-console-template for more information


public class ConsoleApplication1() {



    private static void Main(string[] args) {
            
        String name = "Hunter Bird";
        String location = "Dallas, Texas";
        
        Console.WriteLine("My name is " + name + ", I am from " + location);
        
        Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy"));
        Console.WriteLine(DateTime.Today);

        DateTime christmas = new DateTime(DateTime.Today.Year, 12, 25); // just learned how to get spesific days from datetime, weird...
        
        Console.WriteLine(christmas);

        int daysuntil = (christmas - DateTime.Today).Days;
        
        Console.WriteLine(daysuntil);
        
        Example1();
    }

    static void Example1() {

        double width, height, woodlength, glassarea;
        string widthString, heightString;

        Console.Write("What is the width: ");
        widthString = Console.ReadLine();
        width = double.Parse(widthString);
        
        Console.Write("What is the height: ");
        heightString = Console.ReadLine();
        height = double.Parse(heightString);

        woodlength = 2 * (width + height) * 3.25;
        glassarea = 2 * (width * height);
        
        Console.WriteLine("the length of the wood is " + woodlength + " feet");
        Console.WriteLine("the area of the glass is " + glassarea + " square meters");

    }


}

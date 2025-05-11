namespace MegaDesk;

using System.Text.Json;
using System.IO;

public class DeskQuote {
    
    
    
    
    
    private int quote_id { get; }
    private Desk desk { get; }
    private String customer_name { get; }

    private int rush_time { get; }


    public DeskQuote(Desk d, String name, int rush) {
        
        desk = d;
        customer_name = name;
        rush_time = rush;

    }
    
    public double MaterialPrice(Desk.Material m) {
        
        double price = 0;

        switch (m) {
            case(Desk.Material.Oak):
                price = 200;
                break;
            case(Desk.Material.Laminate):
                price = 100;
                break;
            case(Desk.Material.Pine):
                price = 50;
                break;
            case(Desk.Material.Rosewood):
                price = 300;
                break;
            case(Desk.Material.Veneer):
                price = 125;
                break;
        }

        return price;
    }

    public double CalTotal() {

        // not quite sure if this is correct, but please let me know if I messed it up lol.
        double output = 200;

        output += desk.drawers * 50;
        
        output += MaterialPrice(desk.material);

        if (rush_time > 0) {
            output += 50; // went with the average, I dont knwo how I should go about calucating this at the moment. 
        }


        return output;


    }
    

    public string GetAll() {


        return "";
    }

}
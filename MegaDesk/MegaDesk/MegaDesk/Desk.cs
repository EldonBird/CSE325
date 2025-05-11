namespace MegaDesk;

public class Desk {
    private int id { get; }
    public Material material;
    double width { get; }
    double depth { get; }
    double height { get; }
    public int drawers { get; }


    public enum Material {
        Oak,
        Laminate,
        Pine,
        Rosewood,
        Veneer
    }

    public Desk(Material mat, double w, double d, double h, int dr) {
        
        material = mat;
        width = w;
        depth = d;
        height = h;
        drawers = dr;
        
        
    }


    public double GetArea() {

        return new double();
    }

    public double GetVolume() {
        
        return new double();
    }
}
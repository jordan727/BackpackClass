
Backpack blueBag = new Backpack("Blue", "Small");
Backpack RedBag = new Backpack("Red", "Medium");
Backpack GreenBag = new Backpack("Green", "Large");


Backpack myBag = new Backpack("Black", "Medium");

myBag.openBag();
myBag.putIn("lunch");
myBag.putIn("jacket");
myBag.closeBag();
myBag.openBag();
myBag.takeOut("jacket");
myBag.closeBag();


class Backpack
{
    public string color;
    public string size;
    public List<string> items;
    public bool open;

    public Backpack(string color, string size)
    {
        this.color = color;
        this.size = size;
        this.items = new List<string>();
        this.open = false;
    }

    public void openBag()
    {
        this.open = true;
        Console.WriteLine("Backpack is open");
    }

    public void closeBag()
    {
        this.open = false;
        Console.WriteLine("Backpack is closed");
    }

    public void putIn(string item)
    {
        items.Add(item);
        Console.WriteLine($"{item} has been added to the bag");
    }
    
    public void takeOut(string item)
    {
        items.Remove(item);
        Console.WriteLine($"{item} has been removed from the bag");
    }
}
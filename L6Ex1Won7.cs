
Closet Bucatarie = new Closet(10, 20, 30);

Console.WriteLine(Bucatarie.VolumOfCloset());

class Closet
{
    readonly int lenght;
    readonly int width;
    readonly int height;

    public Closet(int lenght, int width, int height)
    {
        this.lenght = lenght;
        this.width = width;
        this.height = height;
    }

    public int VolumOfCloset()
    {
        int solution = lenght * width * height;
        return solution;
    }
}
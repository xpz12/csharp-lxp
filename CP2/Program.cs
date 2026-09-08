namespace c_lxp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inventory = new GameInventory(5);

            inventory[0] = "Меч";
            inventory[2] = "Зелье";
            inventory[4] = "Зелье";

            Console.WriteLine(inventory[0]);
            Console.WriteLine(inventory["Зелье"]);
            Console.WriteLine(inventory);
        }
    }
}

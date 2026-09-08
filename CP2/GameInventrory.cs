using System;
using System.Linq;

class GameInventory
{
    private readonly string[] slots;

    public GameInventory(int slotsCount)
    {
        slots = new string[slotsCount];
    }

    public string this[int slot]
    {
        get
        {
            if (slot < 0 || slot >= slots.Length)
                throw new ArgumentOutOfRangeException(nameof(slot));

            return slots[slot];
        }
        set
        {
            if (slot < 0 || slot >= slots.Length)
                throw new ArgumentOutOfRangeException(nameof(slot));

            slots[slot] = value;
        }
    }

    public int this[string itemName]
    {
        get => slots.Count(item => item == itemName);
    }

    public override string ToString()
    {
        return $"[{string.Join(", ", slots.Select(item => item ?? "-"))}]";
    }
}
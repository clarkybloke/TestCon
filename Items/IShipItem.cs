namespace Items
{
    public interface IShipItem
    {
        string Name { get; set; }
        string Description { get; set; }
        int Size { get; set; }
        char Rating { get; set; }
        int Cost { get; set; }
        int PowerOutput { get; set; }
        int PowerConsumption { get; set; }
        int Range { get; set; }

        void PrimaryAction();
    }
}
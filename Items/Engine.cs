using System;

namespace Items
{
    public class Engine : IShipItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Size { get; set; }
        public char Rating { get; set; }
        public int Cost { get; set; }
        public int PowerOutput { get; set; }
        public int PowerConsumption { get; set; }
        public int Range { get; set; }

        public void PrimaryAction()
        {
            throw new NotImplementedException();
        }
    }
}
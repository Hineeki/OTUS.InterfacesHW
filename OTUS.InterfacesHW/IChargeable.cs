namespace OTUS.InterfacesHW
{
    public interface IChargeable
    {
        public void Charge()
        {
            Console.WriteLine("Charging...");
        }
        public string GetInfo();
    }
}


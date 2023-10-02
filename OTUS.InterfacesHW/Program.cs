namespace OTUS.InterfacesHW
{
    interface IDataProvider
    {
        string GetData();
    }
    interface IDataProcessor
    {
        void ProcessData(IDataProvider dataProvider);
    }
    class ConsoleDataProcessor : IDataProcessor
    {
        public void ProcessData(IDataProvider dataProvider)
        {
            Console.WriteLine(dataProvider.GetData());
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            IDataProcessor processor = new ConsoleDataProcessor();

            processor.ProcessData(new DbDataProvider());
            processor.ProcessData(new FileDataProvider());
            processor.ProcessData(new APIDataProvider());
        }
    }

    class DbDataProvider : IDataProvider
    {
        public string GetData()
        {
            return "Данные из БД";
        }
    }
    class FileDataProvider : IDataProvider
    {
        public string GetData()
        {
            return "Данные из файла";
        }
    }
    class APIDataProvider : IDataProvider
    {
        public string GetData()
        {
            return "Данные из АПИ";
        }
    }
}
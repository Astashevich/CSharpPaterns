namespace Facade
{
    internal class ProviderCommunication
    {
        public void Receive() => Console.WriteLine("Получение продукции от производителя");
        public void Payment() => Console.WriteLine("Оплата поставщику с удержанием комиссии за продажу продукции");
    }
}

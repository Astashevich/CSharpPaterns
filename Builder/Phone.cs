namespace Builder
{
    internal class Phone
    {
        public string Data { get; private set; }

        public Phone() => Data = "";

        public void AppendData(string data) => Data += data;
    }
}

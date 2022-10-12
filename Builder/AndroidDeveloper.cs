namespace Builder
{
    internal class AndroidDeveloper : IDeveloper
    {
        private Phone _phone;

        public AndroidDeveloper() => _phone = new Phone();

        public void CreateDisplay() => _phone.AppendData("Created Samsung display. ");

        public void CreateBox() => _phone.AppendData("Created Samsung box. ");

        public void SystemInastall() => _phone.AppendData("Install Android system. ");

        public Phone GetPhone() => _phone;
    }
}

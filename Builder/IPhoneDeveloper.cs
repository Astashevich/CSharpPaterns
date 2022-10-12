namespace Builder
{
    internal class IPhoneDeveloper : IDeveloper
    {
        private Phone _phone;

        public IPhoneDeveloper() => _phone = new Phone();

        public void CreateDisplay() => _phone.AppendData("Created IPhone display. ");

        public void CreateBox() => _phone.AppendData("Created IPhone box. ");

        public void SystemInastall() => _phone.AppendData("Install IOS system. ");

        public Phone GetPhone() => _phone;
    }
}

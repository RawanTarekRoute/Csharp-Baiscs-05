namespace Common.UserDefinedDataType
{
    internal interface IPerson
    {
        //int number;
        void Walk();

        void Eat();

        void Sleep();

        // 750 line of code
        public void EditOnFile()
        {
            // 1. Open file -> 200 line of code
            OpenFile();
            // 2. Edit File -> 500 line of code 
            EditFile();
            // 3. Save File -> 50 line of code
            SaveFile();
        }

        private void OpenFile()
        {
            var number = 10;
            // 200 line of code

        }

        private void EditFile()
        {

            // 500 line of code

        }

        private void SaveFile()
        {
            // 50 line of code
        }

    }
    internal interface IHuman
    {
        void Walk();
        void Eat();
        void Sleep();
    }
}

namespace Common.UserDefinedDataType
{
     struct MyStruct
    {
        // 1000 => 1004
        char ch;
        int x; // 4bytes + 4 bytes padding
        internal long y; // 8 bytes

        void FirstMethod()
        {

        }

        public void SecondMethod()
        {

        }

    }
}

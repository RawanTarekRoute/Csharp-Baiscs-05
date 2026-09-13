using System;
using System.Collections.Generic;
using System.Text;

namespace Common.UserDefinedDataType
{
    internal class Person : IPerson, IHuman
    {
        void IPerson.Eat()
        {
            // Person Eats
        }

        void IHuman.Eat()
        {
            // Human Eats
        }

        void IPerson.Sleep()
        {
            throw new NotImplementedException();
        }

        void IHuman.Sleep()
        {
            throw new NotImplementedException();
        }

        void IPerson.Walk()
        {
            throw new NotImplementedException();
        }

        void IHuman.Walk()
        {
            throw new NotImplementedException();
        }
    }
}

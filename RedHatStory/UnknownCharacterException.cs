using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RedHatStory
{
    class UnknownCharacterException : Exception
    {
        public override string Message
        {
            get
            {
                return "Неопознанный сказочный персонаж.";
            }
        }
    }
}

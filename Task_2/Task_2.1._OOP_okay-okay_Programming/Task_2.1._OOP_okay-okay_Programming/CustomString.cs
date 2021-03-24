using System.Linq;

namespace Task_2._1._OOP_okay_okay_Programming
{
    /// <summary>
    /// Class Session is created to manage all functionality required by the task
    /// </summary>
    public class CustomString
    {
        private char[] _inputString;

        //Constructor converting input string to char array
        public CustomString(string value)
        {
            _inputString = ToArray(value);
        }

        public char[] InputString { get => _inputString; }

        //Realization of indexer fucntionality
        public char this[int index]
        {
            get
            {
                while (index < 0)
                {
                    index += _inputString.Length;
                }
                index = index % _inputString.Length;
                return _inputString[index];
            }

        }

        //Function of converting string to char array
        public char[] ToArray(string str1) => str1.ToCharArray();
        //Function of converting char array to string
        public override string ToString() => new string(InputString);

        //Compare method.
        //Firstly compares strings my length;
        //If length of strings is equal it compares them by content.
        public int CompareTo(CustomString str)
        {
            if (InputString.Length < str.InputString.Length)
                return -1;
            if (InputString.Length > str.InputString.Length)
                return 1;

            for (int i = 0; i < InputString.Length; i++)
            {
                if (InputString[i] < str.InputString[i])
                    return -1;
                if (InputString[i] > str.InputString[i])
                    return 1;
            }
            return 0;
        }

        //Concat Method.
        //Returns two strings concated to one
        public void Concat(CustomString str)
        {
            _inputString = _inputString.Concat(str.InputString).ToArray();
        }

        //Search method.
        //It`s possible to search not only chars, but substrings as well.
        public int Search(string str)
        {
            char[] str1 = ToArray(str);
            if (str.Length > InputString.Length)
                return -1;
            int offset = 0;

            while (offset < InputString.Length)
            {
                int j = 0;
                while (offset + j < InputString.Length && j != str1.Length)
                {
                    if (InputString[offset + j] == str1[j]) j++;
                    else break;
                }

                if (j == str1.Length) return offset;

                offset++;

            }

            return -1;
        }

    }
}

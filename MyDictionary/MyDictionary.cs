using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary <TKey, TValue>
    {
        TKey[] _tKey;
        TValue[] _tValue;

        public MyDictionary()
        {
            _tKey = new TKey[0];
            _tValue = new TValue[0];
        }

        public void Add(TKey tKey, TValue tValue)
        {
            TKey[] tempArrayKeys = _tKey;
            TValue[] tempArrayValue = _tValue;

            _tKey = new TKey[_tKey.Length + 1];
            _tValue = new TValue[_tValue.Length + 1];

            for (int i = 0; i < tempArrayKeys.Length; i++)
            {
                _tKey[i] = tempArrayKeys[i];
            }

            for (int i = 0; i < tempArrayValue.Length; i++)
            {
                _tValue[i] = tempArrayValue[i];
            }

            _tKey[_tKey.Length - 1] = tKey;
            _tValue[_tValue.Length - 1] = tValue;

            Console.WriteLine("Plaka: " + tKey +" Şehir: " + tValue);
        }
    }
}

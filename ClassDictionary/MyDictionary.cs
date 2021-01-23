using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDictionary
{
    class MyDictionary<T_k, T_v>
    {
        T_k[] _key;
        T_v[] _value;
        T_k[] _tempkey;
        T_v[] _tempvalue;
        public MyDictionary()
        {
            _key = new T_k[0];
            _value = new T_v[0];
        }
        public void Add(T_k item, T_v item1)
        {
            _tempkey = _key;
            _key = new T_k[_key.Length + 1];
            for (int i = 0; i < _tempkey.Length; i++)
            {
                _key[i] = _tempkey[i];
            }
            _key[_key.Length - 1] = item;

            _tempvalue = _value;
            _value = new T_v[_value.Length + 1];
            for (int i = 0; i < _tempvalue.Length; i++)
            {
                _value[i] = _tempvalue[i];
            }
            _value[_value.Length - 1] = item1;
        }

        public void Yazdir()
        {
            Console.WriteLine("  " + "-----> Eskrim Oyuncuları Ve Tuşlamalar Tablosu <-----\n");
            for (int i = 0; i < _key.Length; i++)
            {
                Console.WriteLine("  " + _key[i] + ": " + _value[i] + " tuş");
            }
        }
    }
}

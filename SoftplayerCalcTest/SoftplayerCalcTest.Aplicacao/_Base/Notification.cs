using System;

namespace SoftplayerCalcTest.Aplicacao._Base
{
    public class Notification
    {
        public string Key { get; }
        public string Value { get; }

        public Notification(string key, string value)
        {
            if (string.IsNullOrWhiteSpace(key)) throw new ArgumentNullException(nameof(key));
            Key = key;
            Value = value;
        }
    }
}
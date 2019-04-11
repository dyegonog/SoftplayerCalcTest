namespace SoftplayerCalcTest.Aplicacao._Base
{
    public static class Assertion
    {
        public static Notification IsGreaterThan(int value, int fieldValue, string fieldName)
        {
            return fieldValue <= value ? new Notification(fieldName, fieldValue.ToString()) : null;
        }

        public static Notification IsGreaterThan(decimal value, decimal fieldValue, string fieldName)
        {
            return fieldValue <= value ? new Notification(fieldName, fieldValue.ToString()) : null;
        }
    }
}
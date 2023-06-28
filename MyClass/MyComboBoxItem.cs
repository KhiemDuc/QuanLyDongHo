namespace TodoApp.MyClass
{
    public class ComboBoxItem
    {
        public string Value { get; set; }
        public string ID { get; set; }

        public override string ToString()
        {
            return Value;
        }
    }
}
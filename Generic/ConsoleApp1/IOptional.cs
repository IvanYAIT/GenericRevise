namespace ConsoleApp1
{
    interface IOptional<T> where T : struct
    {
        T Value { get; }
        bool Empty { get; }
        void SetValue(T? value);
        T GetValueOrDefault();
    }
}

using System;

namespace GenericInterfaces
{
    internal class Number : IComparable<int>, IComparable<string>
    {
        public int Value { get; init; }

        public int CompareTo(int other)  =>
            Value.CompareTo(other);

        public int CompareTo(string? other)  =>
            Value.CompareTo(int.Parse(other!)); 
    }
}

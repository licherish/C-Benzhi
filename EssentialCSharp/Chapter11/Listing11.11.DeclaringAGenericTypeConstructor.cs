namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter11.Listing11_11
{
    using Listing11_08;

    public struct Pair<T> : IPair<T>
    {
        public Pair(T first, T second)
        {
            First = first;
            Second = second;
        }

        public T First { get; set; }
        public T Second { get; set; }


    }
}
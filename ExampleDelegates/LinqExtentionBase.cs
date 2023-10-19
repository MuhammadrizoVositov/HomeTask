public  class LinqExtentionBase
{
    public static IEnumerable<TSource>
  
}

internal record struct TSource(TSource Item1, TSource Item2)
{
    public static implicit operator (TSource, TSource)(TSource value)
    {
        return (value.Item1, value.Item2);
    }

    public static implicit operator TSource((TSource, TSource) value)
    {
        return new TSource(value.Item1, value.Item2);
    }
}
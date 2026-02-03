namespace FreePartResizer;

public static class EnumerableExtensions
{

    public static bool None<TItem>(this IEnumerable<TItem> enumerable, Func<TItem, bool> @delegate)
        => !enumerable.Any(@delegate);

}

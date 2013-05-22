namespace Microsoft.FSharp.Linq

open System.Linq

module Queryable =

    //let append() = 0
    //let average() = 0
    //let averageBy() = 0
    //let cache() = 0
    //let choose() = 0
    //let collect() = 0
    //let compareWith () = 0
    //let concat() = 0
    //let countBy = 0
    //let delay() = 0
    let distinct (source : IQueryable<'a>) =
        source.Distinct()
    //let distinctBy() = 0
    //let empty() = 0
    let exactlyOne (source : IQueryable<'a>) =
        source.Single()
    let exists predicate (source : IQueryable<'a>) =
        source.Any(predicate)
    //let exists2() = 0
    let filter (predicate : 'a -> bool) (source : IQueryable<'a>) : IQueryable<'a> =
        source.Where(predicate)
    let find predicate (source : IQueryable<'a>) : 'a =
        source.First(predicate)
    //let findIndex() = 0
    let fold folder state (source : IQueryable<'a>) =
        source.Aggregate(state, folder)
    let forall predicate (source : IQueryable<'a>) =
        source.All(predicate)
    let groupBy projection (source : IQueryable<'a>) =
        source.GroupBy(projection)
    let head (source : IQueryable<'a>) =
        source.First()
    let isEmpty (source : IQueryable<'a>) =
        0 = source.Count()
    //let iter() = 0
    //let iteri() = 0
    //let iter2() = 0
    let last (source : IQueryable<'a>) =
        source.Last()
    let length (source : IQueryable<'a>) =
        source.Count()
    let map (mapping : 'a -> 'b) (source : IQueryable<'a>) : IQueryable<'b> =
        source.Select(mapping)
    //let map2() = 0
    let mapi (mapping : int -> 'a -> 'b) (source : IQueryable<'a>) : IQueryable<'b> =
        let swapArgs a b = mapping b a
        source.Select(swapArgs)
    let max (source : IQueryable<'a>) : 'a =
        source.Max()
    let maxBy projection (source : IQueryable<'a>) : 'a =
        source.Max(projection)
    let min (source : IQueryable<'a>) : 'a =
        source.Min()
    let minBy projection (source : IQueryable<'a>) : 'a =
        source.Min(projection)
    let nth index (source : IQueryable<'a>) : 'a =
        source.ElementAt(index)
    //let pairwise() = 0
    //let pick() = 0
    //let reduce() = 0
    //let scan() = 0
    //let singleton() = 0
    let skip count (source : IQueryable<'a>) : IQueryable<'a> =
        source.Skip(count)
    let skipWhile (predicate : 'a -> bool) (source : IQueryable<'a>) : IQueryable<'a> =
        source.SkipWhile(predicate)
    let sort (source : IQueryable<'a>) : IQueryable<'a> =
        source.OrderBy( (fun x -> x) ).AsQueryable()
    let sortBy projection (source : IQueryable<'a>) : IQueryable<'a> =
        source.OrderBy(projection).AsQueryable()
    //let sum() = 0
    //let sumBy() = 0
    let take count (source : IQueryable<'a>) : IQueryable<'a> =
        source.Take(count)
    let takeWhile (predicate : 'a -> bool) (source : IQueryable<'a>) : IQueryable<'a> =
        source.TakeWhile(predicate)
    let toArray (source : IQueryable<'a>) =
        source.ToArray()
    let toList (source : IQueryable<'a>) =
        source.ToList()
    //let tryFind() = 0
    //let tryFindIndex() = 0
    //let tryPick() = 0
    //let truncate() = 0
    //let unfold() = 0
    let where = filter
    //let windowed() = 0
    let zip (source1 : IQueryable<'a>) (source2 : IQueryable<'b>) =
        source1.Zip(source2, (fun a b -> (a,b)))
    //let zip3() = 0

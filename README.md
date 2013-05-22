fs-queryable
============

I had a dream that we could use pipeline syntax with Entity frameworks expression builders.... 

sadly I don't believe this will ever work simply due to the nature of pipeline expressions. Perhaps a custom infix operator that will allow the feel of |> without the execution ramifications.

Maybe something like:

```
db.People
||| Queryable.filter (fun p -> p.Id > 10)
||| Queryable.take 1

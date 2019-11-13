# Sorting
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Intel Core i7-7700HQ CPU 2.80GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  DefaultJob : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT


```
|             Method |     Mean |    Error |   StdDev |
|------------------- |---------:|---------:|---------:|
|          SortedSet | 286.0 ns | 11.03 ns | 31.81 ns |
|            HashSet | 443.4 ns |  9.34 ns | 26.81 ns |
| ImmutableSortedSet | 881.5 ns | 18.73 ns | 53.14 ns |

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace Sorting
{
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class Benchmarks
    {
        private readonly int[] data;

        public Benchmarks()
        {
            this.data = new[] {1, 2, 5, 1, 7, 2, 4, 2, 9, 7, 11, 28, 14, 1};
        }

        [Benchmark]
        public void HashSet()
        {
            var numbers = new HashSet<int>(data).ToArray();
            Array.Sort(numbers);
        }

        [Benchmark]
        public void ImmutableSortedSet()
        {
            var sortedData = new HashSet<int>(data).ToImmutableSortedSet();
        }

        [Benchmark]
        public void SortedSet()
        {
            var sortedData = new SortedSet<int>(data);
        }
    }
}
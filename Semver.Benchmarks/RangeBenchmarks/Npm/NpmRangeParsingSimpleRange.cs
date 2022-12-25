using System;
using System.Collections.Generic;
using Semver.Benchmarks.Builders;
using Semver.Utility;

namespace Semver.Benchmarks.RangeBenchmarks.Npm
{
    public class NpmRangeParsingSimpleRange : NpmRangeParsing
    {
        private const int Seed = 1450160939;

        protected override IReadOnlyList<string> GetRanges()
        {
            var random = new Random(Seed);

            return Enumerables.Generate(RangeCount, () => random.VersionString()).ToReadOnlyList();
        }
    }
}
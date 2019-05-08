using System;
using Xunit;

namespace CollectionTesting.Tests
{

    public class StringCollectionsTests
    {
        [Fact]
        public void CtorZeroThrowsNoExceptions()
        {
            var c = new StringCollection();
        }
    }
}

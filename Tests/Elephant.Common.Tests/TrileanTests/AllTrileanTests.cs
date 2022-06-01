﻿namespace Elephant.Common.Tests.TrileanTests
{
    /// <summary>
    /// <see cref="Trilean"/> tests.
    /// </summary>
    public class AllTrileanTests
    {
        /// <summary>
        /// <see cref="Trilean"/> == tests.
        /// </summary>
        [Theory]
        [SpeedVeryFast]
        [MemberData(nameof(TrileanTestData.EqualData), MemberType = typeof(TrileanTestData))]
        public void TrileanEquals(Trilean a, Trilean b)
        {
            Assert.True(a == b);
            Assert.Equal(a, b);
        }

        /// <summary>
        /// <see cref="Trilean"/> == tests.
        /// </summary>
        [Theory]
        [SpeedVeryFast]
        [MemberData(nameof(TrileanTestData.UnequalData), MemberType = typeof(TrileanTestData))]
        public void TrileanUnequals(Trilean a, Trilean b)
        {
            Assert.False(a == b);
            Assert.NotEqual(a, b);
        }

        /// <summary>
        /// <see cref="Trilean"/> != tests.
        /// </summary>
        /// <remarks>The use of an if-else inside a test is not best-practice.</remarks>
        [Theory]
        [SpeedVeryFast]
        [MemberData(nameof(TrileanTestData.NotEqualData), MemberType = typeof(TrileanTestData))]
        public void NotEqual(Trilean a, Trilean b, bool expectedAreEqual)
        {
            if (expectedAreEqual)
                Assert.False(a != b);
            else
                Assert.True(a != b);
        }

        /// <summary>
        /// <see cref="Trilean"/> assign unknown test.
        /// </summary>
        [Fact]
        [SpeedVeryFast]
        public void TestIfTrileanIsUnknownIfNull()
        {
            Trilean trilean = new(null);
            
            Assert.True(trilean.IsUnknown);
        }

        /// <summary>
        /// <see cref="Trilean"/> assign unknown test.
        /// </summary>
        [Fact]
        [SpeedVeryFast]
        public void TestIfTrileanIsUnknownIfUnknown()
        {
            Trilean trilean = new(Trilean.Value.Unknown);
            
            Assert.True(trilean.IsUnknown);
        }

        /// <summary>
        /// <see cref="Trilean"/> assign unknown test.
        /// </summary>
        [Fact]
        [SpeedVeryFast]
        public void TestIfTrileanIsUnknownIfUnknownThroughMethod()
        {
            Trilean trilean = new();
            trilean.AssignUnknown();
            
            Assert.True(trilean.IsUnknown);
        }

        /// <summary>
        /// <see cref="Trilean.GetValue"/> assign unknown test.
        /// </summary>
        [Fact]
        [SpeedVeryFast]
        public void TestIfTrileanGetValueIsUnknownIfUnknown()
        {
            Trilean trilean = new();
            trilean.AssignUnknown();

            Assert.Equal(Trilean.Value.Unknown, trilean.GetValue);
        }

        /// <summary>
        /// <see cref="Trilean"/> assign unknown test.
        /// </summary>
        [Fact]
        [SpeedVeryFast]
        public void TestIfTrileanIsNeitherTrueNorFalseIfUnknown()
        {
            Trilean trilean = new();
            trilean.AssignUnknown();

            Assert.False(trilean.IsFalse || trilean.IsTrue);
        }

        /// <summary>
        /// <see cref="Trilean"/> assign false test.
        /// </summary>
        [Fact]
        [SpeedVeryFast]
        public void TestIsFalseIfAssignFalse()
        {
            Trilean trilean = new(false);
        
            Assert.True(trilean.IsFalse);
        }

        /// <summary>
        /// <see cref="Trilean"/> assign false test.
        /// </summary>
        [Fact]
        [SpeedVeryFast]
        public void TestIsFalseIfAssignFalseEnum()
        {
            Trilean trilean = new(Trilean.Value.False);
            
            Assert.True(trilean.IsFalse);
        }

        /// <summary>
        /// <see cref="Trilean"/> assign false tests.
        /// </summary>
        [Fact]
        [SpeedVeryFast]
        public void TestIsFalseIfAssignFalseByMethod()
        {
            Trilean trilean = new();
            trilean.AssignFalse();
            
            Assert.True(trilean.IsFalse);
        }

        /// <summary>
        /// <see cref="Trilean"/> assign false tests.
        /// </summary>
        [Fact]
        [SpeedVeryFast]
        public void TestIsFalseEnumIfAssignFalseByMethod()
        {
            Trilean trilean = new();
            trilean.AssignFalse();
            
            Assert.Equal(Trilean.Value.False, trilean.GetValue);
        }

        /// <summary>
        /// <see cref="Trilean"/> assign false tests.
        /// </summary>
        [Fact]
        [SpeedVeryFast]
        public void TestIsNotUnknownAndNotTrueIfAssignFalse()
        {
            Trilean trilean = new();
            trilean.AssignFalse();
            
            Assert.False(trilean.IsUnknown || trilean.IsTrue);
        }

        /// <summary>
        /// <see cref="Trilean"/> assign true tests.
        /// </summary>
        [Fact]
        [SpeedVeryFast]
        public void TestIsTrueIfAssignTrue()
        {
            Trilean trilean = new(true);
            
            Assert.True(trilean.IsTrue);
        }

        /// <summary>
        /// <see cref="Trilean"/> assign true tests.
        /// </summary>
        [Fact]
        [SpeedVeryFast]
        public void TestIsTrueIfAssignTrueEnum()
        {
            Trilean trilean = new(Trilean.Value.True);

            Assert.True(trilean.IsTrue);
        }

        /// <summary>
        /// <see cref="Trilean"/> assign true tests.
        /// </summary>
        [Fact]
        [SpeedVeryFast]
        public void TestIsTrueIfAssignTrueByMethod()
        {
            Trilean trilean = new();
            trilean.AssignTrue();
            
            Assert.True(trilean.IsTrue);
        }

        /// <summary>
        /// <see cref="Trilean"/> assign true tests.
        /// </summary>
        [Fact]
        [SpeedVeryFast]
        public void TestIsNotUnknownAndNotFalseIfAssignTrue()
        {
            Trilean trilean = new(true);

            Assert.False(trilean.IsUnknown || trilean.IsFalse);
        }
    }
}

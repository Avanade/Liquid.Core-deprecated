﻿using System.Diagnostics.CodeAnalysis;
using Liquid.Core.Utils;
using NUnit.Framework;

namespace Liquid.Core.Tests.Utils
{
    [TestFixture()]
    [ExcludeFromCodeCoverage]
    public class EnumUtilsTest
    {
        public enum TestTypeEnum
        {
            [System.ComponentModel.Description("DescriptionValue")]
            ValueType
        }

        /// <summary>
        /// Verifies the get description.
        /// </summary>
        [Test]
        public void Verify_GetDescription()
        {
            var sut = TestTypeEnum.ValueType;
            var result = sut.GetDescription();
            Assert.AreEqual("DescriptionValue", result);
        }

        /// <summary>
        /// Verifies the get attribute.
        /// </summary>
        [Test]
        public void Verify_GetAttribute()
        {
            var sut = TestTypeEnum.ValueType;
            var result = sut.GetAttribute<System.ComponentModel.DescriptionAttribute>();
            Assert.AreEqual("DescriptionValue", result.Description);
        }

        /// <summary>
        /// Verifies to enum.
        /// </summary>
        [Test]
        public void Verify_ToEnum()
        {
            var sut = "valueType";
            var result = sut.ToEnum<TestTypeEnum>();
            Assert.AreEqual(TestTypeEnum.ValueType, result);
        }
    }
}
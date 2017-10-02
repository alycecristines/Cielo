﻿using Cielo.Extensions;
using FluentAssertions;
using NUnit.Framework;
using System;

namespace Cielo.Test.Extensions
{
    [TestFixture]
    public class DateTimeExtensionTests
    {
        [Test]
        public void DateTimeExtension_ToCieloFormatDate_ShouldReturnInCieloFromatDate()
        {
            var date = new DateTime(2017, 08, 15, 12, 20, 28);
            date.ToCieloFormatDate().Should().Be("2017-08-15T12:20:28");
        }

        [Test]
        public void DateTimeExtension_ToCieloShortFormatDate_ShouldReturnInCieloShortFromatDate()
        {
            var date = new DateTime(2017, 08, 15, 12, 20, 28);
            date.ToCieloShortFormatDate ().Should().Be("2017-08-15");
        }

        [Test]
        public void DateTimeExtension_ToCieloFormatDatOnNullableVare_ShouldReturnInCieloFromatDate()
        {
            DateTime? date = new DateTime(2017, 08, 15, 12, 20, 28);
            date.ToCieloFormatDate().Should().Be("2017-08-15T12:20:28");
        }

        [Test]
        public void ToCieloShortFormatDateOnNullableVar_ShouldReturnInCieloShortFromatDate()
        {
            DateTime? date = new DateTime(2017, 08, 15, 12, 20, 28);
            date.ToCieloShortFormatDate().Should().Be("2017-08-15");
        }
    }
}

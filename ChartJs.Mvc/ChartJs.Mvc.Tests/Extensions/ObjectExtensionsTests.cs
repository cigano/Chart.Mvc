﻿using System;
using Chart.Mvc.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChartJs.Mvc.Tests.Extensions
{
    [TestClass]
    public class ObjectExtensionsTests
    {
        [TestMethod]
        public void CanSerializeToJson()
        {
            var json = DateTime.Now.ToJson();
            Assert.IsFalse(string.IsNullOrWhiteSpace(json));
        }
    }
}

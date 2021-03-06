﻿using ServiceRequestManagement.API.Application.DTOs;
using ServiceRequestManagement.API.Application.Extensions;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Xunit;

namespace ServiceRequestManagement.UnitTests.Application.Extensions
{

    public class GenericTypeExtensionsTests
    {
        [Fact]
        public void Given_NonGenericTypedClass_When_CallingGetGenericTypeNameExtension_Then_ReturnsTypeName()
        {
            // Arrange
            var nonGenericClass = new PostCreateServiceRequestDTO
            {
                BuildingCode = "123",
                CreatedBy = "Aaron",
                Description = "Turn up the heat!"
            };

            // Act
            var actual = nonGenericClass.GetGenericTypeName();

            // Assert
            Assert.Equal("PostCreateServiceRequestDTO", actual);
        }

        [Fact]
        public void Given_GenericTypedClass_When_CallingGetGenericTypeNameExtension_Then_ReturnsTypeName()
        {
            // Arrange
            var target = new List<object> { 45 };

            // Act
            var actual = target.GetGenericTypeName();

            // Assert
            Assert.Equal("List<Object>", actual);
        }
    }
}

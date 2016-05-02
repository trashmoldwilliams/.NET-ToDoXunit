﻿using ToDoList.Models;
using Xunit;

namespace ToDoList.Tests
{
    public class ItemTest
    {
        [Fact]
        public void GetDescriptionTest()
        {
            //Arrange
            var item = new Item();
            item.Description = "Wash the dog";

            //Act
            var result = item.Description;

            //Assert
            Assert.Equal("Wash the dog", result);
        }
    }
}
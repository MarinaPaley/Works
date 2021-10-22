// <copyright file="BookTests.cs" company="Васильева Марина Алексеевна">
// Copyright (c) Васильева Марина Алексеевна 2021. Учебные материалы.
// </copyright>

namespace Library.Core.Tests
{
    using NUnit.Framework;

    /// <summary>
    /// The book tests.
    /// </summary>
    public class BookTests
    {
        [Test]
        public void ToString_ValidData_Success()
        {
            //arrange
            var author = new Author(1, "Пушкин", "Александр", "Сергеевич");

            var book = new Book(1, "Сказки", author);

            const string EXPECTED = "Пушкин Александр Сергеевич Сказки";

            //act
            var actual = book.ToString();

            //assert
            Assert.AreEqual(EXPECTED,actual);
        }
    }
}

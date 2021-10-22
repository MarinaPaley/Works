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
        public void Ctor_ValidData_Success()
        {
            // arrange
            var author = new Author(1, "Пушкин", "Александр", "Сергеевич");

            var expectedId = 1;

            var expectedTitle = "Сказки";

            // act
            var book = new Book(expectedId, expectedTitle, author);

            // assert
            Assert.AreEqual(expectedId, book.Id);
            Assert.AreEqual(expectedTitle, book.Title);
            CollectionAssert.AreEqual(new[] { author }, book.Authors);
        }

        [Test]
        public void ToString_ValidData_Success()
        {
            // arrange
            var author = new Author(1, "Пушкин", "Александр", "Сергеевич");

            var book = new Book(1, "Сказки", author);

            const string Expected = "Пушкин Александр Сергеевич Сказки";

            // act
            var actual = book.ToString();

            // assert
            Assert.AreEqual(Expected, actual);
        }
    }
}

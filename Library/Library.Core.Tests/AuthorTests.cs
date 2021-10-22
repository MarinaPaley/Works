// <copyright file="AuthorTests.cs" company="Васильева Марина Алексеевна">
// Copyright (c) Васильева Марина Алексеевна 2021. Учебные материалы.
// </copyright>

namespace Library.Core.Tests
{
    using NUnit.Framework;

    /// <summary>
    /// Модульные тесты для класса <see cref="Author"/>.
    /// </summary>
    [TestFixture]
    public class AuthorTests
    {
        [Test]
        public void ToString_ValidData_Success()
        {
            //arrange
            var author = new Author(1, "Пушкин", "Александр", "Сергеевич");
            var expected = "Пушкин Александр Сергеевич";

            //act
            var actual = author.ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AddBook_ValidData_Success()
        {
            //arrange
            var author = new Author(1, "Пушкин", "Александр", "Сергеевич");
            var book = new Book(1, "Сказки");

            //act
            var actual = author.AddBook(book);

            //assert
            Assert.IsTrue(actual);
        }
    }
}
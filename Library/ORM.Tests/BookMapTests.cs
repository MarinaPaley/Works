// <copyright file="BookMapTests.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ORM.Tests
{
    using FluentNHibernate.Testing;
    using Library.Core;
    using NUnit.Framework;

    [TestFixture]
    internal class BookMapTests : BaseMapTests
    {
        [Test]
        public void PersistenceSpecification_ValidData_Success()
        {
            // arrange
            var book = new Book(1, "Тестовая книга");

            // act & assert
            new PersistenceSpecification<Book>(this.Session)
                .VerifyTheMappings(book);
        }
    }
}

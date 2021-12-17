// <copyright file="AuthorMapTests.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ORM.Tests
{
    using FluentNHibernate.Testing;
    using Library.Core;
    using NUnit.Framework;

    [TestFixture]
    internal class AuthorMapTests : BaseMapTests
    {
        [Test]
        public void PersistenceSpecification_ValidData_Success()
        {
            // arrange
            var author = new Author(1, "Фамилия тестового автора", "Имя тестового автора");

            // act & assert
            new PersistenceSpecification<Author>(this.Session)
                .VerifyTheMappings(author);
        }
    }
}
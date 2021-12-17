// <copyright file="ShelfMapTests.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Library.Core.Tests
{
    using FluentNHibernate.Testing;
    using Library.Core;
    using NUnit.Framework;
    using ORM.Tests;

    [TestFixture]
    internal class ShelfMapTests : BaseMapTests
    {
        [Test]
        public void PersistenceSpecification_ValidData_Success()
        {
            // arrange
            var shelf = new Shelf(1, "Полка 1");

            // act & assert
            new PersistenceSpecification<Shelf>(this.Session)
                .VerifyTheMappings(shelf);
        }
    }
}

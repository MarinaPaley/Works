// <copyright file="EnumerableExtension.cs" company="Васильева Марина Алексеевна">
// Copyright (c) Васильева Марина Алексеевна 2021. Учебные материалы.
// </copyright>

namespace Staff.Extensions
{
    using System.Collections.Generic;

    /// <summary>
    /// Коллекция методов расширения для интерфейса <see cref="IEnumerable{T}"/>.
    /// </summary>
    public static class EnumerableExtension
    {
        /// <summary>
        /// Метод расширения для Join<typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T"> Коллекция. </typeparam>
        /// <param name="collection"> Имя коллекции. </param>
        /// <param name="separator"> Разделилитель. </param>
        /// <returns> Последовательность через разделитель. </returns>
        public static string Join<T>(this IEnumerable<T> collection, string separator) => string.Join(separator, collection);
    }
}
// <copyright file="StringExtensions.cs" company="Васильева Марина Алексеевна">
// Copyright (c) Васильева Марина Алексеевна 2021. Учебные материалы.
// </copyright>

namespace Extensions
{
    /// <summary>
    /// Коллекция методов расширения для класса <see cref="string"/>.
    /// </summary>
    public static class StringExtensions
    {
        /// <inheritdoc cref="string.IsNullOrEmpty"/>
        public static bool IsNullOrEmpty(this string value) => string.IsNullOrEmpty(value);

        /// <summary>
        /// Подготавливает строку или возвращает <see langword="null"/> в случае провала.
        /// </summary>
        /// <param name="value"> Целевая строка. </param>
        /// <returns> Строку без лидирующий и/или замыкающий пробелов или <see langword="null"/>.
        /// </returns>
        public static string TrimOrNull(this string value)
        {
            var trimmedValue = value?.Trim();
            return trimmedValue.IsNullOrEmpty() ? null : trimmedValue;
        }
    }
}

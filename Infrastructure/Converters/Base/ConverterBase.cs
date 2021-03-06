﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace WpfAppCoreMVVMTemplate.Infrastructure.Converters.Base
{
    /// <summary>
    /// Базовый класс конвертера
    /// </summary>
    internal abstract class ConverterBase : IValueConverter
    {

        #region IValueConverter

        /// <summary>
        /// Прямое конвертирование
        /// </summary>
        /// <param name="value">Исходное значение</param>
        /// <param name="targetType">Тип целевого свойства</param>
        /// <param name="parameter">Параметр</param>
        /// <param name="culture">Используемая культура</param>
        /// <returns></returns>
        public abstract object Convert(object value, Type targetType, object parameter, CultureInfo culture);


        /// <summary>
        /// Обратное конвертирование
        /// </summary>
        /// <param name="value">Исходное значение</param>
        /// <param name="targetType">Тип целевого свойства</param>
        /// <param name="parameter">Параметр</param>
        /// <param name="culture">Используемая культура</param>
        /// <returns></returns>
        public virtual object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) =>
            throw new NotSupportedException("Обратное преобразование не поддерживается"); 
        #endregion

    }
}

using System;
using System.Globalization;
using System.Windows.Data;

namespace WpfAppCoreMVVMTemplate.Infrastructure.Converters.Base
{
    /// <summary>
    /// Мультиконвертер. Позволяет преобразовать: массив значений в одно значение; одно значение в массив значений.
    /// Используется при мультибиндинге
    /// </summary>
    internal abstract class MultiConverterBase : IMultiValueConverter
    {
        /// <summary>
        /// Конвертер массива значений в одно значение
        /// </summary>
        /// <param name="values">Исходный массив значение</param>
        /// <param name="targetType">Целевой тип</param>
        /// <param name="parameter"Параметр></param>
        /// <param name="culture">Используемая культура</param>
        /// <returns></returns>
        public abstract object Convert(object[] values, Type targetType, object parameter, CultureInfo culture);

        /// <summary>
        /// Конвертирование значения в массив значений.
        /// </summary>
        /// <param name="value">Исходное значение</param>
        /// <param name="targetTypes">Массив целевых типов</param>
        /// <param name="parameter">Параметры</param>
        /// <param name="culture"></param>
        /// <returns>Используемая культура</returns>
        public virtual object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture) =>
            throw new NotSupportedException("Обратное преобразование не поддерживается");
    }
}

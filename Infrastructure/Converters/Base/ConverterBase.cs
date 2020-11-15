using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace WpfAppCoreMVVMTemplate.Infrastructure.Converters.Base
{
    /// <summary>
    /// Базовый класс конвертера с расширением разметки
    /// </summary>
    internal abstract class ConverterBase : MarkupExtension, IValueConverter
    {


        #region MarkupExtension (расширение разметки)
        /// <summary>
        /// 
        /// </summary>
        /// <param name="serviceProvider"></param>
        /// <returns></returns>
        public override object ProvideValue(IServiceProvider serviceProvider) => this;

        #endregion



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

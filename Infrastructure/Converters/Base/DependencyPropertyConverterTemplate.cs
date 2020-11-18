using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace WpfAppCoreMVVMTemplate.Views.Controls
{

    /// <summary>
    /// КЛАСС КОНВЕРТЕРА ДЛЯ ПРИМЕРА!!!
    /// В РАЗРАБОТКЕ НЕ ИСПОЛЬЗОВАТЬ
    /// УДАЛИТЬ ПРИ РЕЛИЗЕ!
    /// </summary>
    internal class DependencyPropertyConverterTemplate : Freezable, IValueConverter
    {

        #region DependencyProperty

        public int MyProperty
        {
            get { return (int)GetValue(MyPropertyProperty); }
            set { SetValue(MyPropertyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MyPropertyProperty =
            DependencyProperty.Register("MyProperty", typeof(int), typeof(DependencyPropertyConverterTemplate), new PropertyMetadata(0));


        #endregion


        #region Freezable

        protected override Freezable CreateInstanceCore() => new DependencyPropertyConverterTemplate()
        { MyProperty = MyProperty};


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
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // код для конвертирования
            return value;
        }


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

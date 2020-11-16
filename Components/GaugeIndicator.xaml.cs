using System;
using System.Windows;
//using System.Windows.Controls;

namespace WpfAppCoreMVVMTemplate.Components
{
    /// <summary>
    /// Логика взаимодействия для GaugeIndicator.xaml
    /// </summary>
    public partial class GaugeIndicator /*: UserControl*/
    {

        #region ValueProperty

        public static readonly DependencyProperty ValueProperty =    // поле типа DependencyProperty (Property в имени обязательно)
            DependencyProperty.Register(                             // регистрация свойства зависимости
                nameof(Value),                      // - имя свойства в синтаксисе позволяющем сделать рефакторинг
                typeof(double),                     // - тип, которого будет свойствозависимости
                typeof(GaugeIndicator),             // - тип, которому принадлежит свойствозависимости
                new PropertyMetadata(               // - информация о том, как это свойство будет работать, для чего создается объект этого класса
                    default(double),            // -- значение по умолчанию
                    OnValuePropertyChanged,     // -- метод, который будет вызываться всякий раз, когда будет изменяться свойство
                    OnCoerceValue               // -- метод позволяет скоректировать значение свойства
                ),
                OnValidateValue                     // - Привязка успешна (true) или нет (false)
            );

        /// <summary>
        /// Индикатор привязки
        /// </summary>
        /// <param name="value">Новое установленное значение</param>
        /// <returns>истина - привязка осуществлена успешно /ложь - не успешно</returns>
        private static bool OnValidateValue(object value)
        {
            return true;
        }


        /// <summary>
        /// Корректировка значения свойства
        /// </summary>
        /// <param name="d"></param>
        /// <param name="baseValue">Передаваемое значение</param>
        /// <returns>Скорректированное значение</returns>
        private static object OnCoerceValue(DependencyObject d, object baseValue)
        {
            var value = (double)baseValue;
            return Math.Max(0, Math.Min(100, value));   // возвращаем значение от 0 до 100
        }

        /// <summary>
        /// Действия при изменении свойства
        /// </summary>
        /// <param name="d">Объект, для которого изменяется свойство</param>
        /// <param name="e">Объект, который содержит информацию, как это свойство меняется 
        /// (содержит старое значение и новое значение)</param>
        private static void OnValuePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
        }

        /// <summary>
        /// Само cвойство
        /// </summary>
        public double Value
        {
            get => (double)GetValue(ValueProperty);
            set => SetValue(ValueProperty, value);
        } 

        #endregion

        public GaugeIndicator()
        {
            InitializeComponent();
        }
    }
}

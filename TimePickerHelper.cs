using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;

namespace TestMetro
{
    public class TimePickerHelper : DependencyObject
    {
        private static FieldInfo field;

        static TimePickerHelper()
        {
            field = typeof(TimePicker).GetField("textBox", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.GetField | System.Reflection.BindingFlags.NonPublic);
        }

        public static bool GetTextEdit(DependencyObject obj)
        {
            return (bool)obj.GetValue(TextEditProperty);
        }

        public static void SetTextEdit(DependencyObject obj, bool value)
        {
            obj.SetValue(TextEditProperty, value);
        }


        public static readonly DependencyProperty TextEditProperty =
            DependencyProperty.RegisterAttached("TextEdit", typeof(bool), typeof(TimePickerHelper), new PropertyMetadata(true, OnTextEditPropertyChanged ));

        private static void OnTextEditPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            Console.WriteLine("TextEdit e.NewValue {0}", e.NewValue);
            var picker = (TimePicker)d;
            RoutedEventHandler loadEvent = null;
            loadEvent = (a, b) =>
            {
                DatePickerTextBox pickerTextBox = (DatePickerTextBox)field.GetValue(picker);
                pickerTextBox.IsReadOnly = true;
                picker.Loaded -= loadEvent;
            };

            picker.Loaded += loadEvent;


        }
    }
}

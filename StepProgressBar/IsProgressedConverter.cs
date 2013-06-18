using System;
using System.Windows.Controls;
using System.Windows.Data;

namespace StepProgressBarControl
{
    public class IsProgressedConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (!(values[0] is ContentPresenter && values[1] is Int32))
                return false;
            var contentPresenter = values[0] as ContentPresenter;
            var currentStep = (Int32)values[1];
            var itemsControl = ItemsControl.ItemsControlFromItemContainer(contentPresenter);
            var index = itemsControl.ItemContainerGenerator.IndexFromContainer(contentPresenter);
            return IsThisIndexPastOrCurrentStep(index, currentStep);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException();
        }

        private static bool IsThisIndexPastOrCurrentStep(int index, int currentStep)
        {
            return index < currentStep;
        } 
    }
}
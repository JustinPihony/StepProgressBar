using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media;

namespace StepProgressBarControl
{
    /// <summary>
    /// Interaction logic for StepProgressBar.xaml
    /// </summary>
    public partial class StepProgressBar
    {
        #region Dependency Properties
        public static readonly DependencyProperty NotProgressedBrushProperty =
          DependencyProperty.Register("NotProgressedBrush", typeof(SolidColorBrush), typeof(StepProgressBar), new PropertyMetadata(new BrushConverter().ConvertFrom("transparent")));

        public SolidColorBrush NotProgressedBrush
        {
            get { return (SolidColorBrush)GetValue(NotProgressedBrushProperty); }
            set { SetValue(NotProgressedBrushProperty, value); }
        }

        public static readonly DependencyProperty ProgressedBrushProperty =
          DependencyProperty.Register("ProgressedBrush", typeof(SolidColorBrush), typeof(StepProgressBar), new PropertyMetadata(new BrushConverter().ConvertFrom("green")));

        public SolidColorBrush ProgressedBrush
        {
            get { return (SolidColorBrush)GetValue(ProgressedBrushProperty); }
            set { SetValue(ProgressedBrushProperty, value); }
        }

        public static readonly DependencyProperty CurrentStepProperty =
          DependencyProperty.Register("CurrentStep", typeof(Int32), typeof(StepProgressBar));

        public Int32 CurrentStep
        {
            get { return (Int32)GetValue(CurrentStepProperty); }
            set { SetValue(CurrentStepProperty, value); }
        }

        public static readonly DependencyProperty TotalStepsProperty =
          DependencyProperty.Register("TotalSteps", typeof(Int32), typeof(StepProgressBar), new UIPropertyMetadata(TotalStepsChanged));

        public int TotalSteps
        {
            get { return (Int32)GetValue(TotalStepsProperty); }
            set { SetValue(TotalStepsProperty, value); }
        }

        private static void TotalStepsChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs)
        {
            if (!(dependencyObject is StepProgressBar))
                return;
            (dependencyObject as StepProgressBar).TotalStepsAsList = Enumerable.Range(0, (Int32)dependencyPropertyChangedEventArgs.NewValue).ToList();
        }

        private static readonly DependencyProperty TotalStepsAsListProperty =
          DependencyProperty.Register("TotalStepsAsList", typeof(IEnumerable<Int32>), typeof(StepProgressBar));

        private IEnumerable<Int32> TotalStepsAsList
        {
            get { return (IEnumerable<Int32>)GetValue(TotalStepsAsListProperty); }
            set { SetValue(TotalStepsAsListProperty, value); }
        }
        #endregion

        public StepProgressBar()
        {
            InitializeComponent();
        }
    }
}

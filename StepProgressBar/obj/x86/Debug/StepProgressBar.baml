   M S B A M L   `   `   `  ����Q  MStepProgressBarControl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:StepProgressBarControlStepProgressBarControl  5      ,    &StepProgressBarControl.StepProgressBar   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:StepProgressBarControl     5      -   5          >�Name$
  Main��5   R   $��Stretch=�5   7   $��Stretch=�6U   $��Stretch=�5      $��Stretch=�61    � 	Resources 5	      2   ,StepProgressBarControl.IsProgressedConverter   IsProgressedConverter��%   &	          5
   
   6&   5      .��5      �� $��Stretch=�6   $��Stretch=�61   $��Stretch=�6V   $��Stretch=�6r   ��6�   ��  �� ElementName$
 Main�� �� Path$ TotalStepsAsList� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=���5   
   �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6   5      ��5   
   �� 5      .R�5      � .+�5      A� $��Center=�6   
���   �$��5��6J   $��5��6U   $��0,0,7,0q�6_   $��1��6p   A� 5      $��Center=�6   
������ $��4��6P   $��4��6[   $��0,0,7,0q�6e   ��5      �� 5       �� Triggers 5   "   �� 5   &    �� Binding 5   *   `� 5   .   	 `� 	Converter#	 [  6;   .1�5   2   �� 
 �� RelativeSource
 6:   �� *TemplatedParent+�� 5   2   $ CurrentStep�6�   
 6:   ��  �� AncestorType,   &StepProgressBarControl.StepProgressBar"  6�   5   /    �� Value	 False5!   U   .a�5"   *   ��  �� Property � �� �� Value 6I   �� 
 �� "  $ NotProgressedBrush�6�   5#   '   �� 5$   &    5%   *   `� 5&   .   #	 [  6;   .1�5'   2   �� 
 6:   �� *TemplatedParent+�� 5(   2   $ CurrentStep�6�   
 6:   �� "  6�   5)   /    True5+   T   .a�5,   *   ��  � �� 6I   �� 
 �� "  $ ProgressedBrush�6�   5-   '   5/      51      52      53      55      56      
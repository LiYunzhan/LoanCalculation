   M S B A M L   `   `   `  ����J  FLoanCalculation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:LoanCalculationLoanCalculation  5   	        LoanCalculation.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:LoanCalculation     5   	     � Title$  
MainWindow��5   	   $	��800��6   $	��600��6)   .��5	      � #��� ��6   .+�5
   
   �� -   5         ��Name$ label��5
      $��贷款利息计算��6   $
��Left=�60   $��
258,10,0,0q�6K   $	��Top=�6_   $��86��6w   $��28��6�   �� 5   
   -   5        $ label1��5      $��输入金额：��6    $
��Left=�60   $��	47,48,0,0q�6K   $	��Top=�6^   $��73��6v   �� 5   
   -   5         ��Name$ textBox��5      $
��Left=�6#   $��23��6>   $��
275,51,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $�� ��6r   $	��Top=�6z   $	��252��6�   ���	#FFF7F4F46�   �� 5   
   -   5        $ label1_Copy��5      $��开始日期：��6%   $
��Left=�65   $��	47,87,0,0q�6P   $	��Top=�6c   $��73��6{   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ datePickerCtl��5      $��25��6,      Text$ 选择日期��68      SelectedDateFormat$ Short=�5         FirstDayOfWeek$ Monday=�6(      DisplayDateStart$ 1989/1/1X�5      	   IsTodayHighlighted	 . $��275,88,65,657q�5   '   5      �� 5   
   -   5        $ label1_Copy1��5      $��结束日期：��6&   $
��Left=�66   $��
47,131,0,0q�6Q   $	��Top=�6e   $��73��6}   �� 5   
   -   5        $ label1_Copy2��5      $��利率标准：��6&   $
��Left=�66   $��
47,169,0,0q�6Q   $	��Top=�6e   $��73��6}   �� 5   
   -   5        $ label1_Copy3��5      $��	倍率：��6&   $
��Left=�64   $��
47,218,0,0q�6O   $	��Top=�6c   $��73��6{   �� 5   
   -	   5        
 ��Name$
 	textBlock��5      $
��Left=�6'   $��
47,314,0,0q�6B   $
��Wrap=�6V   $�� ��6j   $	��Top=�6r   
�������
����  �$	��390��5   A   $	��502��6N   �� 5   
   -
   5         ��Name$ button��5      $��重置��6!   $
��Left=�6.   $��337,719,0,0q�6I   $	��Top=�6^   $��75��6v   6�   �� 5   
   -   5        $ button_Copy��5      $��计算��6&   $
��Left=�63   $��452,719,0,0q�6N   $	��Top=�6c   $��75��6{   6�     5   
   -   5        $ datePickerCtl_Copy��5      $��25��61   $ 选择日期��6=   $ Short=�5   
   $ Monday=�6%   $ 1989/1/1X�5   
   	 . $��275,132,65,613q�5   $   �� 5   
   -   5        $ textBox_Copy��5      $
��Left=�6(   $��23��6C   $��275,221,0,0q�6O   $
 Wrap=�6d   $�� ��6x   $	��Top=�6�   $	��118��6�   ���	#FFF7F2F26�   �� 5   
   -   5        $ label1_Copy4��5      $	��倍��6&   $
��Left=�62   $��428,221,0,0q�6M   $	��Top=�6b   $��39��6z    J� RenderTransformOrigin$ 2.101,0.445&�6�   �� 5    
   -   5        $ label1_Copy5��5       $��	结果：��6&   $
��Left=�64   $��
47,263,0,0q�6O   $	��Top=�6c   $��73��6{   �� 5!   
   -   5        $ label1_Copy6��5!      $�� ��6&   $
��Left=�61   $��275,263,0,0q�6L   $	��Top=�6a   $	��204��6y   ���	#FFFDF4F46�   �� 5"   
   -   5         ��Name$ comboBox��5"      $
��Left=�6%   $��275,173,0,0q�6@   $	��Top=�6U   $	��252��6m   .@�5#      �� $$��六个月内（含六个月）��6   $
��Left=�60   $	��250��6K   �� 5$      $'��!六个月至一年（含一年）��6   $
��Left=�61   $	��250��6L   �� 5%      $!��一至三年（含三年）��6   $
��Left=�6/   $	��250��6J   �� 5&      $!��三至五年（含五年）��6   $
��Left=�6/   $	��250��6J   �� 5'      $��五年以上��6   $
��Left=�6*   $	��250��6E   5(      5*      5+      
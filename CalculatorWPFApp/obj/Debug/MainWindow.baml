   M S B A M L   `   `   `  ����K  GCalculatorWPFApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:CalculatorWPFAppCalculatorWPFApp  5   	   !    CalculatorWPFApp.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:CalculatorWPFApp     5   	     � Title$  
Calculator��5   	   $	��450��6   $	��800��6)   .��5	      � 
���iii� � ColumnDefinitions 5
   
   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   .+�5   
   �� $��First Number��6   $��50(�6'   
�������6J   �� 5   
   $��Second Number��6   $��50(�6(   $��1��66   
�������6X   �� 5   
   $��Result��6   $��50(�6!   $��2��6/   
�������6Q   �� 5   
   -   5         ��Name$ first_number��5      $��1��6(   $��12q�68   $��50(�6D   $��Center=�6R   $��Center=�6v    �� 	MaxLength$ 14��6�   6�   �� 5   
   -   5        $ second_number��5      $��1��6)   $��1��69   $��12q�6G   $��50(�6S   $��Center=�6a   $��Center=�6�   $ 14��6�   6�   �� 5   
   -   5        $ 
result_box��5      $��1��6&   $��2��66   $��12q�6C   $��50(�6O    �� 
IsReadOnly . $��Center=�6o   $��Center=�6�   6�   �� 5   
   -   5         ��Name$ result_button��5      $��3��6(   $��	Calculate��65   $��50(�6I   $
��Bold"�6W   $��12q�6~   ��5      �� 5       �� 
TargetType" ��6   �5      �� 5        �� Property � ��	 �� Value$	 12q�63   6@   �� 5!       � ��
	 �����6G   �� 5"       � ��
	 �**��6G   
 �� Triggers
 5$      P� 5%       P� Property �@J�IsMouseOver P� Value . . �5&      ��  � ��
	 �**��6K   5'      5)      5+      �� 5-   
   -   5         ��Name$ operation_choice��5-      $��1��6-   $��3��6=   $��12q�6J   $��50(�6V   $��Center=�6d   $��Center=�6�    �� 
IsReadOnly .  �� 
IsEditable .  �� Text$ Please select��5.   l   .@�5/      �� $��Divide��6   6.   �� 50      $��Multiplication��6   66   �� 51      $��	Summation��6   61   �� 52      $��Subtraction��6   63   53      54      57      
   M S B A M L   `   `   `  ����L  HStudentManageCRUD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:StudentManageCRUDStudentManageCRUD  5   	   #    StudentManageCRUD.LoginWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:StudentManageCRUD     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ LoginWindow��5	   	   $	��350��6   $	��350��6*   $	��350��66   $	��350��6F    � 
ResizeMode$ NoResize=�6U   .��5
      � $	��350��6   $	��350��6    � RowDefinitions 5   
   �� 5      $
��1.5* �6   �� 5      $��2* �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ LblTitle��5      $��Student Manager��6"   $��Center=�6<   $��Center=�6Y   $��30(�6t   � 5   
   $��1��6    5      �� 5      $��* �6    �� 5      $��* �6    �� 5      $��* �6     � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��3* �6#   .+�5      �� -   5        $ 
LbUsername��5      $��Username��6(   $��Center=�6;   $
��Left=�6V   $��10q�6q   �� 5      -   5         ��Name$ 
TbUsername��5      $��1��6*   $��Stretch=�6:   $��Stretch=�6X   $��10q�6t   $��23��6�   ��6�   �� *
Username+�� 5      -   5        $ 
LbPassword��5      $��1��6(   $��Password��65   $��Center=�6H   $
��Left=�6c   $��10q�6~   �� 5      -   5        $ 
TbPassword��5      $��1��6*   $��1��68   $��Stretch=�6H   $��Stretch=�6f   $��10q�6�   $��23��6�   ��6�   �� *
Password+�� 5      -   5        $ LbSource��5      $��2��6&   $��Source��63   $��Center=�6D   $
��Left=�6_   $��10q�6z   �� 5       -   5         ��Name$ CbSource��5       $��1��6)   $��2��69   $��Stretch=�6F   $��Stretch=�6d   $��10q�6�   $��23��6�    �� SelectedIndex 6�   �� *SelectedResourceIndex+.@�5!      �� -   5        $	��xml��5!      .��6*   
XML file64   �� 5"      -	   5        $	��txt��5"      .��6*   	Text file65   �� 5#      -
   5        $��db��5#      .��6)   
Database63   5$      5%      �� 5&   
   -   5        	 ��Name$	 BtnLogin��5&      $��Log In��6#   $��Stretch=�64   $��2��6R   $��Stretch=�6_   $��10q�6{   $��18(�6�   ���#2980b9
���������6�   �� 
 �� Path$
 LoginCommand�5'      5(      
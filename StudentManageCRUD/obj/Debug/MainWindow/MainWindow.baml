   M S B A M L   `   `   `  ����L  HStudentManageCRUD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:StudentManageCRUDStudentManageCRUD  5   	   "    StudentManageCRUD.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:StudentManageCRUD     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � WindowState$ 	Maximized=�5	   	    � Title$ 
MainWindow��5
   	   $	��350��6   $	��525��6)   $	��350��65   $	��525��6E   .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      $��4* �6   �� 5      $��50 �6   .+�5   
   �� -   5         ��Name$ LbTitle��5      $��Student Manager��6!   $��Center=�6;   $��Center=�6X   $��30(�6s   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
DgStudents��5      $��Stretch=�6'   $��1��6E   $��Stretch=�6R   $��10q�6n      AutoGenerateColumns .     CanUserResizeColumns . 	   CanUserAddRows	 .  ��6z   �� *
Students+
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6H      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+6R     5      $
 Name��6%   $ 3* 6L    .  63   �� *Name+6W     5      $ Lastname��6%   $ 3* 6T    .  67   �� *
Lastname+6_     5      $ Height��6%   $ 2* 6P    .  65   �� *Height+6[   4  .System.Windows.Controls.DataGridCheckBoxColumn  5      $ Valid��6)    . $ * 6x    68   ��  �� Path$ IsValid� �� Mode$ OneWay=�6x   4  .System.Windows.Controls.DataGridTemplateColumn  5      $
 1.5* 6)      CellTemplate 5      �� 5      .R�5      �� $��Update��6%   $��Stretch=�66   $��Stretch=�6T   $��12(�6p   ���#f1c40f
���������6�   �� $ DataContext.UpdateCommand� �� RelativeSource �� *FindAncestor+ �� AncestorType"  ��6'  �� 5       5"        5#      $
 1.5* 6)    5$      �� 5%      .R�5&      �� $��Delete��6%   $��Stretch=�66   $��Stretch=�6T   $��12(�6p   ���#e74c3c
���������6�   �� $ DataContext.DeleteCommand� �� *FindAncestor+"  ��6'  �� 5'      5)        5*      $
 1.5* 6)    5+      �� 5,      .R�5-      �� $��Career��6%   $��Stretch=�66   $��Stretch=�6T   $��12(�6p   ���#2980b9
���������6�   �� $% DataContext.CareerSelectCommand� �� *FindAncestor+"  ��6-  �� 5.      50      52      �� 53   
   $��3��6    �� Orientation$ 
Horizontal=�6"   $��Right=�6;   .+�54      �� $��Search��6   $��Stretch=�6&   $��Stretch=�6D   $��12(�6`   $��10q�6n   $	��100��6z   ���#2980b9
���������6�   �� $ SearchCommand��� 55      $	��Add��6   $��Stretch=�6#   $��Stretch=�6A   $��12(�6]   $��10q�6k   $	��100��6w   ���#2ecc71
���������6�   �� $ 
AddCommand�56      57      58      
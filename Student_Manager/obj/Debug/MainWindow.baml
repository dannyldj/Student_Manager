   M S B A M L   `   `   `  ����J  FStudent_Manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Student_ManagerStudent_Manager  5   	        Student_Manager.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Student_Manager     5   	     � Title$  Student Manager��5   	   $	��250��6!   $	��405��6.    � 
ResizeMode$ CanMinimize=�6:    � WindowStyle$ 
ToolWindow=�6S    � 	Resources 5	         itemMenu m� Command��%�   &	        �� 5
   
   .@�5      m� $��_Edit��6    6&   �� *EditCommand+m� 5      $��_Delete��6    6(   �� *
DelCommand+5      5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��1* �6    � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��5* �6   �� 5      $��5* �6   �� 5      $
��Auto �6   .+�5   
   �� -   5        $��_SName��5      $
��Name��5      $��0��6   $
��Left=�6,   $��1��6G   $��Center=�5      �� 5   
   -   5        $��_Department��5       $��
Department��5      $��0��6%   $
��Left=�62   $��2��6M   $��Center=�5    #   �� 5!   
   -   5        $��StudentListView��5!      $��Stretch=�6*   $��1��6F   $��5��6S   $��3��6d    � ContextMenu# [  5"      ��6;   �� *
Students+��5#      �� 5$      .R�5%      � .+�5'      �� $��1��6;   ��6$   �� *SName+6;   �� 5(      $��2��6@   ��6$   �� *
Department+6@   5)      5*      5,      �� 5-   
   -   5        $
��Info��5.      $��Student Info��5-      $��0��6'   $
��Left=�64   $��3��6O   $��Center=�5.      �� 5/   
   -   5        $��SName��5/      $��1��6C   $��3��6P   ��6   �� *InputStudent.SName+6P   �� 50   
   -   5        $��
Department��50      $��2��6N   $��3��6[    �� Text 6%   �� *InputStudent.Department+.@�51      �� $��	윈도우��6   �� 52      $��서버��6   �� 53      $	��웹��6   �� 54      $��	모바일��6   55      �� 56   
   -   5        $��btnAdd��57      $	��Add��56      $��3��6   $��Center=�6,   $��3��6I   ��57      �� *
AddCommand+58      59      
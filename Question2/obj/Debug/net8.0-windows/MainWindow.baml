   M S B A M L   `   `   `  ����D  @Question2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Question2	Question2  5   	       Question2.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Question2     5   	     � Title$  
MainWindow��5   	   $	��800��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      $��60 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   .+�5    
   �� -   5         ��Name$ Label��5       $��Employee Information��6   $��30(�6>   $
��Left=�6L   $��Center=�6g   �� 5!   
   $��Employee Id
��6   $
��Left=�60   $��1��6K   $��Center=�6X   �� 5"   
   $��Employee Name
��6   $
��Left=�62   $��3��6M   $��Center=�6Z   �� 5#   
   $��Gender
��6   $
��Left=�6+   $��5��6F   $��Center=�6S   �� 5$   
   $��Date of Birth
��6   $
��Left=�62   $��7��6M   $	��Top=�6Z   �� 5%   
   $��Phone��6   $
��Left=�6    $��9��6;   $��0,0,0,4q�6H   �� 5&   
   $��ID Number
��6   $
��Left=�6.   $��11��6I   $	��Top=�6W   �� 5'   
   -   5         ��Name$ txtId��5'      $��Center=�6!   $��2��6>    �� TextWrapping$
 Wrap=�6K   $��Center=�6_   $	��400��6z   $��30��6�   �� 5(   
   -   5        $ txtName��5(      $��Center=�6#   $��4��6@   $
 Wrap=�6M   $��Center=�6a   $	��400��6|   $��30��6�   �� 5)   
   -   5        $ txtPhone��5)      $��Center=�6$   $��10��6A   $
 Wrap=�6O   $��Center=�6c   $	��400��6~   $��30��6�   �� 5*   
   -   5        $ txtIdNum��5*      $��Center=�6$   $��12��6A   $
 Wrap=�6O   $��Center=�6c   $	��400��6~   $��30��6�   (  "System.Windows.Controls.DatePicker  5+   
   -   5          Name$ txtDb��5+      $��Center=�6$   $��8��6A   $��Center=�6N   $	��400��6i   $��30��6u   	� 5,   
   -   5         	�Name$ trdMale��5,      $
��Male��6'    	� 	GroupName$ Gender��66   $
��Left=�6I   $��6��6d   $��Center=�6q   	 d� 	IsChecked$
	 TrueY�6�   	� 5-   
   -   5        $ 	trdFemale��5-      $��Female��6)   $ Gender��6:   $
��Left=�6M   $��6��6h   $��Center=�6u   $��	100,0,0,0q�6�   &   System.Windows.Controls.DataGrid  5.   
   -	   5        
  Name$
 DgData��5.   !   $��13��6   $��2��61   $��0,28,0,-334q�6E      AutoGenerateColumns$ False��6�      Columns 5/      0  *System.Windows.Controls.DataGridTextColumn  50      ,  &System.Windows.Controls.DataGridColumn   Header$ 
EmployeeId��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 69   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6C   �� *Id+  51      $ Employee Name��6%   $ * 6<    6F   �� *Name+  52      $ Employee Name��6%   $ * 6<    6F   �� *Gender+  53      $ Date of birth��6%   $ * 6<    6F   �� *Dob+  54      $ Phone��6%   $ * 64    6>   �� *Phone+  55      $ 	ID number��6%   $ * 68    6B   �� *
Idnumber+57      �� 58   
   -
   5        $��Refresh��58      $
��Left=�6#   $��30,3,0,0q�6>   $��13��6P   $	��Top=�6^   6v   �� 59   
   -   5        $	��Add��59      $
��Left=�6   $��	103,0,0,0q�6:   $��13��6M   $��Center=�6[   6v   �� 5:   
   -   5        $
��Edit��5:      $
��Left=�6    $��	152,0,0,0q�6;   $��13��6N   $��Center=�6\   6w   �� 5;   
   -   5        $��Delete��5;      $
��Left=�6"   $��	200,0,0,0q�6=   $��13��6P   $��Center=�6^   6y   5=      5>      
   M S B A M L   `   `   `  ????A  =test_A, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:test_Atest_A  5   	       test_A.Detail   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:test_A     5   	     ? Title$  Detail??5   	   $	??450??6   $	??855??6%   .??5	      ?? $??2??6T   $??	0,0,-71,0q?6a    ? DataContext 6   ??  ?? Path$ SelectedItem? ?? ElementName$ dtg_Grddetail????5
   
   ?? 5       ?? ImageSource$ /m1.jpg??6   .+?5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dtg_Grddetail??5      $
??Left=?6*   $	??247??5      $??
19,102,0,0q?6   $	??Top=?5      $	??432??5         AutoGenerateColumns$ False??5         SelectionMode$ Single=?6)      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 
Patient Id??6F   
   
IsReadOnly$

 True??6Z   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ?? *
Patient_id+6Z     5      $	 Patient Name??6F   $

 True??6\    6%   ?? *Patient_name+6\     5      $	 Date Of Registration??6N   $

 True??6l    6%   ?? *date_of_registration+6l   5      ?? 5   
   -   5         ??Name$ LblPatientId??5      $??
Patient ID??6&   $??28??6;   $??77??6G   $
??Bold"?6R   $??14(?6d   $??Arial Unicode MS)?6r    ?? Left$	 469??6?   
 ?? Top$ 55??6?   ?? 5   
   -   5        $ LblPatientName??5      $??Patient Name??6(   $??28??6?   $??97??6K   $
??Bold"?6V   $??14(?6h   $??Arial Unicode MS)?6v   $	 469??6?   $	 105??6?   ?? 5   
   -   5        $ LblPatientRegistration??5      $??Date Of registration??60   $??28??6O   $	??137??6[   $
??Bold"?6g   $??14(?6y   $??Arial Unicode MS)?6?   $	 469??6?   $	 155??6?   ?? 5   
   -   5         ??Name$ TxtPatientID??5      $??28??6I    ?? TextWrapping$
 Wrap=?6V   $	??222??6j   
???????$??Stretch=?6?   $
??Auto=?6?   $??Hidden=?6?   $	 608??6  $ 55??6"   ?? IsReadOnlyCaretVisible$
 True??62  ??6(   ?? $ 
Patient_id?62  ?? 5   
   -   5        $ TxtPatientName??5      $??28??6M   $
 Wrap=?6Z   $	??222??6n   
???????$??Stretch=?6?   $
??Auto=?6?   $??Hidden=?6?   $	 608??6  $	 105??6&  ??6*   ?? $ Patient_name?6&  ?? 5    
   -   5        $ TxtPatientRegistration??5       $??28??6]   $
 Wrap=?6j   $	??222??6~   
???????$??Stretch=?6?   $
??Auto=?6?   $??Hidden=?6?   $	 608??6$  $	 155??66  ??62   ?? $ date_of_registration?66  ?? 5"   
   -   5         ??Name$ BtnSave??5"      $	??Add??6"   $??95??60   $??37??6<   $	 492??6^   $	 248??6p   ??5#      ?? 5$       ?? EndPoint$ 0.5,1&?6&    ?? 
StartPoint$ 0.5,0&?67   .??5%      ?  ? Color$ Black??6#   ? 5&      $ White??6#    ? Offset$ 1Q?61   5'      5)      ?? 5+   
   -	   5        $ BtnLoad??5+      $
??Load??6"   $??95??62   $??41??6>   $	 492??6`   $	 308??6r   ??5,      ?? 5-      $ 0.5,1&?6&   $ 0.5,0&?67   .??5.      ? $ Black??6#   ? 5/      $ White??6#   $ 1Q?61   50      52      ?? 54   
   -
   5        $ BtnEdit??54      $
??Edit??6"   $??98??61   $??37??6=   $	 682??6_   $	 248??6q   ??55      ?? 56      $ 0.5,1&?6&   $ 0.5,0&?67   .??57      ? $ Black??6#   ? 58      $ White??6#   $ 1Q?61   59      5;      ?? 5=   
   -   5        $ 	BtnDelete??5=      $??Delete??6$   $??98??65   $??41??6A   $	 682??6e   $	 308??6w   ??5>      ?? 5?      $ 0.5,1&?6&   $ 0.5,0&?67   .??5@      ? $ Black??6#   ? 5A      $ White??6#   $ 1Q?61   5B      5D      ?? 5E   
   -   5        $
??name??5E       ?? DisplayMemberPath$ Doctor??6H   $ 47??6c   $ 39??6t   $	??132??6?   $??30??6?   ??6   ?? $ doctor_name? ?? ItemBindingGroup 5F      &   System.Windows.Data.BindingGroup  5G      5I      5K      5L      
   M S B A M L   `   `   `  ????A  =test_A, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:test_Atest_A  5   	       test_A.Register   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:test_A     5   	     ? Title$  Register??5   	   $	??570??6   $	??800??6'    ? WindowState$ 	Maximized=?63   .??5	      ?? ??5
   
   ?? 5       ?? ImageSource$ /m2.jpg??6   .+?5   
   ?? -   5         ??Name$ lb_username??5      $??	USER NAME??6%   $??38??69   $	??108??6E   $
??Bold"?6Q   $??Arial Unicode MS)?6c   $??14(?6?    ?? Left$ 78??6?   
 ?? Top$ 76??6?   ?? 5   
   -   5        $ lb_fullname??5      $??	Full NAME??6%   $??38??69   $??94??6E   $
??Bold"?6P   $??Arial Unicode MS)?6b   $??14(?6?   $ 78??6?   $	 120??6?   ?? 5   
   -   5        $ lb_email??5      $??EMAIL ID??6"   $??43??65   $??94??6A   $
??Bold"?6L   $??Arial Unicode MS)?6^   $??14(?6|   $ 78??6?   $	 163??6?   ?? 5   
   -   5        $ lb_phonenumber??5      $??PHONE NUMBER??6(   $??36??6?   $	??149??6K   $
??Bold"?6W   $??Arial Unicode MS)?6i   $??14(?6?   $ 78??6?   $	 216??6?   ?? 5   
   -   5        $ 	lb_gender??5      $??GENDER??6#   $??34??64   $??94??6@   $
??Bold"?6K   $??Arial Unicode MS)?6]   $??14(?6{   $ 78??6?   $	 264??6?   ?? 5   
   -   5        $ lb_Dob??5      $??Date Of Birth??6    $??34??68   $??94??6D   $
??Bold"?6O   $??Arial Unicode MS)?6a   $??14(?6   $ 78??6?   $	 302??6?   ?? 5   
   -   5        $ lb_password??5      $??PASSWORD??6%   $??35??68   $??94??6D   $
??Bold"?6O   $??Arial Unicode MS)?6a   $??14(?6   $ 78??6?   $	 353??6?   ?? 5   
   -   5        $ lb_confirmpassword??5      $??CONFIRM PASSWORD??6,   $??46??6G   $	??173??6S   $
??Bold"?6_   $??Arial Unicode MS)?6q   $??14(?6?   $ 78??6?   $	 403??6?   ?? 5   
   -	   5         ??Name$ lb_register??5      $??REGISTER??6&   $??61??69   $	??182??6E   $	 271??6k   $	 477??6}   ??5      ?? 5       ?? EndPoint$ 0.5,1&?6&    ?? 
StartPoint$ 0.5,0&?67   .??5      ? 	 ? Color$	 Black??6#   ? 5      $	 White??6#   
 ? Offset$
 1Q?61   5      5      ?? 5    
   -
   5         ??Name$ txt_username??5       $??38??6(    ?? TextWrapping$
 Wrap=?65   $	??396??6I   $	 271??6U   $ 76??6g   ?? 5!   
   -   5        $ txt_fullname??5!      $??38??6(   $
 Wrap=?65   $	??396??6I   $	 271??6U   $	 120??6g   ?? 5#   
   -   5        $ 	txt_email??5#      $??43??6%   $
 Wrap=?62   $	??396??6F   $	 271??6R   $	 163??6d   ?? 5$   
   -   5        $ txt_phonenumber??5$      $??46??6+   $
 Wrap=?67   $	??396??6K   $	 271??6W   $	 211??6i   	? 5&   
   -   5         	?Name$ rdo_male??5&      $
??MALE??6(   $??21??67   $	??110??6C   $
??Bold"?6O   $??Arial Unicode MS)?6a   $??14(?6   
???   ?$	 271??6?   $	 270??6?   ??5'      ?? 5(      $ 0.5,1&?6&   $ 0.5,0&?67   .??5)      ? $	 Black??6#   ? 5*      $	 White??6#   $
 1Q?61   5+      5-      	? 5.   
   -   5        $ 
rdo_female??5.      $??FEMALE??6*   $??21??6;   $	??104??6G   $
??Bold"?6S   $??Arial Unicode MS)?6e   $??14(?6?   
???   ?$	 393??6?   $	 270??6?   ??5/      ?? 50      $ 0.5,1&?6&   $ 0.5,0&?67   .??51      ? $	 Black??6#   ? 52      $	 White??6#   $
 1Q?61   53      55      	? 56   
   -   5        $ rdo_prefernotosay??56      $??PREFER NO TO SAY??61   $??36??6L   $	??165??6X   $
??Bold"?6d   $??Arial Unicode MS)?6v   $??14(?6?   
???   ?$	 502??6?   $	 270??6?   ??57      ?? 58      $ 0.5,1&?6&   $ 0.5,0&?67   .??59      ? $	 Black??6#   ? 5:      $	 White??6#   $
 1Q?61   5;      5=      ?? 5>   
   -   5        $ 	btn_login??5>      $??Login??6$   $??61??64   $	??158??6@   $	 509??6d   $	 477??6v   ??5?      ?? 5@      $ 0.5,1&?6&   $ 0.5,0&?67   .??5A      ? $	 Black??6#   ? 5B      $	 White??6#   $
 1Q?61   5C      5E      G? 5F   
   -   5         G?Name$ 
p_password??5F      $??49??6*   $	??396??66   $	 271??6B   $	 346??6T   G? 5G   
   -   5        $ p_confirmpassword??5G      $??46??61   $	??396??6=   $	 271??6I   $	 400??6[   ?? 5I   
   $??AirLines??6   $
??Left=?6#   $??	38,10,0,0q?6>   $	??Top=?6Q   $??45??6i   $	??148??6u   $
??Bold"?6?   $??Algerian)?6?   $??24(?6?   ??5J      ?? 5K      $ 0.5,1&?6&   $ 0.5,0&?67   .??5L      ? $	 Black??6#   ? 5M      $	 	#FFB9B2C0??6#   $
 1Q?65   5N      5P      (  "System.Windows.Controls.DatePicker  5Q   
   -   5          Name$ Dp_Dob??5Q      $??45??6%   $	??396??61   $	 271??6=   $	 296??6O   5S      5U      
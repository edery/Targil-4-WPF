   M S B A M L   `   `   `  ����B  >Targil3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:Targil4Targil4  5   	   R NWPFMitsuControls, Version=1.0.5598.30188, Culture=neutral, PublicKeyToken=nullM8clr-namespace:WPFMitsuControls;assembly=WPFMitsuControlsWPFMitsuControls 5   	       Targil4.OpendBook   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   'localclr-namespace:Targil4     5   	   UWPFMitsuControls8clr-namespace:WPFMitsuControls;assembly=WPFMitsuControls     5   	     � Title$  	OpendBook��5   	   $	��600��6   $	��450��6(    � AllowsTransparency .  � WindowStyle$
 None=�6N    � WindowStartupLocation$ CenterScreen=�5       � 	Resources 5	         scaleUpX �� ScaleX  scaleUpY �� ScaleY��%J   &	        &	      �� 5
   
   $ 1Q�6*   �� 5   
   $ 1Q�6*   5      ��5      �� 5   
    �� Opacity$ 0Q�6   ��5      �� 5   
    �� 
TargetType" �6   	 �� Triggers	 5      :� 5      
 :� RoutedEvent$
 Loaded��6   .[�5      ��  ��Name$ OpenBookAnimation��6&   .��5      �� .��5      W�  �� Target# [  6.    �� TargetProperty$ ScaleX�5   .    W� From$ 1X�5   .   	 W� To$ 3X�67    g� Duration$ 0:0:5D�6>   W� 5      # [ 6.   $ ScaleY�5   .   $ 1X�5   .   $ 3X�67   $ 0:0:5D�6>   5      5      5      5       .��5#      � $	��200��6   $	��150��6   $��Right=�6$   $	��Top=�6@   .+�5&   
     WPFMitsuControls.Book  -   5          Name$ theBook��5&       $��0,0,0,0q�61   $	��200��6B   $	��150��6O   
���   �.@�5'         Targil4.UCfirstPage    5(        5)        5*      5,      z�5/   
   �� 50       6   �� *scaleX+ �� Source# [   51      �� *scaleY+# [ 54      55      
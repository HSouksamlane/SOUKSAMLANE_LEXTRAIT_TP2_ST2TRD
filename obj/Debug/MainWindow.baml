   M S B A M L   `   `   `  ����S  OSOUKSAMLANE_LEXTRAIT_TP2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:SOUKSAMLANE_LEXTRAIT_TP2SOUKSAMLANE_LEXTRAIT_TP2  5   	   )    #SOUKSAMLANE_LEXTRAIT_TP2.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:SOUKSAMLANE_LEXTRAIT_TP2     5   	   U QWpfAnimatedGif, Version=2.0.0.0, Culture=neutral, PublicKeyToken=9e7cd3b544a090dc,gif"http://wpfanimatedgif.codeplex.com  5   	     � Title$D  >Encryptor_Decryptor WPF Application - TP2 SOUKSAMLANE_LEXTRAIT��5	   	   $	��450��6P   $	��540��6]    � 
ResizeMode$ NoResize=�6i    � WindowStartupLocation$ CenterScreen=�5
   	    � 	Resources 5         FocusVisual �� Property �� Value �� StrokeDashArray J� SnapsToDevicePixels  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 DecodeButton	 �� 
TargetType
 �� 
TargetType ��Name �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName��%R  &	        &	 �     &	 �     &	 �     &	     &	 6    &	 Y    &	 |    &	 �    &		 �    &	
 �    7   7  7  7  7  7  7  7 	 �� 5   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$   $	 1 2R�6/   #��� ��6E    . $��1��6�   5      5      5      �� 5   
   $ 	#FFDDDDDD��6;   �� 5   
   $ 	#FF707070��67   �� 5   
   $ 	#FFBEE6FD��6>   �� 5   
   $ 	#FF3C7FB1��6:   �� 5   
   $ 	#FFC4E5F6��6<   �� 5   
   $ 	#FF2C628B��68   �� 5   
   $ 	#FFF4F4F4��6=   �� 5   
   $ 	#FFADB2B5��69   �� 5   
   $ 	#FF838383��6=   �� 5   
   "	 ��6%   .�5      ��  �@�FocusVisualStyle8   61   �� 5        � ��8  6+   �� 5!       � ��8  6,   �� 5"       � ��# � ��6+   �� 5#       � ��$ 0q�60   �� 5$       � ��$ Center=�6;   �� 5%       � ��$ Center=�69   �� 5&       � ��$ 1q�6(   �� 5'       � �� 5(      �� 5)      "
 ��6&   .R�5*      �� $ border��6!   #��z��61   $ 10��6[   #��z��6m   #��z��6�    . ._�5+      �� $ contentPresenter��6/   |�.  #��z��6[   #��z��6�   ��. # z 6�   #��z��6  5,       5-      P� 5.       �@��IsDefaulted . . �5/   "   �� $ border��6@   # � ��6T    � ��50      P� 51       �@J�IsMouseOver . . �52   "   �� $ border��6?    � �� �#FFEE956S   �� 53   "   $ border��6@    � ��
 ���� 6T   54      P� 55       � �� . . �56   "   �� $ border��6?   8   � ��6S   �� 57   "   $ border��6@   8   � ��6T   58      P� 59       � {� .  . �5:   "   �� $ border��6?   8   � ��6S   �� 5;   "   $ border��6@   8   � ��6T   �� 5<   "   $ contentPresenter��6K   8   � ��6i   5=      5?      5A      5B      5C      .��5E      � .+�5F   
   �� ���#FFB485.+�5N      �� $
��Auto��6   $��60��6!   $ ��code_decode_algorithms.png��6-   $��Stretch=�6Q    J� RenderTransformOrigin$	 1,1&�6o   � 5O      $��35��6   $��	12,10,0,0q�6    � ColumnDefinitions 5P      �� 5Q      �� 5R      .+�5U      �� -   5         ��Name$ Result��5U      $�� ��6(   $��1��63   $��Center=�6C   5V      � 5X      $	��200��6   $��	12,10,0,0q�6     5Y      �� 5Z      $	��480 �6'   .+�5\      � $	��195��6   $��0,0,0,0q�6$   
������  5^      �� 5_      $��9.667 �6+   �� 5`      $	��200 �6+   �� 5a      $��80 �6+   �� 5b      $	��167 �6+   �� 5c      $��33 �6+   .+�5f      �� -   5         ��Name$ InputTextBox��5f      $=��7Please input here the text you want to encrypt/decrypt ��64   $��1��6s    �� TextWrapping$
 Wrap=�6�    �� AcceptsReturn . " �� VerticalScrollBarVisibility$
 Auto=�6�   $��	10,0,70,0q�6�   $��2��6�   �� 5g      "  WpfAnimatedGif.ImageBehavior   AnimatedSource$ animated_arrow.gif��6   $
��Auto��6R   $��2��6_   $	��195��6p   $��Stretch=�6~   $	 1,1&�6�   $��15,0,5,0q�6�   �� 5h      -   5        $ OutputTextBox��5h      $�� ��65   $��2��6=   $
 Wrap=�6M    . $
 Auto=�6v   $��3��6�   $��71,0,9,0q�6�   5i      5k      � 5l      -   5         �Name$ vigenere_keyBox��5l      $y�	Collapsed=�6,   $��0,10,0,0q�6C    5m      �� 5n      $	��160 �6'   �� 5o      $	��180 �6'   �� 5p      .+�5r      �� $��Enter the Key :��6   $��30, 0q�62   �� 5s      -   5        $ vigenere_key��5s      $��1��60   $��30, 0q�6@   $��20��6O   $��Mykey��6[   5t      � 5u      $��40��6   $��0,10,0,0q�6    5v      �� 5w      $	��160 �6'   �� 5x      $��130.333 �6'   �� 5y      $��49.667 �6'   �� 5z      .+�5|      �� -   5         ��Name$ EncryptionComboBox��5|      $	��100��67   $��Center=�6C    �� SelectedIndex$ 0��6`   $
��30,8q�6r   .@�5}      �� $��Caesar��6#   �� 5~      $��Binary��6#   �� 5      $��Vigenere��6#   5�      �� 5�      -   5         ��Name$ ConvertCheckBox��5�      $��
Decryption��64   $��1��6I   $��20��6Y   $��Center=�6e   $��Center=�6�   $	��112��6�   $��2��6�   $��34,10q�6�   �� 5�      -   5         ��Name$ decodeButton��5�      $��3��6/   #��� 
 6?   ���#FF5757$��	Encrypt !��6�   $
��30,5q�6�   
������ 6�   5�      5�      5�      5�      
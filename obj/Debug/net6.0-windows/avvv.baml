   M S B A M L   `   `   `  ����=  9ll, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:llll  5   	       ll.avvv   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:ll     5   	   ���#fae6b4$	��450��5	      $	��800��6     � 
ResizeMode$  NoResize=�6     � WindowStyle$ 
ToolWindow=�66    � Title$ 	Authorize��5
       � 	Resources 5         TextBlockStyle1 �� 
TargetType �� Property �� Value  FocusVisual �� StrokeDashArray J� SnapsToDevicePixels  Button.Static.Background	 �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background 	 Button.Disabled.Border 
 Button.Disabled.Foreground  ButtonStyle1
 �� 
TargetType ��Name ��Name �� Triggers P� Property P� Value �� 
TargetName��%z	  &	        &	 &    &	 �    &	 �    &	     &	 B    &	 e    &	 �    &	 �    &		 �    &	
 �    &	     7  �� 5   
   " ��6(   .�5      ��  � ��$ NoWrap=�6-   �� 5       � ��$
 None=�6-   �� 5       � ��$ 50(�6)   �� 5       �@��TextAlignment$ Center=�6.   �� 5       � ��$ Book Antiqua)�6+   �� 5       �@��Padding$ 30q�6(   5      �� 5   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$   $	 1 2R�6/   #��� ��6E   $
 true��6�   $��1��6�   5      5      5      �� 5   
   $	 	#FFDDDDDD��6;   �� 5   
   $	 	#FF707070��67   �� 5   
   $	 	#FFBEE6FD��6>   �� 5    
   $	 	#FF3C7FB1��6:   �� 5!   
   $	 	#FFC4E5F6��6<   �� 5"   
   $	 	#FF2C628B��68   �� 5#   
   $	 	#FFF4F4F4��6=   �� 5$   
   $	 	#FFADB2B5��69   �� 5%   
   $	 	#FF838383��6=   �� 5&   
   " ��6%   .�5'      ��  �@�FocusVisualStyle8   61   �� 5(       � ��
 �����6+   �� 5)       � �� �	#990000006,   �� 5*       � ��# � ��6+   �� 5+       � ��$ 1q�60   �� 5,       � ��$ Center=�6;   �� 5-       � ��$ 25(�6)   �� 5.       � ��$ Book Antiqua)�6+   �� 5/       � ��$ Center=�69   �� 50       � ��$ 1q�6(   �� 51       � �� 52      �� 53      "
 ��6&   .R�54      �� $ border��6!   #��z��61   #��z��6[   #��z��6�   $
 true��6�   ._�55      �� $ contentPresenter��6/   $|�False��6I   #��z��6[   #��z��6�   $
��True��6�   # z 6�   #��z��6  56       57      P� 58       �@��IsDefaulted$
 true��6=   . �59   "   �� $ border��6@    � ��
 ���� 6T   5:      P� 5;       �@J�IsMouseOver$
 true��6=   . �5<   "   �� $ border��6?    � �� �#ffc08a6S   �� 5=   "   $ border��6@    � �� �	#990000006T   �� 5>   "   $ contentPresenter��6K    � ��$
 Bold"�6i   5?      P� 5@       � ��$
 true��6;   . �5A   "   �� $ border��6?    � �� �#ffa5576S   �� 5B   "   $ border��6@    � �� �	#990000006T   5C      P� 5D       � {�$ false��6;   . �5E   "   �� $ border��6?    � ��
 ���� 6S   �� 5F   "   $ border��6@    � ��
 ���� 6T   �� 5G   "   $ contentPresenter��6K    � ��
 ���� 6i   5H      5J      5L      5M      5N      .��5P      �  � RowDefinitions 5Q   
   �� 5R      �� 5S      �� 5T      �� 5U      �� 5V      .+�5X   
   �� #���   6   $��Вход��6>   �� 5Y   
   
���   �$��2q�6+   $��Stretch=�6?   $	��Top=�6]   $	��600��6u   $��100,0,100,0q�6�   $��1��6�   �� 5Z   
   $��
Логин��6   #���   6!   $��30(�6K    �� TextAlignment$
 Left=�6Y   $��70,0,0,0q�6n   $��1��6�   �� 5[   
   -   5         ��Name$	 log��5[      $��1��6   $��220,30,100,20q�6,   $��Book Antiqua)�6a   $��20(�6{   �� 5\   
   $��Пароль��6   #���   6"   $��30(�6L   $
 Left=�6Z   $��70,0,0,0q�6o   $��2��6�   G� 5]   
   -   5         G�Name$
 pass��5]      $��2��6$   $��220,30,100,20q�61    G� PasswordChar$ *��6H   $��Book Antiqua)�6�   $��20(�6�   �� 5^   
   -   5         ��Name$ EnterGO��5^   H   #���  6   $��
Войти��68   $��3��6Y   $��Center=�6f   $	��300��6�   $
��0,10q�6�    �� 	IsDefault$
 True��6�   5_      5`      
   M S B A M L   `   `   `  ���� D  @Crypto V2, Version=0.0.0.1, Culture=neutral, PublicKeyToken=null%clr-namespace:Crypto_V2	Crypto_V2  O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem     Crypto_V2.App   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     )localclr-namespace:Crypto_V2     9System&clr-namespace:System;assembly=mscorlib       �� 	Resources     Window_Style �� 
TargetType �� Property �� Value �� Rect �� RadiusX �� RadiusY  AutoRization_Style  ListView_Style �� 
TargetType �� CornerRadius	 J� Effect3  -System.Windows.Media.Effects.DropShadowEffect
   ShadowDepth   	Direction   Opacity   
BlurRadius   Color �� Triggers P� Property P� Value  HyperLink_Style  TextBox_Style ��Name �� Triggers �� 
TargetName  TextBlock_Animated :� RoutedEvent g� RepeatBehavior �� TargetProperty �� From	 �� To g� Duration g� AutoReverse  ButtonWithAnimation_Style �� RadiusX �� RadiusY �� ScaleX �� ScaleY  �� CenterX! �� CenterY  PasswordBox_Style  ComboBox_Style" ��Name# d�Name$ �� 	ClickMode% d� 	IsChecked& �� Mode' �� RelativeSource'  !System.Windows.VisualStateManager(   VisualStateGroups%  System.Windows.VisualStateGroup)   States   System.Windows.VisualState*   
Storyboard+ �� 
TargetName8  2System.Windows.Media.Animation.EasingColorKeyFrame, �� KeyTime- �� Value. ��Name/ �� Padding0 F�Name1 �Name2 � AllowsTransparency3 �� IsDropDownOpen4 J� SnapsToDevicePixels��%1  &	        &	 �     &	 .    &	 �    &	 �    &	 �    &	 �    &	 �    &	 l
    �� " �.���  �@�WindowStyle$
 None=���  �@�AllowsTransparency . ��  �@J�Clip �� $ 0,0,857,483�$ 25Q�$ 50Q��� " �.���  �@�WindowStyle$
 None=���  �@�AllowsTransparency . ��  �@J�Clip �� $ 0,0,300,300�$ 25Q�$ 50Q��� " ��.���  � ��
 �������  � ��
 ���� ��  � ��$ 0q���  � �� �� " ��.R��� #��z��#��z��#��z��$ 25��	   $
 1Q�$	 320Q�$	 0.5Q�$ 55Q�$ #FAEBD7��._��� .���� ��  � �� �� " ��.���  � ��$ 	Agency FB)���  � ��
 �������  � ��$ 25(� P�  �@��
IsSelected . . ���  � ��
 �������  � �� �#FAEBD7�� " ��.���  � ��
 ������� " ��.���  � �� �#f0f0f0��  � �� �#333��  � �� �#ccc��  � ��$ 1q���  � ��$ 0q���  � ��$ 5q���  � ��$ 20(���  � ��$ 30����  � ��$	 150����  � �� �� " ��.R�� .+��� #��z��#��z��#��z��$ 10��._��� $ PART_ContentHost�� P�  � {� .  . ��� $ PART_ContentHost�� �@J�Opacity$ 3Q��� " ��.���  � ��$ 30(���  � ��$ 	Agency FB)���  � ��$
 Bold"���  � ��$ Center=���  � ��$
 Left=� :� $ TextBlock.Loaded��.[��� .���� $ Forever��.���� $4 .(TextBlock.Foreground).(SolidColorBrush.Color)�$ SilverX�$
 GrayX�$ 0:0:5D� . �� " ��.���  � ��$ 60����  � ��$ 50����  � ��
 �������  � ��
 �������  � ��$ 25(���  � ��$ 	Agency FB)���  � ��$
 Left=���  � ��$ Center=���  � ��$ Center=���  � ��$ Center=���  � �� �� " ��.R�� .+��� $��ButtonBackground��#��z��$ 20��$ 50���� $��Center=�$��Center=� P�  �@J�IsMouseOver . . ��� $ ButtonBackground�� � ��
 �����P�  � �� . . ��� $ ButtonBackground�� � �� �#FFB6C1�� $ ButtonBackground�� � z� �� $	 0.9Q�$	 0.9Q�$	  0.5Q�$	! 0.5Q�P�  � �� .  . ��� $ ButtonBackground�� � z� �� $ 1Q�$ 1Q�$	  0.5Q�$	! 0.5Q���  �@J�Effect   $ #FAEBD7��$ 18Q�$
 0Q�$ 2Q��� " G�.���  � �� �#f0f0f0��  � �� �#333��  � �� �#ccc��  � ��$ 1q���  � ��$ 0q���  � ��$ 5q���  � ��$ 20(���  � ��$ 30����  � ��$	 150����  � �� �� " G�.R�� .+��� #��z��#��z��#��z��$ 10��._��� $ PART_ContentHost�� P�  � {� .  . ��� $ PART_ContentHost�� �@J�Opacity$	 0.3Q��� " ��.���  � ��
 ���� ��  � ��
 �   ���  � ��
 ���� ��  � ��$ 1q���  � ��$ 5q���  � ��$ 30����  � ��$	 200����  �@J�Effect   $ #FAEBD7��$ 25Q�$
 0Q�$ 2Q���  � �� �� " ��.R�� .+��� $" ComboBoxBorder��#��z��#��z��#��z��$ 10,10,10,10��._�� .+�d� $# ToggleButton��#��z��#��z��|�.  $$ Press=�% �� *IsDropDownOpen+$& TwoWay=�' �� *TemplatedParent+���� " d�.R�� (   CommonStates��.)   
Normal��  	MouseOver��.* �� .���� $+ Border��$1 +(Border.Background).(SolidColorBrush.Color)�.g�  $, 0��$- Transparent��  Pressed��.* �� .���� $+ Border��$1 +(Border.Background).(SolidColorBrush.Color)�.g�  $, 0��$- Transparent��  Disabled��.* �� .���� $+ Border��$1 +(Border.Background).(SolidColorBrush.Color)�.g�  $, 0��$- Transparent��.+��� $" Border��
�������#��z��$��1q�$ 10,10,10,10���� $. ContentPresenter��#��z��$��Center=�$��Center=�$��8,0,0,0q�#��z��
�������$/ 0,0,0,0q�F� $0 Arrow��$��Center=�$��Center=�$��0,0,8,0q�"����        � 	=  	= � z     	#��z��� $1 Popup��2 . #��z3 $��Bottom=�$	��200��$	��150��$
��Fade=�.���� $" DropDownBorder��
�������#��z��$��1q�$ 10,10,10,10��._��� 4 . .����  
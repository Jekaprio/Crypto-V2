   M S B A M L   `   `   `  ����  	Crypto V2    Crypto_V2.MainWindow   5   
   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  	Crypto V2��5   	    � WindowStyle$
 None=�6    � AllowsTransparency . $	��500��6I   $	��900��6V      Window_Style#��[  5   	   .��5
      � -   5        $��MainGrid��5
      $	��485��6   $	��Top=�5      $��	0,0,-25,0q�6#   
������  J� Opacity$ 0Q�5   $    � Triggers 5   
   :� 5       :� RoutedEvent$ Loaded��6   .[�5      �� .��5      �� .��5      W�  �� 
TargetName$ MainGrid��6*    �� TargetProperty$ Opacity�6K    W� From$ 0X�6o   		 W� To$	 1X�6x   
 g� Duration$
 0:0:2D�6   5      5      5      .+�5   
   �� $
��Left=�6   $��0,60,0,0q�5      $	��Top=�5      
�������$��2q�5       �� CornerRadius$ 25,25,25,25��5      $��90��5      $	��350��6   ._�5      �� -   5        $
��Menu��5   %   $	��242��6   .+�5       �� -   5        $��Home_Button��5!      $
��Home��5"      $��	5,20,0,15q�5#      $��Center=�5$      $��Center=�5%      $��75��5'        ButtonWithAnimation_Style#��[ 5(      �� 5)      -   5        $��Details_Button��5*      $��Details��5+      $
��Left=�5,      $��5,0,0,15q�5-      $��75��5/      #��[ 50      �� 51      -   5        $��Setting_Button��52      $��Setting��53      $
��Left=�54      $��5,0,0,15q�55      $��75��57      #��[ 58      �� 59      -   5        $��
API_Button��5:      $	��API��5;      $��5,0,0,15q�5=      $��75��5>      #��[ 5?      �� 5@      -   5        $��Exit_Button��5A      $
��Exit��5B      $��5,0,0,15q�5D      $��75��5E      #��[ 5F      5H      5I      �� 5J   
   
�������$	��700��6)   $	��400��65   $ 25,25,25,25��5K      ._�5L   
   �� $��0,0,0,0q�6   $	��750��6'   $	��400��63   $��Center=�5M      $��Center=�62   .+�5N   
   �� -   5        $��TextBlockHello��5N      $��20(�6+   $��Center=�5O      $��Center=�62   
������ $
��Wrap=�5P   .   $	��700��6B   $	��400��6N   $��	Agency FB)�5Q      �� 5R      �� 5S      $�   Introducing��6    �� 5T      $�Crypto��6   $
��Bold"�6$   $��Normal$�66    �� 5U      $^�X– your comprehensive companion in the world of cryptocurrencies. With Crypto, you get:��6   �� 5V      �� 5W      �� 5X      $�   Exploration:��6   $
��Bold"�6-   $��Normal$�6?    �� 5Y      $���Dive into the world of digital currencies. Explore the latest cryptocurrencies, including market prices, trading volumes, and historical data.��6   �� 5Z      �� 5[      �� 5\      $�   Conversion:��6   $
��Bold"�6,   $��Normal$�6>    �� 5]      $���Convert one cryptocurrency to another with ease. Calculate exchange rates and switch between different cryptocurrencies effortlessly.��6   �� 5^      �� 5_      �� 5`      $�   Effortless Search:��6   $
��Bold"�63   $��Normal$�6E    �� 5a      $[�UFind specific cryptocurrencies quickly. Our intuitive search helps you stay informed.��6   �� 5b      �� 5c      �� 5d      $�   Visualize Trends:��6   $
��Bold"�62   $��Normal$�6D    �� 5e      $w�qUnderstand cryptocurrency trends with interactive charts. Monitor price fluctuations and make informed decisions.��6   �� 5f      �� 5g      �� 5h      $���   Crypto is your trusted partner in the cryptocurrency world, whether you're an enthusiast, investor, or simply curious. Explore, convert, and thrive with Crypto.��6   5i      5j      5k      �� 5l   
   $��Center=�6   $��Center=�62   5m      �� 5n   
   -	   5        ���#FAEBD7$��20��5o      $ 25,25,25,25��5p      $	��Top=�5q      $��0,0,25,0q�5s      ._�5t      ��  �� Orientation$ 
Horizontal=�5u      $
��Left=�5v      $
��Auto��5w      $��	730,0,0,0q�5x      .+�5y      �� $��	Crypto V2��6   $��Center=�6-   $
��-700q�6H   $��	Agency FB)�5z      $��15(�63   $
��Bold"�6A   
�������5{      5|      5}      �� 5~   
   ���#FAEBD7$��20��5      $ 25,25,25,25��5�      $��Bottom=�5�      $��0,0,25,0q�5�      5�       � 5�   
   -
   5        $��	MainFrame��5�      $��1��6!     � NavigationUIVisibility$ Hidden=�6.   5�      5�      
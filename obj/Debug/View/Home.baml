   M S B A M L   `   `   `  ����D  @Crypto V2, Version=0.0.0.1, Culture=neutral, PublicKeyToken=null/clr-namespace:Crypto_V2.ViewCrypto_V2.View  5          Crypto_V2.View.Home   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:Crypto_V2.View     5      $	��400��5      $	��900��6%     N� Title$
  Home��5       � 	Resources 5
         PageEnterAnimation �� 
TargetName �� TargetProperty W� From	 W� To g� Duration��%�   &	        �� 5   
   .��5      W� $ ContentGrid��6   $ Opacity�5      $ 0X�5      $ 1X�6$   $ 0:0:2D�6+   5      5      .��5      � -   5         �Name$ ContentGrid��5      .+�5   
   �� $
��Left=�5      $��Center=�5      $
��Auto��5      $��45��5      $��120,-350,0,0q�5      .+�5      �� -   5        $��Home_TextBlock��5      $
��Home��5        TextBlock_Animated#��[ 5      $��25,0,0,0q�5      5      �� 5   
   
������ $��Center=�5!      $��Bottom=�5"      $
��Auto��5#      $
��Auto��5$      .+�5%      �� -   5         ��Name$ 	Top10List��5%      $��
0,0,0,-25 q�5&        ListView_Style#��[ 6+   
������ $
��Auto��5(      $
��Auto��6%   $��Center=�62   ��5'      �� *CryptoDataList+	 �� View	 5)      �� 5*      .P�5+      �� $��Id��6)   
 �� Width$
 50��5,   O    �� DisplayMemberBinding 6)   �� *Rank+6O   �� 5-      $
��Name��6)   $	
 100��5.   O    6)   �� *Name+6O   �� 5/      $��Symbol��6)   $
 75��50   Q    6)   �� *Symbol+6Q   �� 51      $��	Price USD��6)   $	
 250��52   S    6)   �� *
PriceUsd+6S   53      55      �� 56      -   5        $
��Save��57      $��75��58      $��40��59        ButtonWithAnimation_Style#��[ 5;      $��Bottom=�5<      $��Center=�5=      $��	620,0,0,0q�5>      5?      5@      5A      
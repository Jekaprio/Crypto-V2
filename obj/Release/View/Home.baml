   M S B A M L   `   `   `  ���� D  @Crypto V2, Version=0.0.0.1, Culture=neutral, PublicKeyToken=null/clr-namespace:Crypto_V2.ViewCrypto_V2.View      Crypto_V2.View.Home   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     .localclr-namespace:Crypto_V2.View     $	��400��$	��900��  N� Title$
  Home�� � 	Resources    PageEnterAnimation �� 
TargetName �� TargetProperty W� From	 W� To g� Duration��%S   &	        �� .��W� $ ContentGrid��$ Opacity�$ 0X�$ 1X�$ 0:0:2D�.��� -    �Name$ ContentGrid��.+��� $
��Left=�$��Center=�$
��Auto��$��45��$��120,-350,0,0q�.+��� -   $��Home_TextBlock��$
��Home��  TextBlock_Animated#��[ $��25,0,0,0q��� 
������ $��Center=�$��Bottom=�$
��Auto��$
��Auto��.+��� -    ��Name$ 	Top10List��$��
0,0,0,-25 q�  ListView_Style#��[ 
������ $
��Auto��$
��Auto��$��Center=����� *CryptoDataList+	 �� View	 �� .P��� $��Id��
 �� Width$
 50�� �� DisplayMemberBinding �� *Rank+�� $
��Name��$	
 100�� �� *Name+�� $��Symbol��$
 75�� �� *Symbol+�� $��	Price USD��$	
 250�� �� *
PriceUsd+�� -   $
��Save��$��75��$��40��  ButtonWithAnimation_Style#��[ $��Bottom=�$��Center=�$��	620,0,0,0q�
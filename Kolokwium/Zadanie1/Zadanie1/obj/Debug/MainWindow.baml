   M S B A M L   `   `   `  ����C  ?Zadanie1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Zadanie1Zadanie1  5   	       Zadanie1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Zadanie1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	         styl �� Property �� Value 
 obrót �� TargetProperty g� 	BeginTime g� Duration W� From	 W� To	 g� RepeatBehavior
 �� 
TargetName��%-  &	        &	 f     �� 5
   
   .�5      ��  � ��
 ��  �63   �� 5       � ��
 �����63   5      �� 5   
   .��5      W� $ Angle�5      $ 0:0:0X�5      $ 0:0:15D�60   $ 0X�5      $	 360X�6'   $	 Forever��5      $
 przycisk��5      5      5      .��5      ��  �� Orientation$ Vertical=�6   .+�5   
   �� -   5        $
��Nie ��5      $	��400��6    $��30��6,   $��10q�68   #��[  6D   z�5      �� 5       �� ScaleX$
 0.75Q�6!    �� ScaleY$
 0.75Q�6/   5       �� 5!   
   -   5        $
��Nie ��5!      $	��400��6    $��30��6,   $��10q�68   #��[  6D   z�5"      �� 5#       �� AngleX$	 -10Q�6    5%      �� 5&   
   -   5        $
��Nie ��5&      $	��400��6    $��30��6,   $��10q�68   #��[  6D   z�5'      �� 5(      -   5        przycisk�� �� Angle$ 0Q�5(   4    � Triggers 5*      :� 5+       :� RoutedEvent$ Button.Loaded��6   .[�5,      �� #��[ 6&   5-      5/      �� 50   
   -   5        $
��Nie ��50      $	��400��6    $��30��6,   $��10q�68   #��[  6D   z�51      T� 52       T� X$ 40Q�6%    T� Y$ 20Q�6,   54      �� 55   
   -   5        $
��Nie ��55      $	��400��6    $��30��6,   $��10q�68   #��[  6D   z�56      �� 57      $
 11.5Q�6"   59      5:      5;      
   M S B A M L   `   `   `  ����K  GWPFUserInterface, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:WPFUserInterface.ViewsWPFUserInterface.Views  5      S.clr-namespace:WPFUserInterface.Custom_Controls WPFUserInterface.Custom_Controls  5      I)clr-namespace:WPFUserInterface.ViewModelsWPFUserInterface.ViewModels  5	      %    WPFUserInterface.Views.ChatPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:WPFUserInterface.Views     5      Icustomcontrols.clr-namespace:WPFUserInterface.Custom_Controls     5      =context)clr-namespace:WPFUserInterface.ViewModels     5	        N� Title$  ChatPage��5      .��5      �    WidgetColorA#��[  6    � ColumnDefinitions 5   
   �� 5      $��90 �6   �� 5      $	��450 �6   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   � $��0��6     BackgroundColor#��[ 6    � RowDefinitions 5      �� 5      $	��100 �6    �� 5      $��* �6    .+�5      6   0WPFUserInterface.Custom_Controls.MenuListControl  $��1��6-   $��0,50,0,0q�6:   5      �� 5    
   $��1��6    �� Orientation$ Vertical=�6%   $��0,30,0,0q�6<   .+�5!      � $��	30,0,30,0q�6    5"      �� 5#      $��* �6'   �� 5$      $��50 �6'   .+�5(      �� $��0��6   
������ $
��auto��6B   $y�Visible=�5)      ._�5*      ��   WidgetColorD#��[ 6   $��50��6H    �� CornerRadius$ 25��6T   $��Stretch=�5+      ._�5,      � $
��auto��6    5-      �� 5.   "   $��50 �63   �� 5/   "   $��* �63   .+�51      �� $��1��6&   $��16(�66   $��Stretch=�6D   $��Stretch=�52   &   $��Center=�6B    �� TextAlignment$
 Left=�6d   $��0q�53   &   
������ $��0,0,10,0q�6S     OnBackgroundColor#��[ 54   &   $��Enter to search...��55   &   56      57      59      5;      �� 5@      $��2��6   $��	.5,0,.5,0q�6%   ���#B7B5B8._�5A      �  5B      �� 5C      $	��100 �6(   �� 5D      $��* �6(   �� 5E      $��80 �6(   .+�5I      �  5J      �� 5K      $
��Auto �6/   �� 5L      $��* �6/   �� 5M      $	��160 �6/   .+�5T      �� $��1��6$   $��Center=�64   �� 5V      $�Tobias Williams��6   $
��Bold"�65   $��17(�6G   �� 5W      �� 5X      $�Offline��6   $��14(�6-   ���#B7B5B86;    �� 5Y      $� • ��6   $��	ExtraBold"�6)   $��19(�6@   ���#B7B5B86N    �� 5Z      $�Last seen 3 hours ago��6   $��14(�6;   ���#B7B5B86I   5[      � 5^      $��3��6    5_      �� 5`   "   .+�5b      A�  A� Columns$ 3��6*   $��
14,30,14,0q�66   $	��Top=�6J   $��Stretch=�6b   5f      5g      5h      � 5p      $��2��6   
�������.+�5q      �� 
������ $��	30,0,30,0q�6\   y�6:   �� *
Visibility+._�5r      � .+�5t   "   �� ���#F8F6F7$��48��6>   $ 25��6J   $��Stretch=�6\   ._�5u   &   � $
��Auto��6+    5v   *   �� 5w   .   $��60 �6?   �� 5x   .   $��* �6?   .+�5|   *   �� -   5         ��Name$ message��5|   B   $��1��62   $��16(�6S   $��Stretch=�6a   $��Stretch=�6   $��Center=�6�   $
 Left=�6�   $��0q�6�   
������ $��	0,0,150,0q�6�   $��2��6  �� 5~   *   $��Type a message here...��64   $��1��6R   $��SemiBold"�6b   $��16(�6x   $
��Left=�6�    �� TextAlignment$
 Left=�6�   $��Center=�6�   ���#B7B5B8	 J� IsHitTestVisible	 .  ��5�   .   �� 5�   2   
 �� 
TargetType"
 ��68   .�5�   6   ��  �� Property � y� �� Value$ 	Collapsed=�6S    �� Triggers 5�   6   �� 5�   :    �� Binding 6F   �� *Text+ �� ElementName$ message�� �� Value  6t   .a�5�   >   ��  � y�$ Visible=�6[   5�   ;   5�   3   5�   +   5�   '   5�   #   �� 5�   "   $ 
Horizontal=�6-   $��Right=�6F   $��0,0,70,0q�6b   5�   #   5�      5�      5�      5�      5�      5�      5�      5�      
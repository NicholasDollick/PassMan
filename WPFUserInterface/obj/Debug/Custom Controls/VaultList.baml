   M S B A M L   `   `   `  ����K  GWPFUserInterface, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:WPFUserInterface.Custom_Controls WPFUserInterface.Custom_Controls  5      I)clr-namespace:WPFUserInterface.ViewModelsWPFUserInterface.ViewModels  5      0    *WPFUserInterface.Custom_Controls.VaultList   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      @local.clr-namespace:WPFUserInterface.Custom_Controls     5      =context)clr-namespace:WPFUserInterface.ViewModels     5        � DataContext  5
      4  .WPFUserInterface.ViewModels.VaultListViewModel  5       � 	Resources 5   
      ChatListBackgroundStyle �� 
TargetType �� Property �� Value �� Triggers �� Binding �� RelativeSource �� AncestorType	 �� Mode
 �� Value  WidgetColorE  WidgetColorC3  -System.Windows.Media.Effects.DropShadowEffect  
DropShadow   
BlurRadius   ShadowDepth   	Direction   Color  ChatIndicatorStyle �� 
TargetType ��Name J� SnapsToDevicePixels �� Orientation � ColumnDefinitions � RowDefinitions4   .WPFUserInterface.Custom_Controls.ProfileButton   DisplayLetters ��Name �� ElementName �� Path  ChatListBoxStyle��%�  &	        7  7  &	 �    &	     7  '�� �    7   &	 �    �� 5      " ��64   .�5      ��  �@��CornerRadius$ 6��61   �� 5       � ��
 ���� 6/   �� 5       � |� .  6.    5      �� 5       6"   �� *IsMouseOver+ �� " ��$	 FindAncestor=�
 True6�   .a�5      ��  � ��8   67   5      �� 5       6"   �� *
IsSelected+ �� " ��$	 FindAncestor=�
 True6�   .a�5      ��  � ��8  67   5      5        5      $ 10Q�62   $ 3Q�6B   $	 360Q�6R   $ #F54A4A��6b   �� 5      " ��6/   .�5      ��  � ��
 ���� 6/   �� 5       � �� 6+   �� *Height+ �� " ��$	 FindAncestor=��� 5        � ��$ 4��6*   �� 5!       � y�$ Hidden=�6/   �� 5"       � ��$
 Left=�68   �� 5#       � |� .  6.   �� 5&       �@J�Effect8   6+    5)      �� 5*       6"   �� *IsMouseOver+ �� " ��$	 FindAncestor=�
 True6�   .a�5+      ��  � �� �#F54A4A67   �� 5,       � y�$ Visible=�67   5-      �� 5.       6"   �� *
IsSelected+ �� " ��$	 FindAncestor=�
 True6�   .a�5/      ��  � �� �#F54A4A67   �� 50       � y�$ Visible=�67   51      54      �� 56      " ��6   .�57      ��  �@J�SnapsToDevicePixels . 68   �� 58       � ��$	 105��6+   �� 59       � �� 6?   �� *HorizontalContentAlignment+ �� " ���� 5:       � �� 6=   �� *VerticalContentAlignment+ �� " ���� 5;       � ��
 ���� 6/   �� 5<       � ��$ 0q�64   �� 5=       � ��$ 0,0,0,5q�6+   �� 5@       �@��
IsSelected 6/   �� *IsChatSelected+�� 5A       � �� 5B      �� 5C      " ��6*   .R�5D      �� $ bd��6%   $��0q�61   
������  . $��Center=�6y   ._�5G   "   �� $ border��6)    . 8��  ._�5H   &   � .+�5N   *   �� $ Vertical=�65   .+�5O   .   � $��20,10,15,10q�63    5P   2   �� 5Q   6   $
��Auto �6G   �� 5R   6   $��* �6G    5T   2   �� 5U   6   $��* �6D   �� 5V   6   $��* �6D   .+�5Z   2      6F   �� *DisplayLetters+� 5_   2   $��1��67   $��13,0,0,0q�6G    5`   6   �� 5a   :   $
��Auto �6H   �� 5b   :   $
��Auto �6H   .+�5f   6   �� $
��Bold"�6]   $��17(�6o   ��6@   �� *ElementName+��5g   :   �� 5i   >   " ��6D    5j   B   �� 5k   F    6R   �� *IsMouseOver+ �� " ��$	 FindAncestor=�
 True6�   .a�5l   J   ��  � ��
 �����6g   5m   G   �� 5n   F    6R   �� *
IsSelected+ �� " ��$	 FindAncestor=�
 True6�   .a�5o   J   ��  � ��
 �����6g   5p   G   5r   ?   5t   7   �� 5x   6   $��15(�6a   $��Right=�6o   ���#B7B5B8��6@   �� *LastMessageTime+6�   5|   3   5~   /   � 5�   .   $��	28,0,28,0q�63   $	��330��6F    5�   2   �� 5�   6   $
��Auto �6G   �� 5�   6   $
��Auto �6G   �� 5�   6   $
��Auto �6G   .+�5�   2   �� $ MsgSent��68   $��0��6I   $��/Images/right.png��6Y   $��Uniform=�6t   $��20��6�   ��5�   6   �� 5�   :   " ��6@   .�5�   >   ��  � y�$ Visible=�6[    5�   >   �� 5�   B    6N   �� $ MsgCount��$ 
Visibility�
 Visible6�   .a�5�   F   ��  � y�$ 	Collapsed=�6c   5�   C   �� 5�   B    6N   �� $ IsRead��
 True6u   .a�5�   F   ��  � y�$ 	Collapsed=�6c   5�   C   5�   ;   5�   3   �� 5�   2   $��1��6<   $��5,0,0,0q�6L   $��14(�6v   $��Center=�6�   ��6]   �� *	Message+��5�   6   �� 5�   :   " ��6@    5�   >   �� 5�   B    6N   �� *IsMouseOver+ �� " ��$	 FindAncestor=�
 True6�   .a�5�   F   ��  � ��
 �����6c   5�   C   �� 5�   B    6N   �� *
IsSelected+ �� " ��$	 FindAncestor=�
 True6�   .a�5�   F   ��  � ��
 �����6c   5�   C   5�   ;   5�   3   5�   /   5�   +   5�   '   5�   #   5�      5�      5�      5�      �� 5�      " ��6-   .�5�      ��  � ��$ 0q�64   �� 5�       � ��
 ���� 6/   �� 5�       � ��$ Stretch=�66   �� 5�       � ��$ Stretch=�68   �� 5�       � |� .  6.   5�      5�      .��5�   
   �� #��[ 6   $��Hidden=�5�      $	��550��5�      ��5�      �� *ChatListItems+5�      5�      
   M S B A M L   `   `   `  ����K  GWPFUserInterface, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:WPFUserInterface.Custom_Controls WPFUserInterface.Custom_Controls  5      I)clr-namespace:WPFUserInterface.ViewModelsWPFUserInterface.ViewModels  5      /    )WPFUserInterface.Custom_Controls.ChatList   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      @local.clr-namespace:WPFUserInterface.Custom_Controls     5      =context)clr-namespace:WPFUserInterface.ViewModels     5        � DataContext  5
      3  -WPFUserInterface.ViewModels.ChatListViewModel  5   
    � 	Resources 5         ChatListBackgroundStyle �� 
TargetType �� Property �� Value �� Triggers �� Binding �� RelativeSource �� AncestorType	 �� Mode
 �� Value  WidgetColorE  WidgetColorC3  -System.Windows.Media.Effects.DropShadowEffect  
DropShadow   
BlurRadius   ShadowDepth   	Direction   Color  ChatIndicatorStyle �� 
TargetType ��Name J� SnapsToDevicePixels �� CornerRadius �� Orientation � ColumnDefinitions � RowDefinitions4   .WPFUserInterface.Custom_Controls.ProfileButton   DisplayLetters   IsOnline ��Name �� ElementName �� Path �Name  ChatListBoxStyle��%9  &	        7  7  &	 �    &	     7  '�� �    7   7  &	     �� 5   
   " ��60   .�5      ��  �@��CornerRadius$ 6��6-   �� 5       � ��
 ���� 6+   �� 5       � |� .  6*    5      �� 5       6   �� *IsMouseOver+ �� " ��$	 FindAncestor=�
 True6�   .a�5      ��  � ��8   63   5      �� 5       6   �� *
IsSelected+ �� " ��$	 FindAncestor=�
 True6�   .a�5      ��  � ��8  63   5      5        5   
   $ 10Q�6.   $ 3Q�6>   $	 360Q�6N   $ #F54A4A��6^   �� 5   
   " ��6+   .�5      ��  � ��
 ���� 6+   �� 5       � �� 6'   �� *Height+ �� " ��$	 FindAncestor=��� 5        � ��$ 4��6&   �� 5!       � y�$ Hidden=�6+   �� 5"       � ��$
 Left=�64   �� 5#       � |� .  6*   �� 5&       �@J�Effect8   6'    5)      �� 5*       6   �� *IsMouseOver+ �� " ��$	 FindAncestor=�
 True6�   .a�5+      ��  � �� �#F54A4A63   �� 5,       � y�$ Visible=�63   5-      �� 5.       6   �� *
IsSelected+ �� " ��$	 FindAncestor=�
 True6�   .a�5/      ��  � �� �#F54A4A63   �� 50       � y�$ Visible=�63   51      54      �� 56   
   " ��6   .�57      ��  �@J�SnapsToDevicePixels . 64   �� 58       � ��$	 105��6'   �� 59       � �� 6;   �� *HorizontalContentAlignment+ �� " ���� 5:       � �� 69   �� *VerticalContentAlignment+ �� " ���� 5;       � ��
 ���� 6+   �� 5<       � ��$ 0q�60   �� 5=       � ��$ 0,0,0,5q�6'   �� 5@       �@��
IsSelected 6+   �� *IsChatSelected+�� 5A       � �� 5B      �� 5C      " ��6&   .R�5D      �� $ bd��6!   $��0q�6-   
������  . $��Center=�6u   ._�5G      �� $ border��6%    . 8��  ._�5H   "   � .+�5J   &   �� $ ChatIndicatorRight��6-   $ 6,0,0,6��6I   8�� 6`   �� 5N   &   $ Vertical=�61   .+�5O   *   � $��20,10,15,10q�6/    5P   .   �� 5Q   2   $
��Auto �6C   �� 5R   2   $��* �6C    5T   .   �� 5U   2   $��* �6@   �� 5V   2   $��* �6@   .+�5Z   .      6B   �� *DisplayLetters+ 5[   B   �� *
IsOnline+� 5_   .   $��1��63   $��13,0,0,0q�6C    5`   2   �� 5a   6   $
��Auto �6D   �� 5b   6   $
��Auto �6D   .+�5f   2   �� $
��Bold"�6Y   $��17(�6k   ��6<   �� *ContactName+��5g   6   �� 5i   :   " ��6@    5j   >   �� 5k   B    6N   �� *IsMouseOver+ �� " ��$	 FindAncestor=�
 True6�   .a�5l   F   ��  � ��
 �����6c   5m   C   �� 5n   B    6N   �� *
IsSelected+ �� " ��$	 FindAncestor=�
 True6�   .a�5o   F   ��  � ��
 �����6c   5p   C   5r   ;   5t   3   �� 5x   2   $��15(�6]   $��Right=�6k   ���#B7B5B8��6<   �� *LastMessageTime+6�   �� 5{   2   $��1��6<   $��15(�6g   ���#B7B5B8��6I   �� *Availability+6u   5|   /   5~   +   � 5�   *   $��	28,0,28,0q�6/   $	��330��6B    5�   .   �� 5�   2   $
��Auto �6C   �� 5�   2   $
��Auto �6C   �� 5�   2   $
��Auto �6C   .+�5�   .   �� $ MsgSent��64   $��0��6E   $��/Images/right.png��6U   $��Uniform=�6p   $��20��6�   ��5�   2   �� 5�   6   " ��6<   .�5�   :   ��  � y�$ Visible=�6W    5�   :   �� 5�   >    6J   �� $ MsgCount��$ 
Visibility�
 Visible6�   .a�5�   B   ��  � y�$ 	Collapsed=�6_   5�   ?   �� 5�   >    6J   �� $ IsRead��
 True6q   .a�5�   B   ��  � y�$ 	Collapsed=�6_   5�   ?   5�   7   5�   /   �� 5�   .   $��1��68   $��5,0,0,0q�6H   $��14(�6r   $��Center=�6�   ��6Y   �� *	Message+��5�   2   �� 5�   6   " ��6<    5�   :   �� 5�   >    6J   �� *IsMouseOver+ �� " ��$	 FindAncestor=�
 True6�   .a�5�   B   ��  � ��
 �����6_   5�   ?   �� 5�   >    6J   �� *
IsSelected+ �� " ��$	 FindAncestor=�
 True6�   .a�5�   B   ��  � ��
 �����6_   5�   ?   5�   7   5�   /   � 5�   .   $ MsgCount��63   $��2��6E   $��10,0,0,0q�6U   ��5�   2   �� 5�   6   " �6<   .�5�   :   ��  � y�$ Visible=�6W    5�   :   �� 5�   >    6J   �� *NewMsgCount+
 6j   Z� .a�5�   B   ��  � y�$ 	Collapsed=�6_   5�   ?   5�   7   .+�5�   2   A� ���#F54A4A$��25��6I   $��25��6T   �� 5�   2   $��14(�6Y   $��Center=�6g   $��Center=�6�   
���������6<   �� *NewMsgCount+6�   5�   /   5�   +   5�   '   5�   #   5�      5�      5�      5�      5�      �� 5�   
   " ��6)   .�5�      ��  � ��$ 0q�60   �� 5�       � ��
 ���� 6+   �� 5�       � ��$ Stretch=�62   �� 5�       � ��$ Stretch=�64   �� 5�       � |� .  6*   5�      5�      .��5�      �� #��[ 6   $��Hidden=�5�      $	��550��5�      ��5�      �� *ChatListItems+5�      5�      
   M S B A M L   `   `   `  ����K  GWPFUserInterface, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:WPFUserInterface.Custom_Controls WPFUserInterface.Custom_Controls  5      I)clr-namespace:WPFUserInterface.ViewModelsWPFUserInterface.ViewModels  5      6    0WPFUserInterface.Custom_Controls.MenuListControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      @local.clr-namespace:WPFUserInterface.Custom_Controls     5      =context)clr-namespace:WPFUserInterface.ViewModels     5      -   5          >�Name$  	_menuList��5       � 	Resources 5         ChatListBox �� 
TargetType �� Property �� Value3  -System.Windows.Media.Effects.DropShadowEffect  DropShadowInd   
BlurRadius   ShadowDepth   	Direction   Color  IndicatorStyle	 �� RelativeSource
 �� Mode �� AncestorType �� Triggers �� Binding �� Value  	PathStyle �� 
TargetType ��Name �� Padding J� SnapsToDevicePixels �� Triggers��%�  &	        &	     &	 b    7  &	     '�� �    7  7  �� 5   
   " ��6$   .�5      ��  � ��$ 0q�60   �� 5       � ��
 ���� 6+   �� 5       � ��$ Stretch=�62   �� 5       � ��$ Stretch=�64   �� 5       �@��SelectionMode$ Single=�6.   �� 5       � |� .  6*   5        5   
   $ 10Q�61   $ 3Q�6A   $	 360Q�6Q   $ #f54a4a��6a   �� 5   
   " ��6'   .�5      ��  � �� �#f54a4a6+   �� 5       � y�$ Hidden=�6+   �� 5       � �� 6'   �� *Height+	 �� $
 FindAncestor=�$ BorderL��� 5       � ��$ 4��6&   �� 5       � |� .  6*   �� 5       � ��$
 Left=�64   �� 5!       �@J�Effect8   6'    5$      �� 5%       6   �� *IsMouseOver+	 �� $
 FindAncestor=�$ ListBoxItemL� True6�   .a�5&      ��  � y�$ Visible=�63   5'      �� 5(       6   �� *
IsSelected+	 �� $
 FindAncestor=�$ ListBoxItemL� True6�   .a�5)      ��  � y�$ Visible=�63   5*      5,      �� 50   
   " F�6"   .�51      ��  � �� �#686D836%   �� 52       � ��$ 26��6&   �� 53       �@��Stretch$ Uniform=�6(   �� 54       � ��$ Stretch=�64    55      �� 56       6   �� *IsMouseOver+	 �� $
 FindAncestor=�" �� True6�   .a�57      ��  � ��
 �����6-   58      �� 59       6   �� *
IsSelected+	 �� $
 FindAncestor=�" �� True6�   .a�5:      ��  � ��
 �����6-   5;      5=      �� 5A   
   " ��6   .�5B      ��  � ��$ 55��6'   �� 5E       �@��
IsSelected 6+   �� *IsItemSelected+�� 5G       � ��
 ���� 6+   �� 5H       � ��$ 0q�60   �� 5I       � �� 5J      �� 5K      " ��6&   .R�5L      �� $ border��6!   #��z��61   # z��6[   #��z��6   #��z��6�    . ._�5N      � $��	-4,30,0,0q�6#   .+�5Q   "   �� 8��  6)   F� 5U   "   8�� ��6'   �� *
PathData+6A   5W      5X       5Y      �� 5Z      $ 40��6M    6*   �� *ListItemHeight+.a�5[   "   ��  � ��$ 40��6;   �� 5\   "    � {� .  6>   5]      5_      5a      5b      5d      .��5g      �� #��[  6   ��63   �� *
ItemList+ �� SelectedValue 5h      �� 	 �� *FindAncestor+7  1WPFUserInterface.ViewModels.MainChatPageViewModel"   �� Path$ SelectedButton�5j      
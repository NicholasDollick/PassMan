   M S B A M L   `   `   `  ����K  GWPFUserInterface, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:WPFUserInterface.Custom_Controls WPFUserInterface.Custom_Controls  5      I)clr-namespace:WPFUserInterface.ViewModelsWPFUserInterface.ViewModels  5      3    -WPFUserInterface.Custom_Controls.Conversation   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      @local.clr-namespace:WPFUserInterface.Custom_Controls     5      =context)clr-namespace:WPFUserInterface.ViewModels     5        � DataContext  5      7  1WPFUserInterface.ViewModels.ConversationViewModel  5   
    � 	Resources 5         PlayButtonStyle �� 
TargetType  ButtonStyle �� BasedOn �� Property �� Value �� Triggers �� Binding �� FallbackValue	 �� TargetNullValue
 �� Value  
AudioTrack  MessageStyle �� RelativeSource �� AncestorType �� 
TargetType ��Name �� Padding J� SnapsToDevicePixels �� CornerRadius J� RenderTransformOrigin �� Stretch �� ScaleX �� Orientation��%�8  &	        7  &	     &	 F    '�� �    7   7  7  �� 5   
   " ��6(   8   .�5      ��  � ��$ 18,0,0,0q�6'   �� 5       � y�$ 	Collapsed=�6+    5      �� 5       6   �� *IsAudioTrack+$ 	Collapsed��$	 	Collapsed��
 Visible6t   .a�5      ��  � y�$ Visible=�63   5      5      �� 5   
   " F�6#   .�5      ��  � �� �#F54A4A6%   �� 5        � ��$ 27��6'   �� 5!       � ��$	 250��6&   �� 5"       �@��Stretch$
 Fill=�6(   �� 5#       � ��$ 18,0,0,0q�6'   �� 5$       � y�$ 	Collapsed=�6+    5%      �� 5&       6   �� *MessageStatus+
 Sent6@   .a�5'      ��  � ��
 �����6-   5(      �� 5)       6   �� *IsAudioTrack+$ 	Collapsed��$	 	Collapsed��
 Visible6t   .a�5*      ��  � y�$ Visible=�63   5+      5-      �� 50   
   " ��6%   .�51      ��  � ��$ 15(�6)   �� 52       � ��$
 Bold"�6+   �� 53       � ��$ 20q�6'   �� 54       � ��
 �   �6+   �� 55       � ��$ Center=�64   �� 56       � ��$ Center=�62    59      �� 5:       6   �� *MessageStatus+
 Sent6@   .a�5;      ��  � ��
 �����63   5<      5>      �� 5@   
   " ��6   .�5A      ��  �@J�SnapsToDevicePixels . 64   �� 5B       � ��$
 Auto��6'   �� 5C       � ��$	 4,1q�6(   �� 5D       � �� 6;   �� *HorizontalContentAlignment+ �� " ���� 5E       � �� 69   �� *VerticalContentAlignment+ �� " ���� 5F       � ��
 ���� 6+   �� 5G       � ��$ 0q�60   �� 5H       � �� 5I      �� 5J      " ��6&   .R�5K      �� $ border��6!   #��z��61   #��z��6^   #��z��6�   # z��6�    . $��10,20,10,10q�6�   ._�5N      � ��5O   "   �� 5P   &   " �6,   .�5Q   *   ��  � ��$ Right=�6P    5R   *   �� 5S   .    6:   �� *MessageStatus+
 Received6\   .a�5T   2   ��  � ��$
 Left=�6X   5U   /   5W   '   .+�5[   "   �� $ 30��6)   $
��Auto��6;   $��60��6I   $	��200��6X   $��Right=�6g   $
��Auto��6�   $	��Top=�6�   $��0,0,0,20q�6�   ��5\   &   �� 5^   *   " ��60   .�5_   .   ��  � ��
 �����6K    5`   .   �� 5a   2    6>   �� *MessageStatus+
 Sent6`   .a�5b   6   ��  � �� �#F54A4A6S   5c   3   5e   +   ._�5j   &   � .+�5k   *   F� �����@]� l� ӕkZ l� l� +P l� �y� �l� E�� � ��$�= �*ӹ6 [�X�� ��k�2 z9x�/4 =�Z� �!_"� �FX�;� ��Z�-� T\@]� T\��N2T\މ��މ�y� �މ+P �N2l� @]� l� 	$��Bottom=�6�  $ 0.5,0.5&�6�  $��54.75��6�  $��50��6�  $��58��6�  $��58��6  $ Uniform=�6  ��5l   .   �� 5n   2   " F�68   .�5o   6   ��  � ��
 �����6M   �� 5p   6    � ��$
 Left=�6\    5q   6   �� 5r   :    6F   �� *MessageStatus+
 Sent6h   .a�5s   >   ��  � �� �#F54A4A6U   �� 5t   >    � ��$ Right=�6d   �� 5w   >    � z� 5x   B   �� 5y   F   $ -1Q�6U   5{   ?   5|   ;   5~   3   5�   +   ]� 5�   *   .+�5�   .   �� $ 
Horizontal=�69   $��Center=�6R   .+�5�   2   �� 8��  .��5�   6   �� $��/assets/play.png��6<   $��Uniform=�6V   $��15��6h   5�   3   F� 5�   2   �S��������y� �D���y�  [��#�  [�X�� � [��� D��؂� ���ׂ� Ӽ��؂�  R���  R�X�� � R��#� ����y� ����y� ��,1�y� ӺB�y� ��O�#� ��OX�� Ӏ�O�� �B؂� �,1ׂ� �FR ؂� ���� ��X�� Ӏ��#� FR �y� �,1�y� �y�� �y� �9z� �y�  $� �#� �#� X�� � $� �� 9z� ؂� y�� ׂ� ���� ؂�  � �� � X�� � � �#� ��� �y� y�� �y� ��K���@�y� �S��5"@�y� ��� �#� ��� X�� Ӏ�� �� S��5"@؂� �K���@ׂ� ��Y[��@؂� ��[ �� ^0� @X�� Ӏ�[ �#� �Y[��@�y� �K���@�y� ������?�y� �zLI{(�@�y�  	= �#� ����@X�� � 	= �� zLI{(�@؂� �����?ׂ� ��L��]��?؂� �� X�� �    �#� �L��]��?�y� �����?�y� � W��y� ��1��y� ����#� ���X�� Ӏ���� �1�؂�  W�ׂ� �<|�؂� �҇�� �҇X�� Ӏ҇�#� <|��y�  W��y� ���J�y� �D�[�y�  Ni�#�  NiX�� � Ni�� D�[؂� ��Jׂ� Ӽ�9؂�  E,��  E,X�� � E,�#� ��9�y� ��J�y� � <��y� �� �y� ���#� ��X�� Ӏ��� � ؂�  <�ׂ� �<a�؂� ����� ���X�� Ӏ���#� <a��y�  <��y� �����y� �D���y�  3��#�  3�X�� � 3��� D��؂� ���ׂ� Ӽӂ؂�  *u��  *uX�� � *u�#� �ӂ�y� ����y� � d6�y� ��>G�y� ��T�#� ��TX�� Ӏ�T�� �>G؂�  d6ׂ� �<�%؂� ���� ��X�� Ӏ��#� <�%�y�  d6�y� � !8�7� ���H�7� ��V_� ��V�� р�V�@� Ӏ�VR� ��H�B�y�0@ !8�B�y�0@S<F'�B�y�0@��R� ���@� р��� Ӏ�_� <F'�7�  !8�7� ��x%�7� �DS6�7�  �C_�  �C�� � �C�@� � �CR� DS6�B�y�0@�x%�B�y�0@S���B�y�0@ �R�  ��@� � ��� � �_� ���7� �x%�7� ���!
�7� �:�2
�7�  �@
_�  �@
�� � �@
�@� � �@
R� :�2
�B�y�0@��!
�r��0@S�#
�B�y�0@ z
R�  z
�@� � z
�� � z
_� �#
�7� ��!
�7� ����7� �D̢�7�  v�_�  v��� � v��@� � v�R� D̢�B�y�0@��$�� S���B�y�0@ msR�  ms�@� � ms�� � ms_� ���7� ���7� �z���7� �:���7�  ?�_� �>��� ��>��@� � ?�R� :���B�y�0@z��$�� S��{�B�y�0@ 6nR� �5n�@� ��5n�� � 6n_� ��{�7� z���7� p ��Dmv��"@S�Y�B� ��"@��� ��y� рׂ� S��gB�Ě0@�Y�X �U�<��X����gB�Ě0@���ׂ� р���y� Ӏ���� <��B� ��"@ ��Dmv��"@p H��Dmv��"@S�"�B� ��"@���� u��y� �u�ׂ� S���gB�Ě0@�"�X H�U�Fm�X����gB�Ě0@v��ׂ� �v���y� Ӏ���� Fm�B� ��"@ H��Dmv��"@p����*���"@SDn�B� ��"@ ���  ��y� � �т� S ��gB�Ě0@Dn�X���[Ӽ��X ��gB�Ě0@ �т� � ��y� � ��� ���B� ��"@����*���"@p ���g�/�� @S���B� �� @�o��-��t�"@�o��7� Q�o��B�y�0@Ӏo�ҟ����I ���I�<��I�f�ҟ�f��B�y�0@рf��7� S�f��-��t�"@<�B� �� @ ���g�/�� @p�I�g�/�� @SD�YB� �� @ �g�-��t�"@ �g�7� Q �g�r��0@� �gҟD�Y�I�I�IӼ18�I �*ҟ �*�r��0@� �*�7� S �*�-��t�"@�18B� �� @�I�g�/�� @p I�g�/�� @S�#�B� �� @�͝�-��t�"@�͝�7� р͝$�� Ӏ͝ҟ�#��I I�I�<nn�I��`ҟ��`$�� р�`�7� S��`�-��t�"@<nnB� �� @ I�g�/�� @p q�	�g�/�� @S�K�	B� �� @���	�-��t�"@���	�7� р��	$�� Ӏ��	ҟ�K�	�I q�	�I�F��	�I��	ҟ��	$�� р�	�7� S��	�-��t�"@F��	B� �� @ q�	�g�/�� @pu�C�g�/�� @S8�TB� �� @ Zb�-��t�"@�Yb�7� ��Yb$�� � Zbҟ8�T�Iu�C�I���2�I Q%ҟ�P%$�� ��P%�7� S Q%�-��t�"@��2B� �� @u�C�g�/�� @p�]n`P�^��@SD8�����@ ��-��t� @ ��*���"@� �[� ��D8؋)�]n؋)Ӽ�]؋) �O� �O[Q �O�*���"@S �O�-��t� @��]�����@�]n`P�^��@p�B�`P�^��@SD������@ ���-��t� @ ���Dmv��"@� ��U� ���D�؋)�B�؋)Ӽg�؋) ��� ��UQ ���Dmv��"@S ���-��t� @�g������@�B�`P�^��@p ��`P�^��@S�t������@���-��t� @����T2  #@р�OӀ���t�؋) ��؋)�<��؋)�����OQ����T2  #@S���-��t� @<�������@ ��`P�^��@p��#`P�^��@S:�4�����@ @B�-��t� @ @B�Dmv��"@� @BU� @B�:�4؋)��#؋)���؋) 7� 7UQ 7�Dmv��"@S 7�-��t� @�������@��#`P�^��@px�`P�^��@S8�������@ ���-��t� @����Dmv��"@����U� ���8��؋)x�؋)��0�؋) ��� ��UQ ���Dmv��"@S ���-��t� @�0������@x�`P�^��@pc�`P�^��@S�=������@���-��t� @x��Dmv��"@�x�UӀ���=�؋)c�؋)�H��؋)�ހ�|ހUQ|ހ�Dmv��"@S�ހ�-��t� @H�������@c�`P�^��@p �&��a��@S��������@����-��t� @����*���"@р��[Ӏ������؋) �؋)�<+p؋)��b���b[Q��b�*���"@S��b�-��t� @<+p�����@ �&��a��@p �}
&��a��@S�f�
�����@��
�-��t� @��
�Dmv��"@р�
UӀ�
��f�
؋) �}
؋)�F�l
؋)�_
��_
UQ�_
�Dmv��"@S�_
�-��t� @F�l
�����@ �}
&��a��@p��j	&��a��@S:�{	�����@ h�	�-��t� @ h�	�Dmv��"@� h�	U� h�	�:�{	؋)��j	؋)��Z	؋) _L	� _L	UQ _L	�Dmv��"@S _L	�-��t� @�Z	�����@��j	&��a��@p �{&��a��@S��������@�S��-��t� @�S��Dmv��"@рS�UӀS�����؋) �{؋)�H�j؋)�J]��J]UQ�J]�Dmv��"@S�J]�-��t� @H�j�����@ �{&��a��@p �[�n���@Sďl�����@�9z�[���@�9z�g�/�� @р9z�IӀ9zR$+ďl�8 �[�8�<�J�8�0=R$+�0=�IQ�0=�g�/�� @S�0=�[���@<�J�����@ �[�n���@��' �.c SD�����@ ��[���@ ��g�/�� @� ��I� �R$+D�8�' �8ӼL��8 ��R$+ ���IQ ���g�/�� @S ���[���@�L������@�' �.c � .��.c S�������@����[���@����g�/�� @р���IӀ��R$+���8 .��8�FS��8���R$+����IQ����g�/�� @S����[���@FS������@ .��.c � ���.c S��������@�F
�[���@�F
�g�/�� @рF
�IӀF
R$+����8 ���8�F���8�=�R$+�=��IQ�=��g�/�� @S�=��[���@F�������@ ���.c � �4�.c S��E�����@�+S�[���@�+S�g�/�� @р+S�IӀ+SR$+��E�8 �4�8�F�#�8�"R$+�"�IQ�"�g�/�� @S�"�[���@F�#�����@ �4�.c ���
�.c S:��
�����@ ��
�[���@ ��
�g�/�� @� ��
�I� ��
R$+:��
�8��
�8��>�
�8 ��
R$+ ��
�IQ ��
�g�/�� @S ��
�[���@�>�
�����@��
�.c � V	�.c S�0 	�����@��-	�[���@��-	�g�/�� @р�-	�IӀ�-	R$+�0 	�8 V	�8�F{��8���R$+����IQ����g�/�� @S����[���@F{������@ V	�.c � ��.c S��������@���[���@���g�/�� @р��IӀ�R$+����8 ��8�F*��8���R$+����IQ����g�/�� @S����[���@F*������@ ��.c � �2�.c S��C�����@�nQ�[���@�nQ�g�/�� @рnQ�IӀnQR$+��C�8 �2�8�F"�8�eR$+�e�IQ�e�g�/�� @S�e�[���@F"�����@ �2�.c ��\��.c S87������@ ���[���@ ���g�/�� @� ���I� ��R$+87��8�\��8�ȁ��8 ظR$+ ظ�IQ ظ�g�/�� @S ظ�[���@ȁ������@�\��.c �~V�.c S�Xg�����@�u�[���@�u�g�/�� @ыu�IӀuR$+�Xg�8~V�8�H�E�8��7R$+x�7�IQx�7�g�/�� @S��7�[���@H�E�����@~V�.c �����.c S8������@ u�[���@u�g�/�� @�u�I� uR$+8��8����8����8 l�R$+�k��IQ�k��g�/�� @S l��[���@�������@����.c p�j��Q�\ @S:E�����@ ��[���@ �&��a��@� �؋)� ��f::EXH�j�WH�Ə�XH ���f: ��؋)Q ��&��a��@S ���[���@Ə������@�j��Q�\ @p�OG�Q�\ @S:*X�����@ �e�[���@ �e&��a��@� �e؋)� �e�f::*XXH�OGWH��t6XH �(�f: �(؋)Q �(&��a��@S �(�[���@�t6�����@�OG�Q�\ @p�ȳ�Q�\ @S:�������@ M��[���@ M�&��a��@� M�؋)� M��f::��XH�ȳWH����XH D��f: D�؋)Q D�&��a��@S D��[���@��������@�ȳ�Q�\ @p��E�Q�\ @S:mV�����@ d�[���@ d&��a��@� d؋)� d�f::mVXH��EWH�Ʒ4XH '�f: '؋)Q '&��a��@S '�[���@Ʒ4�����@��E�Q�\ @p�A �Q�\ @S81�����@ �>�[���@ �>`P�^��@� �>؋)� �>�f:81XH�A WH��fXH ��f: �؋)Q �`P�^��@S ��[���@�f�����@�A �Q�\ @p��l���_��@S:{}�����@ %��[���@ %�`P�^��@� %�؋)� %��f::{}XH��lWH���[XH N�f: N؋)Q N`P�^��@S N�[���@��[�����@��l���_��@p ~A�{��@S��!����@��/�[���@��/�Q�\ @р�/WHӀ�/�X��!ؔf ۔f�F8 ؔf����X���WHQ����Q�\ @S����[���@F8 ����@ ~A�{��@p���~A�{��@S:`�����@ 
��[���@ 
��Q�\ @� 
�WH� 
��X:`�ؔf���۔f�ƪ�ؔf ��X �WHQ ��Q�\ @S ��[���@ƪ�����@���~A�{��@p�4�D��~��@S:�����@ ���[���@ ���Q�\ @� ��WH� ���X:�ؔf�4�۔f��Yؔf �q�X �qWHQ �q�Q�\ @S �q�[���@�Y����@�4�D��~��@p ;XD��~��@S�i����@��v�[���@��v�Q�\ @р�vWHӀ�v�X�iؔf ;X۔f�F`Gؔf��9�X��9WHQ��9�Q�\ @S��9�[���@F`G����@ ;XD��~��@p���D��~��@S:�����@ 2�[���@ 2�Q�\ @� 2WH� 2�X:�ؔf���۔f����ؔf )��X )�WHQ )��Q�\ @S )��[���@�������@���D��~��@p�w�D��~��@S:R�����@ ���[���@ ���Q�\ @� ��WH� ���X:R�ؔf�w�۔f�Ɯ}ؔf �o�X �oWHQ �o�Q�\ @S �o�[���@Ɯ}����@�w�D��~��@p ��D��~��@S�������@�8��[���@�8��Q�\ @р8�WHӀ8��X���ؔf ��۔f�Hٳؔf�/��X�/�WHQ�/��Q�\ @S�/��[���@Hٳ����@ ��D��~��@p�&iD��~��@S8z����@ ���[���@ ���Q�\ @� ��WH� ���X8zؔf�&i۔f��KXؔf �J�X �JWHQ �J�Q�\ @S �J�[���@�KX����@�&iD��~��@� �    SĪ#�����߾�T1�klN��?�T1������?рT13x}ӀT1�R�Ī#��� �����<�����K��R��K�3x}Q�K�������?S�K��klN��?<������߾ �� �Y    S��j�����߾�|x�klN��?�|x�����?р|x8x}Ӏ|x�R���j��� �Y����FI����s;�R��s;8x}Q�s;�����?S�s;�klN��?FI�����߾ �Y� ݢ    S��������߾�a��klN��?�a�������?рa�3x}Ӏa��R������� ݢ����F�����X��R��X�3x}Q�X�������?S�X��klN��?F������߾ ݢ�  �    S��������߾����klN��?���������?р��3x}Ӏ���R�������  �����FE��������R����3x}Q���������?S����klN��?FE������߾  �� �    S�s�����߾�,�klN��?�,������?р,3x}Ӏ,�R��s��� �����H��������R���3x}Q��������?S���klN��?H�������߾ �	8�� 6�;  �� 5�   2   8�� ��6<   �� *	Message+6U   5�   /   5�   +   5�   '   5�   #   �� 5�   "   ��6,   �� *	TimeStamp+��5�   &   �� 5�   *   " ��60   .�5�   .   ��  � ��$
 Left=�6T   �� 5�   .    � ��$ Bottom=�6R   �� 5�   .    � �� �#B7B5B86K   �� 5�   .    � ��$ 	20,0,20,0q�6G    5�   .   �� 5�   2    6>   �� *MessageStatus+
 Sent6`   .a�5�   6   ��  � ��$ Right=�6\   5�   3   5�   +   5�   #   5�      5�      5�      5�      5�      5�      .��5�      �� 
������ $��	0,.05,0,0q�6'   ��6C   �� *
Messages+5�      
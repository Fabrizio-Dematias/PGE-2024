   M S B A M L   `   `   `  ����  PGE3     SpeechToTextApp.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$"  Speech to Text Transcription��5   	   $	��400��6.   $	��600��6;   $��Comic Sans MS)�5   	   .��5      � 
���   � � RowDefinitions 5   
   �� 5      $	��79* �6   �� 5	      $	��17* �6   .+�5   
   �� -   5        $��TranscriptionTextBox��5       �� TextWrapping$
 Wrap=�5       �� AcceptsReturn . $��16(�6;    �� 
IsReadOnly . $��10,10,10,10q�5      
�������
���   �$��2��6Q   �� 5   
    �� CornerRadius$ 25��6   
��� � �$
��Left=�66   $��Bottom=�6Q   $	��150��5   	   $��50��6   $��	10,0,0,10q�6!   $��1��64   ._�5      �� -   5        $��StartButton��5      
������ 
�������$��14(�5   9   
������ $��0q�5   '   .��5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $M��GC:\Users\fabri\OneDrive\Escritorio\PGE-2024\PGE-PARCIAL2\Images\mic.png��6   $��30��5      $��30��6   �� 5      $��INICIAR��6    $��5,0,0,0q�6/   5      5      5      �� 5   
   $ 25��6   
��� ���$
��Left=�67   $��Bottom=�6R   $	��150��5   	   $��50��6   $��
220,0,0,10q�6!   $��1��65   ._�5      �� -   5        $��
StopButton��5      {�.  
��� ���
���   �$��14(�5   4   
������ $��0q�5    '   .��5!      �� $ 
Horizontal=�6   .+�5"      �� $N��HC:\Users\fabri\OneDrive\Escritorio\PGE-2024\PGE-PARCIAL2\Images\stop.png��6   $��30��5#      $��30��6   �� 5$      $��DETENER��6    $��5,0,0,0q�6/   5%      5&      5'      �� 5)   
   $ 25��6   
����iA�$��Right=�6:   $��Bottom=�6V   $	��150��5*   	   $��50��6   $��	0,0,10,10q�6!   $��1��64   ._�5+      �� -   5        $��
PlayButton��5+      
������ 
�������$��14(�5,   9   
������ $��0q�5-   '   .��5.      �� $ 
Horizontal=�6   .+�5/      �� $Q��KC:\Users\fabri\OneDrive\Escritorio\PGE-2024\PGE-PARCIAL2\Images\speaker.png��6   $��30��50      $��30��6   �� 51      $��
REPRODUCIR��6    $��5,0,0,0q�62   52      53      54      �� 56   
   $ 25��6   
��� ���$��Center=�67   $	��Top=�6T   $��	0,257,0,0q�6l   ._�57      �� -   5        $��
SaveButton��57      $	��267��6'   $��50��63   
������ 
�������$��14(�58   9   
������ $��0q�59   '   .��5:      �� $ 
Horizontal=�6   .+�5;      �� $T��NC:\Users\fabri\OneDrive\Escritorio\PGE-2024\PGE-PARCIAL2\Images\save_image.png��6   $��30��5<      $��30��6   $��5,0,0,0q�6+   �� 5=      $��GUARDAR TRANSCRIPCIÓN��6    $	��195��6=   $��Center=�6I   5>      5?      5@      �� 5B   
   -   5        $��LanguageLabel��5B      $��IDIOMA DETECTADO: N/A��6%   $��Center=�5C      $	��Top=�6-   $��16(�6E   $��0,10,0,0q�5D      
�������6"   �� 5F   
   -   5        $��LanguageFlag��5F      $��Right=�6$   $	��Top=�6@   $��64��5G      $��64��6   $��	0,10,10,0q�6'   � 5J   
   -   5        $��AlphabetPanel��5J      $
��Left=�6)   $	��Top=�6D   $��
335,86,0,0q�6\   $	��240��6p   .+�5K      �� -	   5        $��LetterA��5K       $��A��6   $��20(�6/   $��30��6=   $��30��6H   
�������$��2q�6g   $��Center=�6r   $��Center=�6�   �� 5L      -
   5        $��LetterB��5L       $��B��6   $��20(�6/   $��30��6=   $��30��6H   
�������$��2q�6g   $��Center=�6r   $��Center=�6�   �� 5M      -   5        $��LetterC��5M       $��C��6   $��20(�6/   $��30��6=   $��30��6H   
�������$��2q�6g   $��Center=�6r   $��Center=�6�   �� 5N      -   5        $��LetterD��5N       $��D��6   $��20(�6/   $��30��6=   $��30��6H   
�������$��2q�6g   $��Center=�6r   $��Center=�6�   �� 5O      -   5        $��LetterE��5O       $��E��6   $��20(�6/   $��30��6=   $��30��6H   
�������$��2q�6g   $��Center=�6r   $��Center=�6�   �� 5P      -   5        $��LetterF��5P       $��F��6   $��20(�6/   $��30��6=   $��30��6H   
�������$��2q�6g   $��Center=�6r   $��Center=�6�   �� 5Q      -   5        $��LetterG��5Q       $��G��6   $��20(�6/   $��30��6=   $��30��6H   
�������$��2q�6g   $��Center=�6r   $��Center=�6�   �� 5R      -   5        $��LetterH��5R       $��H��6   $��20(�6/   $��30��6=   $��30��6H   
�������$��2q�6g   $��Center=�6r   $��Center=�6�   �� 5S      -   5        $��LetterI��5S       $��I��6   $��20(�6/   $��30��6=   $��30��6H   
�������$��2q�6g   $��Center=�6r   $��Center=�6�   �� 5T      -   5        $��LetterJ��5T       $��J��6   $��20(�6/   $��30��6=   $��30��6H   
�������$��2q�6g   $��Center=�6r   $��Center=�6�   �� 5U      -   5        $��LetterK��5U       $��K��6   $��20(�6/   $��30��6=   $��30��6H   
�������$��2q�6g   $��Center=�6r   $��Center=�6�   �� 5V      -   5        $��LetterL��5V       $��L��6   $��20(�6/   $��30��6=   $��30��6H   
�������$��2q�6g   $��Center=�6r   $��Center=�6�   �� 5W      -   5        $��LetterM��5W       $��M��6   $��20(�6/   $��30��6=   $��30��6H   
�������$��2q�6g   $��Center=�6r   $��Center=�6�   �� 5X      -   5        $��LetterN��5X       $��N��6   $��20(�6/   $��30��6=   $��30��6H   
�������$��2q�6g   $��Center=�6r   $��Center=�6�   �� 5Y      -   5        $��LetterÑ��5Y       $��Ñ��6   $��20(�6/   $��30��6=   $��30��6H   
�������$��2q�6g   $��Center=�6r   $��Center=�6�   �� 5Z      -   5        $��LetterO��5Z       $��O��6   $��20(�6/   $��30��6=   $��30��6H   
�������$��2q�6g   $��Center=�6r   $��Center=�6�   �� 5[      -   5        $��LetterP��5[       $��P��6   $��20(�6/   $��30��6=   $��30��6H   
�������$��2q�6g   $��Center=�6r   $��Center=�6�   �� 5\      -   5        $��LetterQ��5\       $��Q��6   $��20(�6/   $��30��6=   $��30��6H   
�������$��2q�6g   $��Center=�6r   $��Center=�6�   �� 5]      -   5        $��LetterR��5]       $��R��6   $��20(�6/   $��30��6=   $��30��6H   
�������$��2q�6g   $��Center=�6r   $��Center=�6�   �� 5^      -   5        $��LetterS��5^       $��S��6   $��20(�6/   $��30��6=   $��30��6H   
�������$��2q�6g   $��Center=�6r   $��Center=�6�   �� 5_      -   5        $��LetterT��5_       $��T��6   $��20(�6/   $��30��6=   $��30��6H   
�������$��2q�6g   $��Center=�6r   $��Center=�6�   �� 5`      -   5        $��LetterU��5`       $��U��6   $��20(�6/   $��30��6=   $��30��6H   
�������$��2q�6g   $��Center=�6r   $��Center=�6�   �� 5a      -   5        $��LetterV��5a       $��V��6   $��20(�6/   $��30��6=   $��30��6H   
�������$��2q�6g   $��Center=�6r   $��Center=�6�   �� 5b      -    5        $��LetterW��5b       $��W��6   $��20(�6/   $��30��6=   $��30��6H   
�������$��2q�6g   $��Center=�6r   $��Center=�6�   �� 5c      -!   5        $��LetterX��5c       $��X��6   $��20(�6/   $��30��6=   $��30��6H   
�������$��2q�6g   $��Center=�6r   $��Center=�6�   �� 5d      -"   5        $��LetterY��5d       $��Y��6   $��20(�6/   $��30��6=   $��30��6H   
�������$��2q�6g   $��Center=�6r   $��Center=�6�   �� 5e      -#   5        $��LetterZ��5e       $��Z��6   $��20(�6/   $��30��6=   $��30��6H   
�������$��2q�6g   $��Center=�6r   $��Center=�6�   5g      5h      5i      
   M S B A M L   `   `   `  ����!  Videoclub_Trabajo_2_Trimestre.    (Videoclub_Trabajo_2_Trimestre.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5        � Title$  Pantalla Principal��5      $	��600��6    $	��800��6-    � WindowStartupLocation$ CenterScreen=�69    � 
ResizeMode$ CanMinimize=�6^    � 	Resources 5         Animacion_Menu �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value��%�  &	        �� 5      .��5      U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6#   $ btn_Cliente��6�   .\�5        $ 0��6   $
 -284Q�6'     5	      $ 0:0:1��6   $	 -11Q�6+   5
      U� 5      $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6#   $ btn_Alquileres��6�   .\�5        $ 0��6   $
 -284Q�6'     5      $ 0:0:1��6   $	 -11Q�6+   5      U� 5      $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6#   $ 	textBlock��6�   .\�5        $ 0��6   $
 -284Q�6'     5      $ 0:0:1��6   $	 -11Q�6+   5      U� 5      $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6#   $ 
textBlock1��6�   .\�5        $ 0��6   $
 -284Q�6'     5      $ 0:0:1��6   $	 -11Q�6+   5      U� 5      $ (FrameworkElement.Height)�6#   $ 
textBlock2��6Y   .\�5        $ 0��6   $ 20Q�6'   5      U� 5      $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6#   $ btn_Peliculas��6�   .\�5        $ 0��6   $	 304Q�6'     5      $ 0:0:1��6   $ -5Q�6+   5      U� 5      $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6#   $ btn_Informes��6�   .\�5        $ 0��6   $	 304Q�6'     5       $ 0:0:1��6   $ -5Q�6+   5!      U� 5"      $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6#   $ 
textBlock3��6�   .\�5#        $ 0��6   $	 304Q�6'     5$      $ 0:0:1��6   $ -5Q�6+   5%      U� 5&      $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6#   $ 
textBlock2��6�   .\�5'        $ 0��6   $	 304Q�6'     5(      $ 0:0:1��6   $ -5Q�6+   5)      U� 5*      $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�6#   $ 	btn_Salir��6�   .\�5+        $ 0��6   $	 174Q�6'     5,      $ 0:0:1��6   $ 10Q�6+   5-      5.      5/       � Triggers 50      :� 51      	 :� RoutedEvent$	 FrameworkElement.Loaded��6   .[�52      �� #��[  6   53      .��55      � ��56   
   
� 57      .��58      � 
 � Color$
 	LightBlue��6    � Offset$ 0Q�61   � 59      $
 	SteelBlue��6   $ 1Q�61   5:      .+�5<   
   �� -   5        $��btn_Cliente��5<   Y   $	��124��6   $	��126��6   $
��Left=�6*   $��
104,45,0,0q�6E   $	��Top=�6l   
�����F� J� RenderTransformOrigin$ 0.5,0.5&�6�   z�5=      V� 5>      .~�5?      �� �� 5@      �� 5A      T� 5B      5C      .��5E      �� $O��I/Videoclub_Trabajo_2_Trimestre;component/bin/Debug/res/iconos/clients.png��6   6i   5F      �� 5G   
   -   5        $��btn_Peliculas��5G   Y   $	��124��6   $	��126��6   $
��Left=�6*   $��
554,49,0,0q�6E   $	��Top=�6n   
�����F�$ 0.5,0.5&�6�   z�5H      V� 5I      .~�5J      �� �� 5K      �� 5L      T� 5M      5N      .��5P      �� -   5        $��Image1��5P   e   $M��G/Videoclub_Trabajo_2_Trimestre;component/bin/Debug/res/iconos/movie.png��6   6u   5Q      �� 5R   
   -   5        $��btn_Alquileres��5R   N   $	��124��6   $
��Left=�6   $��105,313,0,0q�69   $	��Top=�6d   $	��126��6|   
�����F�$ 0.5,0.5&�6�   z�5S      V� 5T      .~�5U      �� �� 5V      �� 5W      T� 5X      5Y      .��5[      �� $P��J/Videoclub_Trabajo_2_Trimestre;component/bin/Debug/res/iconos/alquiler.png��6   $	��110��6h   $	��116��6u   6�   5\      �� 5]   
   -   5        $��btn_Informes��5]   Z   $	��124��6   $	��126��6   $
��Left=�6*   $��554,313,0,0q�6E   $	��Top=�6n   
�����F�$ 0.5,0.5&�6�   z�5^      V� 5_      .~�5`      �� �� 5a      �� 5b      T� 5c      5d      .��5f      �� $L��F/Videoclub_Trabajo_2_Trimestre;component/bin/Debug/res/iconos/form.png��6   6f   5g      �� 5h   
   -   5        $��	btn_Salir��5h   Z   $	��124��6   $	��126��6   $
��Left=�6*   $��338,430,0,0q�6E   $	��Top=�6k   
�����F�$ 0.5,0.5&�6�   z�5i      V� 5j      .~�5k      �� �� 5l      �� 5m      T� 5n      5o      .��5q      �� $L��F/Videoclub_Trabajo_2_Trimestre;component/bin/Debug/res/iconos/exit.png��6   6f   5r      �� 5s   
   -   5        $��image2��5s   M   $	��150��6   $
��Left=�6   $��234,167,0,0q�68   $
��Fill=�6[   $	��Top=�6j   $	��318��6�   $L��F/Videoclub_Trabajo_2_Trimestre;component/bin/Debug/res/iconos/logo.png��6�   �� 5t   
   -   5         ��Name$ 	textBlock��5t      $
��Left=�6'   $��16��6B   $��105,173,0,0q�6N   $
��Wrap=�6c   $	��Top=�6w   $��42��6�   $ 0.5,0.5&�6�   z�5u      V� 5v      .~�5w      �� �� 5x      �� 5y      T� 5z      5{      �� 5|   '    � Language$ es-es�6+   $�Clientes��6<   �� 6N   �� 6Z   $ es-es�6^   6r   �� 5}   
   -	   5        $ 
textBlock1��5}      $
��Left=�6(   $��15��6C   $��110,0,0,115q�6O   $
��Wrap=�6d   $��Bottom=�6x   $��57��6�   $ 0.5,0.5&�6�   z�5~      V� 5      .~�5�      �� �� 5�      �� 5�      T� 5�      5�      �� 5�   '   $ es-es�6+   $�
Alquileres��6<   6Q   �� 5�   
   -
   5        $ 
textBlock3��5�      $��Right=�6(   $��13��6D   $��0,0,190,115q�6P   $
��Wrap=�6e   $��Bottom=�6y   $��50��6�   $ 0.5,0.5&�6�   z�5�      V� 5�      .~�5�      �� �� 5�      �� 5�      T� 5�      5�      �� 5�   '   $ es-es�6+   $�Informes��6<   6O   �� 5�   
   -   5        $ 
textBlock2��5�      $��Right=�6(   $��12��6D   $��0,177,190,0q�6P   $
��Wrap=�6e   $	��Top=�6y   $��48��6�   $ 0.5,0.5&�6�   z�5�      V� 5�      .~�5�      �� �� 5�      �� 5�      T� 5�      5�      �� 5�   '   $ es-es�6+   $�	Peliculas��6<   6P   5�      5�      
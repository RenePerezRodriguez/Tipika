   M S B A M L   `   `   `  ����Q  MAppTipika.Presentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:AppTipika.PresentationAppTipika.Presentation  5   	   '    !AppTipika.Presentation.MenuInicio   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:AppTipika.Presentation     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  MenuPrincipal��5	   	   $
��1600��6   $	��900��6,    � 
ResizeMode$ NoResize=�69    � WindowStartupLocation$ CenterScreen=�6O    � WindowStyle$
 None=�6t   ���#212121.��5
      � .+�5   
   � ���#212121$��70��6$   $	��Top=�60   .+�5      �� $��72(�6   $
��Bold"�6&   $��T I P I K A��68   
�������$��Center=�6c   $��Calibri Light)�6   $��	325,0,0,0q�6�   �� 5       �� Orientation$ 
Horizontal=�6   $��Center=�62   $��Right=�6M   .+�5      �� -   5         ��Name$ tbkId��5   /   
�������$
��Left=�6>   $��Bottom=�6Y   �� 6v   $�Id��6z   6�   �� 5      -   5        $ tbkRol��5   /   
�������$
��Left=�6?   $	��Top=�6Z   �� 6t   $	�Rol��6x   6�   �� 5      -   5        $ 
tbkUsuario��5   /   
�������$��Right=�6C   $��center=�6_   �� 6|   $�Usuario��6�   6�   '  !MaterialDesignThemes.Wpf.PopupBox  5      
�������   PlacementMode$ BottomAndAlignRightEdges=�6=   $��10q�6f      	StaysOpen$ False��6r      PopupContent. 5      �� $	��165��6!   .+�5      �� -   5        	 ��Name$	 
btnCambiar��5   !   $��Cambiar de Usuario��6N   �� 5      �� 5      -   5        $	 btnSalir��5   !   $��Salir��6J   5      5      5      5      � 5   
   -   5        
 �Name$
 GridMenu��5      ���#bc9f79$	��260��66   $
��Left=�6B   .+�5      �� .+�5      � ���	#FF6C665E$	��213��6.   .+�5      A� $	��100��6   $	��100��6,   $��25q�69   ��5       �� 5!       j� Stretch$ UniformToFill=�6*   5#      5$      �� 5%      -   5         ��Name$ lvwMenu��5%      
������ 
���   �$��Disabled=�6�   $	��704��6�   .@�5&      �� -   5         ��Name$ itemHome��5&   /   $��60��6#   .��5'      �� $ 
Horizontal=�6%   .+�5(      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Home=�66   $��30��6B   $��30��6M   $��Center=�6Y   �� 5)      $��Inicio��6(   
�������$��10q�6I   $��18(�6U   $��Center=�6c   5*      5+      �� 5,      -	   5        $ itemRestaurante��5,   /   $��60��6#   .��5-      �� $ 
Horizontal=�6%   .+�5.        $ 	Favourite=�66   $��30��6G   $��30��6R   $��Center=�6^   �� 5/      $��Registra tu negocio��6(   
�������$��10q�6V   $��18(�6b   $��Center=�6p   50      51      52      54      �� 55      $ 
Horizontal=�6   $��Bottom=�62   .+�56        $ AssignmentInd=�6*   $��30��6?   $��30��6J   $��Center=�6V   �� 57      $��Trabaja Con nosotros 🙂��6   
�������$��10q�6S   $��18(�6_   $��Center=�6m   58      59      � 5:   
   -
   5        $
 GridRestaurantes��5:      $��
315,72,2,2q�6)   ���#36332d J� RenderTransformOrigin$	 1,0&�6R    � ColumnDefinitions 5;      �� 5<      $��* �6#   �� 5=      $��* �6#   �� 5>      $��* �6#   �� 5?      $��* �6#    � RowDefinitions 5B      �� 5C      $��* �6    �� 5D      $��* �6    �� 5E      $��* �6    �� 5F      $��* �6    .+�5H      �� $��AQUI ESTA UN PRODUCTO��6   $��Center=�64   $��Center=�6Q   $��0��6l   $��0��6y   $��22(�6�   $
��Bold"�6�   $��Arial Black)�6�   ���	#FF4D47476�   �� 5I      $��AQUI ESTA UN PRODUCTO��6   $��Center=�64   $��Center=�6Q   $��0��6l   $��1��6y   $��22(�6�   $
��Bold"�6�   $��Arial Black)�6�   ���	#FF4D47476�   �� 5J      $��AQUI ESTA UN PRODUCTO��6   $��Center=�64   $��Center=�6Q   $��0��6l   $��0��6y   $��22(�6�   $
��Bold"�6�   $��Arial Black)�6�   ���	#FF4D47476�   5K      5L      5M      
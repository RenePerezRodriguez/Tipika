   M S B A M L   `   `   `  ����  AppTipika.Presentation"    AppTipika.Presentation.login   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5          � Title$  WinLogin��5   	    � WindowStartupLocation$ CenterScreen=�61   
�������$��5q�6p    � 
ResizeMode$ NoResize=�6�    � WindowStyle$
 None=�6�   $	��450��6�   $	��350��6�   .��5	      � 
������� � RowDefinitions 5
   
   �� 5      $	��27* �6   �� 5      $	��61* �6   .+�5   
   �� $��2��6   .+�5      � ���#55402a$��50��6(   $	��Top=�64   .+�5      �� $��25(�6   
�������$
��Bold"�6=   $��0,5,0,0q�6O   $��Center=�6a   Login6�   �� 5      -   5         ��Name$ btnClose��5   2    � ToolTip$ Cerrar Ventana��6   $��30��6D   $��50��6O   $��Right=�6r   $��0q�6�   $	��Top=�6�   ��6�   Z� ��6�   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon  
�������   Kind$ Close=�6A   $��40��6N   $��35��6Y   $��	-15 0 0 0q�6e   5      5      A� 5      $	��100��6   $	��100��6$   $��25q�61   ��5      �� 5       j� Stretch$ UniformToFill=�6"   5      �� 5      $��Center=�6   	 �� Orientation$	 
Horizontal=�66   .+�5        $ Account=�6*   $��5q�69   $��Center=�6D   �� 5      -   5        
 ��Name$
 txtNombreUsuario��5   �   )  #MaterialDesignThemes.Wpf.HintAssist   
IsFloating$
 True��6      Hint$ Nombre de Usuario��6H   $��Center=�6{   $��5q�6�   $	��250��6�   6�   5      �� 5      $��Center=�6   $	 
Horizontal=�66   .+�5         $	 Key=�6*   $��5q�65   $��Center=�6@   G� 5!      -   5         G�Name$ txtPassword��5!   �   $
 True��6   $ Password��6K   $��Center=�6u   $��5q�6�   $	��250��6�   6�   5"      �� 5#      $��Center=�6   $	 
Horizontal=�66   .+�5$      �� -   5        $ btnIngresar��5$      $��Ingresar��6.   $��90��6A   
�������$��Center=�6_   ���	#FF202225$��10,20q�6�   
�������6�   �� 5%      -   5         ��Name$ tbkCrearCuenta��5%      $��26��64   $��Bottom=�6@   Crear Cuenta6�   �� 5&      -   5        $ btnSalir��5&      $��Salir��6B   $��90��6R   
�������$��Center=�6p   ���	#FF202225$��10,20q�6�   
�������6�   5'      #  MaterialDesignThemes.Wpf.Card  5(      -   5          Name$ cardInfo��5(   "   $��5q�64   $
��auto��6?   $��50��6L   .��5)      �� -	   5        $ 
tbkDetalle��5)      $��Center=�61   $��Center=�6N   Nunca revele su contraseña6�   5*      5+      5,      5-      
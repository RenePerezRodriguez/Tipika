   M S B A M L   `   `   `  ����Q  MAppTipika.Presentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullk:clr-namespace:AppTipika.Presentation.CRUD.CRUD_RESTAURANTE,AppTipika.Presentation.CRUD.CRUD_RESTAURANTE  5   	   K    EAppTipika.Presentation.CRUD.CRUD_RESTAURANTE.RestauranteInsert_Update   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Llocal:clr-namespace:AppTipika.Presentation.CRUD.CRUD_RESTAURANTE     5   	     � Title$  RestauranteInsert_Update��5   	   $	��450��6*   $	��600��67   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��150 �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��1 �6   �� 5      $��1 �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $	��260 �6   �� 5      $��1* �6   .+�5   
   �� -   5         ��Name$ txtId��5      $��0��6!   $��0��61   $��30��6>   $
��Left=�6I   $	��Top=�6d    �� 
IsReadOnly$
 True��6|   �� 5   
   $��Nombre del restaurante:��6   $��0��62   $��2��6B   $��13(�6O   $��Center=�6]   $��Center=�6z   �� 5   
   $��
Direccion:��6   $��0��6%   $��3��65   $��13(�6B   $��Center=�6P   $��Center=�6m   �� 5   
   $��
Ubicacion:��6   $��0��6%   $��4��65   $��13(�6B   $��Center=�6P   $	��Top=�6m   �� 5   
   -   5        $ txtNombreRestaurante��5      $	��180��60   $��3��6<   $��2��6L   $
��Left=�6Y   $��50 0 0 0q�6t   $��Center=�6�   �� 5    
   -   5        $ txtDireccion��5       $	��180��6(   $��40��64   $��4��6@   $��3��6P   $
��Left=�6]   $��50 0 0 0q�6x   $��Center=�6�   �� 5"   
   -   5         ��Name$ btnInsertar��5"      $��INSERTAR��6&   $��1��69   $��8��6I   $��15(�6V   $��88��6d   $
��Left=�6o   $	��Top=�6�   $��	250 0 0 0q�6�   6�   �� 5#   
   -   5        $ btnActualizar��5#      $��
ACTUALIZAR��6(   $��8��6=   $��8��6M   $��15(�6Z   $��Right=�6h   $	��Top=�6�   $��0 0 10 0q�6�   5$      5%      
   M S B A M L   `   `   `  ����Q  MAppTipika.Presentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle7clr-namespace:AppTipika.Presentation.CRUD.CRUD_PRODUCTO)AppTipika.Presentation.CRUD.CRUD_PRODUCTO  5   	   E    ?AppTipika.Presentation.CRUD.CRUD_PRODUCTO.ProductoInsert_Update   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Ilocal7clr-namespace:AppTipika.Presentation.CRUD.CRUD_PRODUCTO     5   	     � Title$  ProductoInsert_Update��5   	   $	��450��6'   $	��350��64   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��150 �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��45 �6   .+�5   
   �� -   5         ��Name$ txtId��5      $��0��6!   $��0��61   $��30��6>   $
��Left=�6I   $	��Top=�6d    �� 
IsReadOnly$
 True��6|   �� 5   
   $��Imagen:��6   $��0��6"   $��0��62   $��13(�6?   $��Center=�6M   $��Center=�6j   �� 5   
   $��Nombre:��6   $��0��6"   $��1��62   $��13(�6?   $��Center=�6M   $��Center=�6j   �� 5   
   $��Ingredientes :��6   $��0��6)   $��2��69   $��13(�6F   $��Center=�6T   $��Center=�6q   �� 5   
   $��Descripcion:��6   $��0��6'   $��3��67   $��13(�6D   $��Center=�6R   $��Center=�6o   �� 5   
   $��Precio:��6   $��0��6"   $��4��62   $��13(�6?   $��Center=�6M   $��Center=�6j   �� 5!   
   -   5        $ 	txtImagen��5!      $	��150��6%   $��1��61   $
��Left=�6A   $��Center=�6\   ${�False��6w   �� 5"   
   -   5         ��Name$ 	btnImagen��5"      $��Cargar��6$   $��50��65   $��20��6@   $��1��6L   $��Right=�6\   $��Center=�6x   ${�False��6�   �� 5#   
   -   5        $ txtNombreProducto��5#      $	��180��6-   $��2��69   $��1��6I   $
��Left=�6V   $��Center=�6q   �� 5$   
   -   5        $ txtInredientes��5$      $	��180��6*   $��1��66   $��2��6F   $
��Left=�6S   $��Center=�6n   �� 5%   
   -   5        $ txtDescripcion��5%      $	��180��6*   $��40��66   $��1��6B   $��3��6R   $
��Left=�6_   $��Center=�6z   �� 5'   
   -   5        $ 	txtPrecio��5'      $	��180��6%   $��1��61   $��4��6A   $
��Left=�6N   $��Center=�6i   �� 5)   
   -   5        $ btnInsertar��5)      $��INSERTAR��6&   $��1��69   $��8��6I   $��15(�6V   $��88��6d   $
��Left=�6o   $	��Top=�6�   6�   �� 5*   
   -	   5        $ btnActualizar��5*      $��
ACTUALIZAR��6(   $��8��6=   $��8��6M   $��15(�6Z   $��Right=�6h   $	��Top=�6�   5+      5,      
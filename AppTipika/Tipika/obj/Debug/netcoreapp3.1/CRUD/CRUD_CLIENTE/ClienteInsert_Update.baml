   M S B A M L   `   `   `  ����Q  MAppTipika.Presentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:AppTipika.Presentation.CRUDAppTipika.Presentation.CRUD  5   	   6    0AppTipika.Presentation.CRUD.ClienteInsert_Update   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:AppTipika.Presentation.CRUD     5   	     � Title$  ClienteInsert_Update��5   	   $	��450��6&   $	��750��63   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $	��181 �6   �� 5      $��* �6   �� 5      $	��181 �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ txtId��5      $��0��6!   $��0��61   $��30��6>   $
��Left=�6I   $	��Top=�6d    �� 
IsReadOnly$
 True��6|   �� 5!   
   $��Cedula de identidad:��6   $��0��6/   $��0��6?   $��15(�6L   $��Center=�6Z   $��Center=�6w   �� 5"   
   $��Nombres:��6   $��0��6#   $��1��63   $��15(�6@   $��Center=�6N   $��Center=�6k   �� 5#   
   $��Primer Apellido:��6   $��0��6+   $��2��6;   $��15(�6H   $��Center=�6V   $��Center=�6s   �� 5$   
   $��Segundo Apellido:��6   $��0��6,   $��3��6<   $��15(�6I   $��Center=�6W   $��Center=�6t   �� 5%   
   $��Correo Electronico:��6   $��0��6.   $��4��6>   $��15(�6K   $��Center=�6Y   $��Center=�6v   �� 5&   
   $��
Direccion:��6   $��0��6%   $��5��65   $��15(�6B   $��Center=�6P   $��Center=�6m   �� 5'   
   $��	telefono:��6   $��0��6$   $��6��64   $��15(�6A   $��Center=�6O   $��Center=�6l   �� 5*   
   -   5        $ txtCedulaDeIdentidad��5*      $	��180��60   $��1��6<   $��0��6L   $
��Left=�6Y   $��Center=�6t   �� 5+   
   -   5        $ 
txtNombres��5+      $	��180��6&   $��1��62   $��1��6B   $
��Left=�6O   $��Center=�6j   �� 5,   
   -   5        $ txtPrimerApellido��5,      $	��180��6-   $��1��69   $��2��6I   $
��Left=�6V   $��Center=�6q   �� 5-   
   -   5        $ txtSegundoApellido��5-      $	��180��6.   $��1��6:   $��3��6J   $
��Left=�6W   $��Center=�6r   �� 5.   
   -   5        $ txtCorreoElectronico��5.      $	��180��60   $��1��6<   $��4��6L   $
��Left=�6Y   $��Center=�6t   �� 5/   
   -   5        $ txtdireccion��5/      $	��180��6(   $��1��64   $��5��6D   $
��Left=�6Q   $��Center=�6l   �� 50   
   -   5        $ txtTelefono��50      $	��180��6'   $��1��63   $��6��6C   $
��Left=�6P   $��Center=�6k   �� 52   
   $��Nombre Usuario:��6   $��2��6*   $��0��6:   $��15(�6G   $��Center=�6U   $��Center=�6r   �� 53   
   $��
Password :��6   $��2��6%   $��1��65   $��15(�6B   $��Center=�6P   $��Center=�6m   �� 54   
   -	   5        $ txtNombreUsuario��54      $	��180��6,   $��4��68   $��0��6H   $
��Left=�6U   $��Center=�6p   �� 55   
   -
   5        $ txtPasswordUsuario��55      $	��180��6.   $��4��6:   $��1��6J   $
��Left=�6W   $��Center=�6r   �� 58   
   -   5         ��Name$ btnInsertar��58      $��INSERTAR��6&   $��2��69   $��2��6I   $��Center=�6V   $��
47,15,47,0q�6�   $
��Auto��6�   �� 59   
   -   5        $ btnActualizar��59      $��
ACTUALIZAR��6(   $��3��6=   $��2��6M   $
��Left=�6Z   $	��Top=�6u   $��0,29,0,0q�6�   $��2��6�   6�   5:      5;      
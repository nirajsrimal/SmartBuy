   M S B A M L   `   `   `  ���� C  ?SmartBuy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:SmartBuySmartBuy      SmartBuy.motoxf   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (localclr-namespace:SmartBuy       � Title$  motoxf��$	��768��$
��1366�� � WindowState$ 	Maximized=�.���  J� RenderTransformOrigin$ 0.5,0.5&�$��	-2,40,2,9q� � RowDefinitions ��  � ColumnDefinitions �� $
��269* ��� $
��246* ��� $
��199* ��� $
��644* �.+�&   System.Windows.Controls.DataGrid  -     Name$ dataGrid��$��Right=�$��
0,51,429,0q�$	��455��$	��591��$	��Top=�   
IsReadOnly .    AutoGenerateColumns .  $��3��
�������$��26.667(� � Cursor$
 Hand��	   HeadersVisibility$
	 None=�$��1����Z� z�V� .~��� 
 �� ScaleY$
 1Q� �� ScaleX$ 1Q���  �� AngleY$ 0Q� �� AngleX$ 0Q���  �� Angle$ 0Q�T�    Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Specs��   
FontWeight$
 Bold"�   FontSize$ 18.667Q�   
FontFamily$ Trebuchet MS)�   MinWidth$ 25Q�1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Specs+  $
 Info��   Width5  /System.Windows.Controls.DataGridLengthConverter$ * $ 14.667Q�$ Comic Sans MS)� �� *Info+� $
��Left=�$
��Auto��$��	50,46,0,0q�$	��Top=�$	��386��$��2��.+��� -    ��Name$	 sp0��$
��Left=�$
��auto��$	��Top=�$	��380��.+��� -    ��Name$	 img��$	��411�� J� OpacityMask
 �   ��� -    ��Name$ l��$�� ��$��47��$��24(�$��Microsoft YaHei UI)��� -   $ l1��$�� ��$��53��$��24(�$��Microsoft YaHei)��� $��4�����	#FFB0EEEB$
��Left=�$��66��$��	1,-40,0,0q�
���   �$	��Top=�$
��1357���� -    ��Name$ button��$��3��$
��Left=�$	��102��$��246,363,0,0q�$	��Top=�$	��362�����	#FFB0EEEB��Z� ��Z� .��� $
��Left=�$��89��$	��Top=�$	��332��.+��� -   $ image��$R��LC:/Users/Niraj/Documents/Visual Studio 2015/Projects/SmartBuy/Photos/buy.png��$��Center=�$��74��$��88��$ 	0.5,0.503&��� -   $ label3��$�� BUY NOW��$
��Left=�$��64��$��Center=�$	��238��$��48(��� -	   $ label��$��
Quantity :��$��3��$
��Left=�$��39��$��271,158,0,0q�$	��Top=�$	��159��$��24(��� -
   $ label1��$��Price per unit :��$��3��$
��Left=�$��43��$��270,218,0,0q�$	��Top=�$	��147��$��21.333(��� -   $
 home��$
��Left=�$��543,593,-5,-10q�$	��106��$ 0.405,0.475&�$	��114��$	��Top=�$��3����Z� ��Z� .���� -   $ image1_Copy��$S��MC:/Users/Niraj/Documents/Visual Studio 2015/Projects/SmartBuy/Photos/home.png��$
��Left=�$��76��$	��Top=�$��96��$ 1.083,0.591&��� -   $ button3��$
��Left=�$��89��$��445,610,0,-2q�$	��Top=�$��90��$��3����Z� ��Z� .���� -   $ image3��$S��MC:/Users/Niraj/Documents/Visual Studio 2015/Projects/SmartBuy/Photos/back.png��$
��Left=�$��74��$	��Top=�$��55��$ 	0.79,0.03&��� -   $ price��$�� ��$��3��$
��Left=�$��43��$��466,218,0,0q�$	��Top=�$	��120��
���   �$��1q�$��18.667(��� -   $ label1_Copy��$��Total Price :��$��3��$
��Left=�$��43��$��270,272,0,0q�$	��Top=�$	��147��$��21.333(��� -   $ total��$�� ��$��3��$
��Left=�$��43��$��466,272,0,0q�$	��Top=�$	��120��
���   �$��1q�$��18.667(��� -    ��Name$ quantity��$��3��$
��Left=�$��39��$��466,158,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��120��
���   � �� SelectionBrush �	#FF8EC6FF$��18.667(��� -   $ label2��$�� ��$
��Left=�$��
50,567,0,0q�$	��Top=�$��2��$��73��$	��386��$��26.667(�$
��Bold"�
   M S B A M L   `   `   `  ����C  ?SmartBuy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:SmartBuySmartBuy  5   	       SmartBuy.Main_Menu   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:SmartBuy     5   	     � Title$  	Main_Menu��5   	   $	��768��6   $
��1366��6(    � WindowState$ 	Maximized=�65   ���	#FFA48686.��5	      � $��Right=�6   $
��1417��6'   $��-27,0,-32,-31q�64   ��5
   
   �� 5       j� TileMode$
 Tile=�6    j� Stretch$ Uniform=�6)    �� ImageSource$R LC:/Users/Niraj/Documents/Visual Studio 2015/Projects/SmartBuy/Photos/bg5.jpg��6;    J� Effect 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5      .+�5   
   �� -   5         ��Name$ image��5      $y�Hidden=�6   $X��RC:/Users/Niraj/Documents/Visual Studio 2015/Projects/SmartBuy/Photos/iphone-6s.jpg��63   $
��Left=�6�   $	��524��6�   $	��Top=�6�   $	��709��6�   $��633,106,0,0q�6�    J� OpacityMask
 �����{�.  6  �� 5   
   -   5         ��Name$ button��5      $
��Left=�6"   $	��Top=�6=   $	��151��6U   $��
84,312,0,0q�6a   $	��130��6u   
�������
����������	#FFFFFCFC 5        5      .��5      �� -   5        $ image1��5      $\��VC:/Users/Niraj/Documents/Visual Studio 2015/Projects/SmartBuy/Photos/mobile-2-icon.png��6$   
 �����	 � Cursor$
	 Hand��6�   
 J� RenderTransformOrigin$
 
0.394,1.35&�6�   $	��120��6�   $	��141��6�   5      �� 5   
   -   5         ��Name$ label��5      $��Explore.��6   $
��Left=�62   $��46��6M   $��106,247,0,0q�6Y   $	��Top=�6n   $	��151��6�   $��29.333(�6�   �� 5   
   -   5        $ button_Copy��5      $
��Left=�6'   $	��Top=�6B   $	��187��6Z   $��
84,312,0,0q�6f   $	��176��6z   ���	#FF002FAC
����������	#FFFFFCFC$��3q�6�   .��5      �� -   5        $ image2��5      $\��VC:/Users/Niraj/Documents/Visual Studio 2015/Projects/SmartBuy/Photos/mobile-2-icon.png��6$   
 �����$
	 Hand��6�   $
 
0.394,1.35&�6�   $	��166��6�   $	��187��6�   5      �� 5   
   -   5        $ button1��5      $
��Left=�6"   $	��176��6=   $��299,312,0,0q�6J   $	��Top=�6_   $	��192��6w   ���	#FF002FAC
�������$��3q�6�   .��5      �� -   5        $ image3��5      $V��PC:/Users/Niraj/Documents/Visual Studio 2015/Projects/SmartBuy/Photos/profile.png��6$   $	��146��6~   $	��188��6�   5      �� 5   
   -	   5        $ 
label_Copy��5      $��Profile.��6$   $
��Left=�67   $��46��6R   $��331,247,0,0q�6^   $	��Top=�6s   $	��151��6�   $��29.333(�6�   �� 5    
   -
   5        $ button2��5       $
��Left=�6"   $	��105��6=   $��
66,593,0,0q�6J   $	��Top=�6^   $��86��6v   ���	#FF4DD9F0$��2q�6�   ��6�   Z� .��5!      �� -   5        $ image5��5!      $U��OC:/Users/Niraj/Documents/Visual Studio 2015/Projects/SmartBuy/Photos/logout.png��6$   $��86��6}   $��76��6�   $
 0.588,-0.116&�6�   5"      �� 5#   
   -   5        $ label1��5#      $��Log Out.��6    $
��Left=�63   $��42��6N   $��
59,694,0,0q�6Z   $	��Top=�6n   $	��129��6�   $��24(�6�   $��Segoe UI Historic)�6�   �� 5$   
   -   5        $ label2��5$      $��Hello��6    $
��Left=�60   $��89��6K   $��	75,93,0,0q�6W   $	��Top=�6j   $	��160��6�   $��Verdana)�6�   $��53.333(�6�   �� 5%   
   -   5        $
 name��5%      $�� ��6   $
��Left=�6)   $��89��6D   $��
223,93,0,0q�6P   $	��Top=�6d   $	��405��6|   $��53.333(�6�   $��Verdana)�6�   �� 5&   
   ���	#FFF4F4F5$
��Left=�6%   $	��758��6@   $��	676,0,0,0q�6M   
�������$	��Top=�6o   $	��712��6�   
 �����6�   r� 5'   
   -   5         r�Name$ mediaElement��5'   s    r� Source$X RC:/Users/Niraj/Documents/Visual Studio 2015/Projects/SmartBuy/Videos/OnePlus X.mp4?�6   $
��Left=�6�   $	��312��6�   $��
692,13,0,0q�6�   $	��Top=�6�   $	��681��6�    r� LoadedBehavior$ Manual=�6�    r� UnloadedBehavior$ Manual=�6   r� Volume$	 100Q�6  5(      �� 5)   
   -   5        $ 
image_Copy��5)      $S��MC:/Users/Niraj/Documents/Visual Studio 2015/Projects/SmartBuy/Photos/oxad.png��6$   $
��Left=�6{   $	��365��6�   $��676,371,0,0q�6�   $	��Top=�6�   $	��703��6�   5+      5,      
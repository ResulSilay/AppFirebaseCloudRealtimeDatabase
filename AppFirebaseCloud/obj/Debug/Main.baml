   M S B A M L   `   `   `  ����K  GAppFirebaseCloud, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:AppFirebaseCloudAppFirebaseCloud  5          AppFirebaseCloud.Main   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:AppFirebaseCloud     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � Title$  
MainWindow��5      $��1210.76��5	      $	��584��5
      ���#FFCB2D � WindowStartupLocation$ CenterScreen=�5       � WindowStyle$
 None=�5      .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      $��35 �6    �� 5      $��* �6    .+�5      � -   5        $��Toolbar��5      $��0��5      
������ .+�5      �� -   5        $��btnExit��5      $��40��5      $��Right=�5      
������ $��0q�5       $��X��5"      �� 5#      -   5        $��btnFull��5$      $��40��5%      $��0,0,40,0q�5&      $��Right=�5'      
������ $��0q�5)      $��[]��5+      �� 5,      -   5        $��btnMinimize��5-      $��40��5.      $��0,0,80,0q�5/      $��Right=�50      
������ $��0q�52      $��_��54      55      � 56      $��1��6    � ColumnDefinitions 57      �� 58      $��1* �6'   �� 59      $
��1.5* �6'   �� 5:      $
��1.5* �6'    5<      �� 5=      $��* �6$   .+�5@      � $��0��6   .+�5A       � $��Stretch=�5B      $��Stretch=�5C      $��Stretch=�5D      $��Stretch=�5E        � Source$  /Pages/StudentConnect.xaml?�5F      5G      � 5H      $��1��6   .+�5I       � $��
10,50,0,50q�5J      
�������$ /Pages/StudentList.xaml?�5L       J� BitmapEffect 5M      F� 5N       F� 	Direction$ 5Q�5O   !    F� Opacity$
 0.15Q�5P   !   	 F� ShadowDepth$	 0Q�5Q   !   
 F� Softness$	
 100Q�5R   !    F� Color$ Black��5S   !   5U      5V      � 5W      $��2��6   .+�5X       � $��20,50,50,50q�5Y      
�������$ /Pages/StudentInsert.xaml?�5[       5\      F� 5]      $ 5Q�5^   !   $
 0.15Q�5_   !   $	 0Q�5`   !   $	
 100Q�5a   !   $ Black��5b   !   5d      5e      5f      5g      5h      5i      
   M S B A M L   `   `   `  ����K  GSklepKomputerowy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:SklepKomputerowySklepKomputerowy  5   	   !    SklepKomputerowy.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:SklepKomputerowy     5   	     � Title$  Sklep Komputerowy��5   	   $	��400��6#   $	��800��60    � 	Resources 5	       �� 
TargetType �� Property �� Value��%W   '��       �� 5
   
   " ��6   .�5      ��  � ��$ Stretch=�6;   5      5      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      $
��Auto �6   $��97.04��6*   �� 5      $��0* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   .+�5   
   ]� .+�5      o� 
�������$��0q�6&   .@�5      m� $
��Plik��6   $��5,0,0,0q�6)   .@�5      m�  m� Command$	 New��6   �� 5      m� 5      -   5        $��Wyjdź��5      6.   5      5      5      ]� 5    
   .+�5!      �� -   5         ��Name$ ProductListView��5!      $	��201��60   $	��464��6=   $��20(�6I   $��2q�6X   
���   �	 �� View	 5"      �� 5#      .P�5$      �� $��Id��6)   
 �� Width$
 70��6Y    �� DisplayMemberBinding 65   �� *Id+6Y   �� 5%      $��Nazwa produktu��6)   $	
 220��6g    6A   �� *Name+6g   �� 5&      $
��Cena��6)   $	
 150��6^    67   �� *Price+6^   5'      5)      5*      � 5,   
   $��Center=�6   $	��464��62   $��1��6>   $	��Top=�6K   $��58��6c   $��0,10,0,0q�6o   .+�5-      �� -   5        $��Dodaj��5-      $	��130��6%   $��36��61   $��10q�6=   $��20(�6a   ���#10BD38
�������$
��Bold"�6�   �� 5.      -   5        $��Edytuj��5.      $	��130��6&   $��36��62   $��10q�6>   $��20(�6c   ���#10BD38
�������$
��Bold"�6�   �� 5/      -   5        $	��Kup��5/      $	��130��6#   $��36��6/   $��10q�6;   $��20(�6_   ���#10BD38
�������$
��Bold"�6�   50      �� 51   
   $��img/laptop2.png��6   $��608,192,13,29q�6)   $��2��6@   �� 52   
   $��img/computer.png��6   $��11,90,641,89q�6*   53      57      
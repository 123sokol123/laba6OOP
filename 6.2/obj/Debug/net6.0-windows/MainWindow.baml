   M S B A M L   `   `   `  ����>  :5.1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:_5._1_5._1  5   	       _5._1.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:_5._1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   .+�5   
   �� -   5        $��1��5   .   $��Create Instance��6;   $��Stretch=�6U   $��Stretch=�6q   �� 5   
   -   5        $��2��5   0   $��Start Collecting��6=   $��Stretch=�6X   $��Stretch=�6t   �� 5   
   -   5        $��3��5   *   $��Get RawData��67   $��Stretch=�6M   $��Stretch=�6i   �� 5   
   -   5        $��4��5   *   $��Get Metric Value��67   $��Stretch=�6R   $��Stretch=�6n   �� 5   
   -   5        $��5��5   +   $��Get Imperial Value��68   $��Stretch=�6U   $��Stretch=�6q   �� 5   
   -   5        $��6��5   /   $��Stop Collecting��6<   $��Stretch=�6V   $��Stretch=�6r   	� 5   
   -   5        $��Imperial_Button��5   1    d� 	IsChecked$
 TrueY�6H   $��0��6Y   $��Imperial��6f   $
��Left=�6y   $��Center=�6�   	� 5   
   -   5        $��Metric_Button��5   1   $��0��6F   $��Metric��6S   $��Right=�6d   $��Center=�6�   �� 5    
   -	   5        $
��logs��5       $�� ��6   $��Center=�6'   $��Center=�6K   $��7��6n   $��Stretch=�6{   $��Stretch=�6�   �� 5!   
   -
   5        $��HeartBeatLabel��5!      $��	HeartBeat��6&   $
��Left=�6:   $	��Top=�6U   $��	362,9,0,0q�6m   �� 5"   
   -   5        $��Dispose��5"   '   $��Dispose��66   $
��Left=�6H   $��
115,12,0,0q�6c   $	��Top=�6w   5#      5$      
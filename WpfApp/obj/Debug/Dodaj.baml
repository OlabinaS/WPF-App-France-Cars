   M S B A M L   `   `   `  ����A  =WpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WpfAppWpfApp  5   	       WpfApp.Dodaj   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:WpfApp     5   	   -   5          � Title$  Dodaj��5   	    � SizeToContent$ WidthAndHeight=�6    � WindowStyle$
 None=�66    � AllowsTransparency . 
������ .��5	      �� $	��400��6   $	��450��6   .+�5
   
   F� 
����  �$��2��6   ��5      �� 5       �� Color$ Wheat��6"   ��5      B� 5      .��5      E�  E� 
StartPoint$ 50,25&�6!   .��5      ��  �� Size$ 25,25��6%    �� RotationAngle$ 0Q�62    �� 
IsLargeArc . 	 �� SweepDirection$	 Counterclockwise=�6V   
 �� Point$
 25,50&�6x   �� 5       �� Point$ 0,420&�6&   �� 5      $ 175,420&�6&   �� 5      $ 150,450&�6&   �� 5      $ 250,450&�6&   �� 5      $ 225,420&�6&   �� 5      $ 400,420&�6&   �� 5      $ 375,50&�6&   �� 5      $ 25,25��6%   $ 0Q�62    . $	 Counterclockwise=�6V   $
 350,25&�6x   �� 5      $ 50,25&�6&   5      5      5      �� 5    
   -   5         ��Name$ btnDodaj��5       $��Dodaj��6#    �� Left$	 175��63   
 �� Top$	 425��6E   $��50��6V   $��20��6a   6m   �� 5!   
   -   5        $ 	btnIzadji��5!      $��Izadji��6$   $	 360��65   $ 14��6G   $��31��6W   $��20��6b   6n   �� 5#   
   -   5         ��Name$ labelaMarka��5#      $��Marka: ��6%   $ 30��67   $ 55��6H   
�������$��60��6k   $��25��6v   �� 5$   
   -   5         ��Name$ comboBoxMarke��5$      $	 100��6*   $ 55��6<   $	��220��6L   $��25��6X   �� 5%   
   -   5        $ 
MarkaError��5%      $�� ��6$   
���  ��$	 100��6@   $ 75��6R   $��23��6b   $	��220��6n   $��11(�6z   �� 5'   
   -   5        $ labelaModel��5'      $��Model: ��6%   $ 30��67   $	 100��6H   
�������$��60��6l   $��25��6w   �� 5(   
   -   5         ��Name$ textBoxModel��5(      $�� ��6(   $	 100��60   $	 100��6B   $	��220��6S   $��25��6_   6�   �� 5)   
   -	   5        $ 
ModelError��5)      $�� ��6$   
���  ��$	 100��6@   $	 120��6R   $��23��6c   $	��220��6o   $��11(�6{   �� 5+   
   -
   5        $ labelaKubikaza��5+      $��
Kubikaza: ��6(   $ 30��6=   $	 145��6N   
�������$��25��6r   $��60��6~   �� 5,   
   -   5        $ textBoxKubikaza��5,      $�� ��6+   $	 100��63   $	 145��6E   $	��220��6V   $��25��6b   6�   �� 5-   
   -   5        $ KubikazaError��5-      $�� ��6'   
���  ��$	 100��6C   $	 165��6U   $��23��6f   $	��220��6r   $��11(�6~   �� 5/   
   -   5        $ 
labelaText��5/      $��Tekst: ��6$   $ 30��66   $	 190��6G   
�������$��25��6k   $��60��6w   �� 50   
   -   5        $ 	TextError��50      $�� ��6#   
���  ��$	 100��6?   $	 315��6Q   $��23��6b   $	��220��6n   $��11(�6z   ]� 52   
   $	��130��6   $	��280��6!   $	 190��6-   $	 100��6>   .+�53      c� $	��Top=�6   $��25��6+   .@�54      d� -   5        $��btnBold��54   D   $ ��EditingCommands.ToggleBold��6   $��B��6S   $��	UltraBold"�6_   d� 55      -   5        $��	btnItalic��55   F   $"��EditingCommands.ToggleItalic��6   $��I ��6W   $��Italic$�6d   $��Century)�6w   $��13��6�   d� 56      -   5        $��btnUnderline��56   I   $%��EditingCommands.ToggleUnderline��6   $��U��6]   �� 57      
���  ��6   �� 58      -   5        $��cmbFontFamily��58      $��90��60   $��2,0,0,0q�6;   6L   �� 59      -   5        $��cmbFontSize��59      $��30��6.   $��5,0,0,0q�69   6J   �� 5:      -   5        $��cmbFontColor��5:      $��40��6/   $��5,0,0,0q�6:   6K   �� 5;      -   5        $��labelWordCount��5;      $��35��6.   $��25��69   $�� ��6E   5=      �� 5?      -   5        $��	rtbEditor��5?      $	��105��6Y   $	��280��6f   $��0,0.2,0,-0.4q�6r   5@      �� 5B   
   -   5        $ 	btnBrowse��5B      $��Browse��6$   $ 30��65   $	 335��6F   $��60��6W   $��25��6b   6n   �� 5C   
   -   5        $ textBoxBrowse��5C      $ 30��6)   $	 370��6:   $	��120��6K   $��25��6W   �� 5D   
   $	��110��6   $��70��6    
���   �$��2��6;   $	 230��6O   $	 335��6a   ��5E      �� 5F       �� ImageSource 6   ��  �� ElementName$ textBoxBrowse�� �� Path$
 Text�5H      5K      5L      
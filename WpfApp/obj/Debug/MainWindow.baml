   M S B A M L   `   `   `  ����A  =WpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WpfAppWpfApp  5   	       WpfApp.MainWindow   5   
   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:WpfApp     5   	   -   5          � Title$  
MainWindow��5   	    � SizeToContent$ WidthAndHeight=�6    � WindowStyle$
 None=�6;    � AllowsTransparency . 
������ .��5	      �� $	��800��6   $	��700��6    � 	Resources 5
   
   3  -System.Windows.Media.Effects.DropShadowEffect   dropMouseOverShadowRed   Color   	Direction  dropMouseOverShadowBlue��%m   &	        &	 ,       5      $	 Red��6>   $	 270Q�6J     5      $
 Blue��6?   $	 270Q�6L   5      .+�5   
   F� 
����  �$��2��6   ��5      �� 5       �� Color$ White��6"   ��5      B� 5      .��5      E�  E� 
StartPoint$ 100,50&�6!   .��5      �� 	 �� Size$	 50,50��6%   
 �� RotationAngle$
 0Q�62    �� 
IsLargeArc .  �� SweepDirection$ Counterclockwise=�6V    �� Point$ 50,100&�6x   �� 5       �� Point$ 0,650&�6&   �� 5      $ 300,650&�6&   �� 5      $ 250,700&�6&   �� 5      $ 550,700&�6&   �� 5      $ 500,650&�6&   �� 5      $ 800,650&�6&   �� 5      $ 750,100&�6&   �� 5      $	 50,50��6%   $
 0Q�62    . $ Counterclockwise=�6V   $ 700,50&�6x   �� 5      $ 100,50&�6&   5       5!      5#      �� 5%   
   $��All_logo.jpg��6    �� Left$ 50��6&   
 �� Top$ 51��67   $��90��6G   $	��125��6S   �� 5&   
   $��All_logo.jpg��6   $	 622��6&   $ 51��68   $��90��6H   $	��125��6T   &   System.Windows.Controls.DataGrid  5(   
   -   5          Name$ dataGridCar��5(      $
��Left=�6K   $	��Top=�6f   $ 51��6~   $	 175��6�   $	��450��6�   $	��698��6�      CanUserSortColumns .     CanUserReorderColumns .     CanUserResizeColumns .    
IsReadOnly .    SelectionMode$ Single=�6      AutoGenerateColumns .  ��6(   �� *
Automobili+   Columns 5)      4  .System.Windows.Controls.DataGridTemplateColumn  5*      ,  &System.Windows.Controls.DataGridColumn   Header$ Slika��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ 80 68      CellTemplate 5+      �� 5,      .R�5-      �� ��6$   �� *PictureFile+5.      50      0  *System.Windows.Controls.DataGridTextColumn  52      $ Marka��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 64   �� *Marka+  53      $ Model��6%    64   �� *Model+  54      $ Kubikaza��6%    67   �� *
Kubikaza+  55      $ Datum izmene��6%    6;   �� *DatumIzmene+  56      $ Tekst��6%   $ * 6M    64   �� *Text+6M     58      $  ��6)   $ 90 63    59      �� 5:      .R�5;      ��  �� Orientation$ Vertical=�6)   .+�5<   "   ��  ��Name$ btnProcitaj��6)   -   5        $��Procitaj��5<   >   $��20��6Q   6]   �� 5=   "   $ 	btnIzmeni��6)   -   5        $��Izmeni��5=   <   $��20��6M   6Y   �� 5>   "   $ 	btnObrisi��6)   -   5        $��Obrisi��5>   <   $��20��6M   6Y   5?      5@      5B      5E      �� 5H   
   $��Center=�6   $��Center=�6-   $��
France car��6H   $	 305��6]   $ 51��6o   $��67��6   $	��202��6�   $��40(�6�   $
��Bold"�6�   �� 5J   
   -   5        $��btnClose��5J      $��Izadji��6!   $	 325��6I   $	 657��6[   $��35��6l   $	��150��6x   ��5K      �� 5L       �� 
TargetType" ��6     �� Triggers  5M      P� 5N      ! P� Property! �@J�IsMouseOver" P� Value" . . �5O      �� # �� Property# �@J�Effect$ �� Value#$ [  67   5P      5R      5T      �� 5V   
   -   5        $��btnDodaj��5V      $��Dodaj��6!   $	 325��61   $	 140��6C   $��30��6T   $	��150��6`   ��5W      �� 5X      " ��6     5Y      P� 5Z      ! �@J�IsMouseOver" . . �5[      �� # �@J�Effect#$ [ 67   5\      5^      5`      5c      5d      
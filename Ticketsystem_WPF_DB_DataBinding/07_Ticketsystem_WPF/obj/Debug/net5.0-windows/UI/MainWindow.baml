   M S B A M L   `   `   `  ����Z  VTicketsystem_WPF_DB_DataBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Ticketsystem_WPFTicketsystem_WPF  5   	   !    Ticketsystem_WPF.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Ticketsystem_WPF     5   	   -   5          � Title$  Ticketsystem��5   	   $	��450��6   $	��800��6+   .��5	      �    mvmodel � DataContext# [  6   .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	lbTickets��5
         AutoGenerateColumns$ False��6k      
IsReadOnly$
 True��6�   $��71,44,100,74q�6�   ��6&   �� *	LstTicket+ �� SelectedItem 6H   �� *	SelTicket+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 50* 6%      Header$ Beschreibung��61   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6G   �� *Beschreibung+  5      $	 20* 6%   $ Status��61   	 6A   �� *Status+  5      $	 30* 6%   $ Erstell Datum��61   	 6H   �� *	Zeitpunkt+
 �� StringFormat$
 
dd.MM.yyyy��5      �� 5   
   -   5         ��Name$ btNeu��5      $	��Neu��6    $
��Left=�6.   $��	70,0,0,25q�6I   $��Bottom=�6\   $��75��6w   6�   �� 5   
   -   5        $ btBearbeiten��5      ${�False��6'   $��
Bearbeiten��69   $
��Left=�6N   $��
175,0,0,25q�6i   $��Bottom=�6}   $��75��6�   6�   �� 5   
   -   5        $ 
btLoeschen��5      ${�False��6%   $��Löschen��67   $
��Left=�6I   $��
280,0,0,25q�6d   $��Bottom=�6x   $��75��6�   6�   �� 5   
   -   5        $ btEnde��5      $
��Ende��6!   $
��Left=�60   $��
675,0,0,25q�6K   $��Bottom=�6_   $��75��6z   6�   �� 5   
   -   5        $ btProtokoll��5      $��	Protokoll��6&   $
��Left=�6:   $��Bottom=�6U   $��
385,0,0,25q�6p   $��75��6�   6�   5      5      
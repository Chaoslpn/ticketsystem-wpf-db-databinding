   M S B A M L   `   `   `  ����Z  VTicketsystem_WPF_DB_DataBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Ticketsystem_WPFTicketsystem_WPF  5   	   #    Ticketsystem_WPF.ProtokollDlg   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Ticketsystem_WPF     5   	     � Title$  ProtokollDlg��5   	   $	��450��6   $	��800��6+   .��5	      �    mvmodel � DataContext# [  6   .+�5
   
   �� $��Protokoll zum Ticket:��6   $
��Left=�60   $��	50,40,0,0q�6K   $	��Top=�6^   $
��Bold"�6v   �� 5   
   -   5         ��Name$ lblTicketBez��5      $
��Left=�6Q   $��
185,40,0,0q�6l   $	��Top=�6�   $��26��6�   $	��312��6�   ��6&   �� *SelTicket.Beschreibung+6�   �� 5   
   $��Aktueller Status:��6   $
��Left=�6,   $��
502,40,0,0q�6G   $	��Top=�6[   $
��Bold"�6s   �� 5   
   -   5        $ lblTicketStat��5      $
��Left=�6L   $��
610,40,0,0q�6g   $	��Top=�6{   $��26��6�   $	��140��6�   ��6'   �� *SelTicket.Status+6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ lbTicket��5         AutoGenerateColumns$ False��6J      
IsReadOnly$
 True��6f   $��50,100,50,175q�6y   ��6%   �� *LstProtokoll+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 20* 6%      Header$ Datum��61   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6@   �� *Date+  5      $	 20* 6%   $ 
Bearbeiter��61   	 6E   �� *
Bearbeiter+  5      $	 30* 6%   $ Status��61   	 6A   �� *Status+5      �� 5   
   -   5        
 ��Name$
 btClose��5      $��
Schließen��6"   $	��100��66   $
��Left=�6B   $��650,350,0,0q�6]   $	��Top=�6r   6�   5      5      
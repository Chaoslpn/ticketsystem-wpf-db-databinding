   M S B A M L   `   `   `  ����Z  VTicketsystem_WPF_DB_DataBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Ticketsystem_WPFTicketsystem_WPF  5   	   &     Ticketsystem_WPF.TicketDetailDlg   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Ticketsystem_WPF     5   	     � Title$  TicketDetailDlg��5   	   $	��450��6!   $	��800��6.   .��5	      �    mvmodel � DataContext# [  6    � ColumnDefinitions 5
   
   �� 5      $	��63* �6   �� 5      $
��337* �6   .+�5   
   �� $��Kunde��6   $
��Left=�6    $��	23,41,0,0q�6;   $	��Top=�6N   $��93��6f   �� 5   
   $��Datum��6   $
��Left=�6    $��	23,82,0,0q�6;   $	��Top=�6N   $��92��6f   �� 5   
   $��Meldungstext��6   $
��Left=�6'   $��
23,143,0,0q�6B   $	��Top=�6V   $��92��6n   �� 5   
   $��Status��6   $
��Left=�6!   $��
23,309,0,0q�6<   $	��Top=�6P   $��92��6h    J� RenderTransformOrigin$ 0.493,2.522&�6s   �� 5   
   -   5         ��Name$
 btOK��5      $��OK��6   $
��Left=�6,   $��	39,0,0,23q�6G   $��Bottom=�6Z   $��59��6u   6�   �� 5   
   -   5        $ btAbbrechen��5      $��	Abbrechen��6&   $
��Left=�6:   $��
574,0,0,28q�6U   $��Bottom=�6i   $��90��6�   $��1��6�   6�   �� 5   
   -   5         ��Name$ cbKunde��5      $��	30,38,0,0q�6n   $ �� IsSynchronizedWithCurrentItem$
 TrueY�6�   $��28��6�   $	��Top=�6�   $
��Left=�6�   $	��357��6�   $��1��6�   ��6$   �� *
LstKunde+ �� SelectedItem 6E   �� *SelTicket.Kunde+6�   �� 5   
   -   5         ��Name$ tbBeschreibung��5      $��
30,156,0,0q�6*   	 �� TextWrapping$
	 Wrap=�6>   $
��Left=�6R   $	��244��6m   $	��110��6y   $	��Top=�6�   $��1��6�   ��6�   �� *SelTicket.Beschreibung+6�   �� 5   
   -   5        $ cbStatus��5      $��
30,307,0,0q�6r   
 �� SelectedIndex$
 0��6�   $
��Left=�6�   $	��244��6�   $��25��6�   $	��Top=�6�   $��1��6�   ��6%   �� *	LstStatus+ 6G   �� *SelTicket.Status+6�   �� 5   
   -   5        $ btKundeHinzufuegen��5      $��Kunde hinzufügen��6-   $
��Left=�6H   $��
438,38,0,0q�6c   $	��Top=�6w   $	��107��6�   $��28��6�   $��1��6�   6�   �� 5   
   -   5         ��Name$ lblDatum��5       �� ContentStringFormat$ 
dd.MM.yyyy��6J   $
��Left=�6k   $��	30,82,0,0q�6�   $	��Top=�6�   $��92��6�   $��1��6�   ��6"   �� *SelTicket.Zeitpunkt+6�   5      5      
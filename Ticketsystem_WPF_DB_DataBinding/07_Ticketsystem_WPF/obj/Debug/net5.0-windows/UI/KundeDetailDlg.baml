   M S B A M L   `   `   `  ����Z  VTicketsystem_WPF_DB_DataBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Ticketsystem_WPFTicketsystem_WPF  5   	   %    Ticketsystem_WPF.KundeDetailDlg   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Ticketsystem_WPF     5   	     � Title$  Neuen Kunden anlegen��5   	   $	��353��6&   $	��475��63   .��5	      � .+�5
   
   �� $��
Geschlecht��6   $
��Left=�6%   $��	24,24,0,0q�6@   $	��Top=�6S   �� 5   
   $��Vorname��6   $
��Left=�6"   $��	24,68,0,0q�6=   $	��Top=�6P   �� 5   
   $��Nachname��6   $
��Left=�6#   $��
24,115,0,0q�6>   $	��Top=�6R   �� 5   
   $��Geburtsdatum��6   $
��Left=�6'   $��
24,164,0,0q�6B   $	��Top=�6V   �� 5   
   -   5         ��Name$ cbGeschlecht��5      $
��Left=�6)   $��
163,27,0,0q�6D   $	��Top=�6X   $	��119��6p   �� 5   
   -   5         ��Name$ 	tbVorname��5      $
��Left=�6%   $��23��6@   $��
163,68,0,0q�6L    �� TextWrapping$
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��120��6�   �� 5   
   -   5        $ 
tbNachname��5      $
��Left=�6&   $��23��6A   $��163,115,0,0q�6M   $
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��120��6�   �� 5   
   -   5        $ 
tbGebDatum��5      $
��Left=�6&   $��23��6A   $��163,164,0,0q�6M   $
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��120��6�   �� 5   
   -   5         ��Name$ btAbbrechen��5      $��	Abbrechen��6&   $
��Left=�6:   $��
28,278,0,0q�6U   $	��Top=�6i   $��75��6�   6�   �� 5   
   -   5        $
 btOK��5      $��OK��6   $
��Left=�6,   $��313,278,0,0q�6G   $	��Top=�6\   $��75��6t   6   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ dpGebDat��5      $
��Left=�6'   $��313,169,0,0q�6B   $	��Top=�6W      FirstDayOfWeek$ Monday=�6o      SelectedDateFormat$ Short=�6�   5      5      
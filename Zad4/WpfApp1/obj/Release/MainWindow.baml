   M S B A M L   `   `   `  ���� B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1      WpfApp1.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:WpfApp1       � Title$  
MainWindow��$	��450��$	��800��.��� $��0,0,0,0q� � DataContext   WpfApp1.GlownyViewModel   � ColumnDefinitions �� $��4* ��� $��4* ��� $��4* ��� $��4* � � RowDefinitions �� $	��42* ��� $	��42* ��� $	��42* ��� $	��42* ��� $	��42* ��� $	��42* ��� $	��41* ��� $
��147* �.+��� $��0��$��0��$��7������ *Wypozyczeniaa+ �� SelectedItem �� *BiezaceWypozyczenie+���� .R���  �� Orientation$ 
Horizontal=�.+��� ���� *id_w+�� ���� *	sygnatura+�� ���� *id_czytelnika+�� ���� *tytul_ksiazki+�� $��Pobierz z bazy dane��$��0��$��	0,67,0,20q�$��7��$��2������ *GetDataCommand+�� $��Dodaj Czytelnika��$��1��$
��Left=�$��7��$	��Top=�$	��200��$��68������ *DodajOknoDodawaniaKlienta+�� $��Usun Wybrane Wypozyczenie��$
��Left=�$��7��$	��Top=�$	��200��$��68������ *DeleteProductReviewCommand+�� $��1��$��0��$��7������ *Czytelnicyy+ �� *BiezacyCzytelnik+���� .R��� $ 
Horizontal=�.+��� ���� *id_czytelnika+�� ���� *imie+�� ���� *
nazwisko+�� ���� *pesel+�� ���� *	telefon+�� $��Id Wypozyczenia: ��$��2��$
��Left=�$	��Top=�$��40��$	��198���� $��3��$
��Left=�$��42�� �� TextWrapping$
 Wrap=�$	��Top=�$	��198��$��2������ *NewWypozyczeniaId+�� $��Sygnatura: ��$��2��$
��Left=�$��1��$	��Top=�$��40��$	��198���� $��3��$
��Left=�$��40��$��1��$
 Wrap=�$	��Top=�$	��198������ *NewWypozyczeniaSygnatura+�� $��Id Czytelnika: ��$��2��$
��Left=�$��2��$	��Top=�$��40��$	��198���� $��3��$
��Left=�$��40��$��2��$
 Wrap=�$	��Top=�$	��198������ *NewWypozyczeniaIdCzytelnika+�� $��Tytul ksiazki: ��$��2��$
��Left=�$��3��$	��Top=�$��40��$	��198���� $��3��$
��Left=�$��40��$��3��$
 Wrap=�$	��Top=�$	��198������ *NewWypozyczenieTytulKsiazki+�� $��Autor: ��$��2��$
��Left=�$��4��$	��Top=�$��40��$	��198���� $��3��$
��Left=�$��40��$��4��$
 Wrap=�$	��Top=�$	��198������ *NewWypozyczenieAutor+�� $��Gatunek:��$��2��$
��Left=�$��	74,10,0,0q�$��5��$	��Top=��� $��3��$
��Left=�$��40��$��5��$
 Wrap=�$	��Top=�$	��198������ *NewWypozyczenieGatunek+�� $��Kara: ��$��2��$
��Left=�$��6��$	��Top=�$��40��$	��198���� $��3��$
��Left=�$��40��$��6��$
 Wrap=�$	��Top=�$	��198������ *NewWypozyczenieKara+�� $��Dodaj Wypozyczenie��$��2��$
��Left=�$��7��$	��Top=�$	��396��$��68��$��2������ *AddProductReviewCommand+
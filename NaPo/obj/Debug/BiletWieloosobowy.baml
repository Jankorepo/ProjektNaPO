   M S B A M L   `   `   `  ����?  ;NaPo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:NaPoNaPo  5          NaPo.BiletWieloosobowy   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      $localclr-namespace:NaPo     5        � WindowStyle$
  None=�5   	    � WindowStartupLocation$ CenterScreen=�5	   	    � Title$ BiletWieloosobowy��5      .��5      � .+�5   
   �� -   5         ��Name$ Klik1��5      $ ��Kup bilet i drukuj paragon��6    $
��Left=�6E   $��275,502,0,0q�6`   $	��Top=�6u   $	��271��6�   $��58��6�    J� RenderTransformOrigin$ 0.495,0.519&�6�   6�   �� 5   
   -   5        $��Anuluj��5      $
��Left=�6"   $	��Top=�6=   $��50��6U   $��
713,20,0,0q�6`   $��50��6t   6�   �� 5   
   -   5         ��Name$" TextWybierzPoczątekPodrózy��5      {�.  $
��Left=�6H   $��22��6c   $��	37,64,0,0q�6o    �� TextWrapping$
 Wrap=�6�   $!��Wybierz początek podróży��6�   $	��Top=�6�   $	��151��6�   �� 5   
   -   5        $ PoleTextowe2��5      {�.  $
��Left=�6:   $��42��6U   $��
37,132,0,0q�6a   $
 Wrap=�6u   $1��+Wpisz datę podróży w formacie dd-mm-rrrr��6�   $	��Top=�6�   $	��151��6�   �� 5   
   -   5        $ PoleTextowe4��5      {�.  $
��Left=�6:   $��22��6U   $��
37,224,0,0q�6a   $
 Wrap=�6u   $A��;Liczba osób ze zniżką dziecięcą (do lat 3, 75% rabatu)��6�   $	��Top=�6�   $	��350��6�   �� 5   
   -   5        $ PoleTextowe6��5      {�.  $
��Left=�6:   $��22��6U   $��	37,96,0,0q�6a   $
 Wrap=�6t   $��Wybierz cel podróży��6�   $	��Top=�6�   $	��151��6�   �� 5   
   -   5        $ PoleTextowe7��5      {�.  $
��Left=�6:   $��40��6U   $��
324,10,0,0q�6a   $
 Wrap=�6u   $!��Wpisz dane swojej podróży��6�   $	��Top=�6�   $	��185��6�   �� 5   
   -   5        $ PoleTextowe9��5      {�.  $
��Left=�6:   $��22��6U   $��
37,265,0,0q�6a   $
 Wrap=�6u   $B��<Liczba osób ze zniżką uczniowską/studencką (50% rabatu)��6�   $	��Top=�6�   $	��350��6�   �� 5   
   -	   5        $ PoleTextowe10��5      {�.  $
��Left=�6;   $��22��6V   $��
37,303,0,0q�6b   $
 Wrap=�6v   $E��?Liczba osób ze zniżka emeryta/niepełnosprawnego (25% rabatu)��6�   $	��Top=�6�   $	��350��6�   �� 5   
   -
   5         ��Name$
 Com1��5      $
��Left=�6!   $	��Top=�6<   $	��100��6T   $��
217,64,0,0q�6`   $��22��6t   6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ DatePicker1��5      $
��Left=�6*   $	��Top=�6E   $��217,132,0,0q�6]   $��42��6r   $	��100��6~   �� 5   
   -   5        $ TextBiletyNormalne��5      $
��Left=�6.   $��22��6I   $
 Wrap=�6U   $��0��6i   $	��Top=�6r   $	��120��6�   $��426,188,0,0q�6�   6�   �� 5   
   -   5        $ TextBiletyDziecięce��5      $
��Left=�6/   $��22��6J   $
 Wrap=�6V   $��0��6j   $	��Top=�6s   $	��120��6�   $��426,224,0,0q�6�   6�   �� 5   
   -   5        $ TextBiletyStudenckie��5      $
��Left=�60   $��22��6K   $
 Wrap=�6W   $��0��6k   $	��Top=�6t   $	��120��6�   $��426,265,0,0q�6�   6�   �� 5   
   -   5        $ TextBiletyEmeryckie��5      $
��Left=�6/   $��22��6J   $
 Wrap=�6V   $	��Top=�6j   $	��120��6�   $��426,303,0,0q�6�   $��0��6�   6�   �� 5   
   -   5        $ PoleTextowe4_Copy��5      {�.  $
��Left=�6?   $��22��6Z   $��
37,188,0,0q�6f   $
 Wrap=�6z   $��Liczba osób bez zniżek��6�   $	��Top=�6�   $	��350��6�   �� 5   
   -   5        $
 Com2��5      $
��Left=�6!   $	��Top=�6<   $	��100��6T   $��
217,96,0,0q�6`   $��22��6t   6�   �� 5   
   $
��Left=�6   {�.  $��23��6?   $
 Wrap=�6K   $��Bilet w obie strony?��6_   $	��Top=�6{   $	��151��6�   $��
37,343,0,0q�6�   �� 5   
   -   5        $
 Com3��5      $
��Left=�6!   $	��Top=�6<   $	��100��6T   $��217,344,0,0q�6`   $��22��6u   6�   ��5    
   �� 5!      	 �� ImageSource$	 Zdjęcia/Autobus2.jpg��6   
 j� Stretch$
 UniformToFill=�6<   5#      5$      
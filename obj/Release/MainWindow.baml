   M S B A M L   `   `   `  ���� K  GTic Tac Toe Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1      WpfApp1.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:WpfApp1       � WindowStartupLocation$  CenterScreen=� � Title$ Game Tic Tac Toe��$	��350��$	��350��$	��500��$	��500�����	#FF533636���	#FFE2E2E2$��5,0,5,5q����	#FFE2E2E2 � Icon$ download_5iJ_icon.ico��.���  � RowDefinitions �� $��30��$��30 ��� $��40��$��81 ��� $��* �.+�o� $��0��
�������.@�m� 
���   �$
��File��$��20(�$��0q�.@�m� -    m�Name$ 	load_menu��$
��Load��$��20(�$��0q�m� -   $ 	save_menu��$
��Save��$��20(�$��0q�m� -   $ ExitMenuItem��$
��Exit��$��20(�$��0q�m� $
��Game��$��20(�$��0q�
���   �.@�m� -   $��restart game��m� $
��Help��$��20(�$��0q�
���   �m� $��About��$��20(�$��0q�
���   �� $��1�� �� $��40��$��* ��� $��40��$��* � � ColumnDefinitions �� $��30��$
��auto ��� $��50��$��* ��� $��30��$
��auto ��� $��50��$��* �.+��� $��0��$��0��$��	Player1: ��$
��Bold"�$��15(��� $��0��$��2��$��	Player2: ��$
��Bold"�$��15(��� $��1��$��0��$��Score: ��$
��Bold"�$��15(��� -    ��Name$ player_1_score��$��1��$��1��$��0��$
��Bold"�$��15(��� -   $ player_2_score��$��1��$��3��$��0��$
��Bold"�$��15(��� $��1��$��2��$��Score: ��$
��Bold"�$��15(��� -   $ rectangle_blue��$��0��$��1��
����ح����	#FF111010$��0q��� -   $ rectangle_red��$��0��$��3��
����������	#FF111010$��0q�� $��2�� �� $��50��$��* ��� $��50��$��* ��� $��50��$��* � �� $��50��$��* ��� $��50��$��* ��� $��50��$��* �.+��� -	    ��Name$ button1��$��0��$��0��
��������� -
   $ button2��$��0��$��1��
��������� -   $ button3��$��0��$��2��
��������� -   $ button4��$��1��$��0��
��������� -   $ button5��$��1��$��1��
��������� -   $ button6��$��1��$��2��
��������� -   $ button7��$��2��$��0��
��������� -   $ button8��$��2��$��1��
��������� -   $ button9��$��2��$��2��
�������
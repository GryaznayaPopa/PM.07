   M S B A M L   `   `   `  ����I  EProgrammCourse, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ProgrammCourseProgrammCourse  5   	   '    !ProgrammCourse.ContractWindowList   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:ProgrammCourse     5   	     � Title$  ContractWindowList��5   	   $	��450��6$   $��948.729��61      windowStyle#��[  6A    � 	Resources 5	       �� Source�� 5
   
   $( "Resources/Themes/DefaultTheme.xaml?�6   %    6K   .��5      � .+�5   
   �� $��Создать заказ��6   $
��Left=�6)   $��
10,140,0,0q�6D   $	��Top=�6X   $	��143��6p   $��29��6|   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGridContract��5      $
��Left=�6-   $	��206��6H   $��
10,203,0,0q�6U   $	��Top=�6i   $	��749��6�      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Номер заказа��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *ContractNumber+6`     5      $ Клиент��6%    65   �� *	ClientFIO+6U     5      $% Дата составления��6%    6?   �� *
DataPrepar+6`     5      $# Дата исполнения��6%    6>   �� *
DataExec+6]     5      $% Состояние оплаты��6%    6?   �� *	PayStatus+6_     5      $) #Подробности заказа��6%    6A   �� *ContractDetails+6g     5      $ Статус заказа��6%    6<   �� *ContractStat+6_   5      �� 5   
   -   5         ��Name$ BackMenuContrButton��5      $��
Назад��6.   $
��Left=�6>   $��790,266,0,0q�6Y   $	��Top=�6n   $��75��6�   	 J� RenderTransformOrigin$	 0.663,0.675&�6�   $��29��6�   6�   �� 5   
   -   5        $ ExitButtonContract��5      $��
Выход��6-   $
��Left=�6=   $��790,366,0,0q�6X   $	��Top=�6m   $��75��6�   $	 0.663,0.675&�6�   $��29��6�   6�   �� 5   
   -   5        
 ��Name$
 LabelUserFIO��5      $��Label��6&   $
��Left=�66   $��
578,10,0,0q�6Q   $	��Top=�6e   �� 5   
   -   5         ��Name$ 	ImageUser��5      $
��Left=�6#   $	��100��6>   $��
457,14,0,0q�6K   $	��Top=�6_   $	��111��6w   $	 0.5,0.5&�6�   z�5      V� 5      .~�5      �� �� 5       �� 5!       �� Angle$ 0.383Q�6&   T� 5"      5#      5%      5'      5(      
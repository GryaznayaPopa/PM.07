   M S B A M L   `   `   `  ����I  EProgrammCourse, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ProgrammCourseProgrammCourse  5   	        ProgrammCourse.ClientsList   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:ProgrammCourse     5   	     � Title$  ClientsList��5   	   $	��450��6   $	��800��6*      windowStyle#��[  66   .��5	      � .+�5
   
   �� -   5        $��ButtonListBack��5
      $��
Назад��6'   $
��Left=�67   $��662,327,0,0q�6R   $	��Top=�6g   $��75��6   $��29��6�   6�   �� 5   
   -   5        $��ButtonListExit��5      $��
Выход��6'   $
��Left=�67   $��662,380,0,0q�6R   $	��Top=�6g   $��75��6   $��29��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DataGridClient��5      $
��Left=�6+   $	��227��6F   $��
10,182,0,0q�6S   $	��Top=�6g   $	��647��6      AutoGenerateColumns .     RowBackground
 �����   Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ № клиента��6)      CellTemplate 5      �� 5      .R�5      �� -   5        
 � Tag 5   $   �� *InforC+��6e   �� *InforC+6�   5      5      0  *System.Windows.Controls.DataGridTextColumn  5      $ Имя��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 62   �� *Name+6M     5      $ Фамилия��6%    66   �� *	Surname+6T     5      $ Отчество��6%    67   �� *
Patronymic+6X     5      $/ )Наименование компании��6%    6D   �� *NameCompany+6f     5      $! Номер телефона��6%    6=   �� *PhoneNumber+6_     5      $' !Электронная почта��6%    6@   �� *Email+6\   5      �� 5   
   -   5        $��ButtonAddClientW��5      $%��Добавить клиента��6)   $
��Left=�6D   $��
10,135,0,0q�6_   $	��Top=�6s   $	��125��6�   $��25��6�   6�   �� 5   
   -   5        	 ��Name$	 labelNFP��5      $��Label��6"   $
��Left=�62   $��
570,10,0,0q�6M   $	��Top=�6a   �� 5   
   -   5        
 ��Name$
 	ImageUser��5      $
��Left=�6#   $	��100��6>   $��
453,11,0,0q�6K   $	��Top=�6_   $	��111��6w    J� RenderTransformOrigin$ 0.5,0.5&�6�   z�5       V� 5!      .~�5"      �� �� 5#      �� 5$       �� Angle$ 0.383Q�6&   T� 5%      5&      5(      5*      5+      